namespace VideoJoiner
{
    partial class frmVideoJoiner
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtRutaVideos = new System.Windows.Forms.TextBox();
            this.btnBuscarVideos = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUnirVideos = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta de videos:";
            // 
            // txtRutaVideos
            // 
            this.txtRutaVideos.Location = new System.Drawing.Point(101, 32);
            this.txtRutaVideos.Name = "txtRutaVideos";
            this.txtRutaVideos.Size = new System.Drawing.Size(602, 20);
            this.txtRutaVideos.TabIndex = 1;
            // 
            // btnBuscarVideos
            // 
            this.btnBuscarVideos.Location = new System.Drawing.Point(741, 30);
            this.btnBuscarVideos.Name = "btnBuscarVideos";
            this.btnBuscarVideos.Size = new System.Drawing.Size(89, 23);
            this.btnBuscarVideos.TabIndex = 2;
            this.btnBuscarVideos.Text = "Buscar videos";
            this.btnBuscarVideos.UseVisualStyleBackColor = true;
            this.btnBuscarVideos.Click += new System.EventHandler(this.btnBuscarVideos_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(101, 186);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(602, 204);
            this.txtLog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Resultados:";
            // 
            // txtNombreFinal
            // 
            this.txtNombreFinal.Location = new System.Drawing.Point(101, 82);
            this.txtNombreFinal.Name = "txtNombreFinal";
            this.txtNombreFinal.Size = new System.Drawing.Size(602, 20);
            this.txtNombreFinal.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del video:";
            // 
            // btnUnirVideos
            // 
            this.btnUnirVideos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnirVideos.Location = new System.Drawing.Point(741, 68);
            this.btnUnirVideos.Name = "btnUnirVideos";
            this.btnUnirVideos.Size = new System.Drawing.Size(89, 47);
            this.btnUnirVideos.TabIndex = 7;
            this.btnUnirVideos.Text = "Unir videos";
            this.btnUnirVideos.UseVisualStyleBackColor = true;
            this.btnUnirVideos.Click += new System.EventHandler(this.btnUnirVideos_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(101, 127);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(602, 23);
            this.progressBar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Progreso:";
            // 
            // frmVideoJoiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnUnirVideos);
            this.Controls.Add(this.txtNombreFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnBuscarVideos);
            this.Controls.Add(this.txtRutaVideos);
            this.Controls.Add(this.label1);
            this.Name = "frmVideoJoiner";
            this.Text = "VideoJoiner*Une archivos de video GoPro en un Clic";
            this.Load += new System.EventHandler(this.frmVideoJoiner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRutaVideos;
        private System.Windows.Forms.Button btnBuscarVideos;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUnirVideos;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label4;
    }
}

