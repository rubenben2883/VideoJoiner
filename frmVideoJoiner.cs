using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;

namespace VideoJoiner
{
    public partial class frmVideoJoiner : KryptonForm
    {
        public frmVideoJoiner()
        {
            InitializeComponent();
        }

        private void frmVideoJoiner_Load(object sender, EventArgs e)
        {

        }

        private async void btnUnirVideos_Click(object sender, EventArgs e)
        {
            try
            {
               if(  txtNombreFinal.Text == string.Empty)
                {
                    MessageBox.Show("El nombre final debe escribirse");
                    return;
                }

                string folderPath = txtRutaVideos.Text;
                if (string.IsNullOrEmpty(folderPath)) return;

                var files = Directory.GetFiles(folderPath, "*.mp4")
                                     .OrderByDescending(f => File.GetCreationTime(f))
                                     .ToList();

                if (files.Count == 0)
                {
                    MessageBox.Show("No se encontraron archivos MP4 en la carpeta.");
                    return;
                }

                // Crear list.txt en ANSI
                string listFile = Path.Combine(folderPath, "list.txt");
                using (var writer = new StreamWriter(listFile, false, Encoding.ASCII))
                {
                    foreach (var file in files)
                    {
                        writer.WriteLine($"file '{Path.GetFileName(file)}'");
                    }
                }

                string ffmpegPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ffmpeg.exe");
                string outputFile = Path.Combine(folderPath, txtNombreFinal.Text +".mp4");

                progressBar.Style = ProgressBarStyle.Marquee; // progreso indeterminado
                txtLog.Clear();

                await Task.Run(() =>
                {
                    var process = new Process();
                    process.StartInfo.FileName = ffmpegPath;
                    process.StartInfo.Arguments = $"-f concat -safe 0 -i \"{listFile}\" -c copy \"{outputFile}\"";
                    process.StartInfo.UseShellExecute = false;
                    process.StartInfo.RedirectStandardError = true;
                    process.StartInfo.RedirectStandardOutput = true;
                    process.StartInfo.CreateNoWindow = true;

                    process.OutputDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            Invoke(new Action(() => txtLog.AppendText(ev.Data + Environment.NewLine)));
                        }
                    };

                    process.ErrorDataReceived += (s, ev) =>
                    {
                        if (!string.IsNullOrEmpty(ev.Data))
                        {
                            Invoke(new Action(() => txtLog.AppendText(ev.Data + Environment.NewLine)));
                        }
                    };

                    process.Start();
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    process.WaitForExit();

                    //Ahora camabiamos la fecha del archivo para que coincida con los otros
                    // Después de que FFmpeg termina y genera salida.mp4
                   // string outputFile = Path.Combine(folderPath, "salida.mp4");

                    // Obtener fechas de los archivos fuente
                    //var files = Directory.GetFiles(folderPath, "*.mp4");
                    DateTime minDate = files.Min(f => File.GetCreationTime(f));
                    DateTime maxDate = files.Max(f => File.GetCreationTime(f));

                    // Ejemplo: usar la fecha más antigua
                    File.SetCreationTime(outputFile, minDate);
                    File.SetLastWriteTime(outputFile, minDate);

                    // Si prefieres la más reciente:
                    // File.SetCreationTime(outputFile, maxDate);
                    // File.SetLastWriteTime(outputFile, maxDate);

                });

                progressBar.Style = ProgressBarStyle.Blocks; // progreso terminado
                progressBar.Value = progressBar.Maximum;
                MessageBox.Show("Unión completada. Archivo generado: salida.mp4");


            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscarVideos_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtRutaVideos.Text = dialog.SelectedPath;
                }
            }

        }
    }
}
