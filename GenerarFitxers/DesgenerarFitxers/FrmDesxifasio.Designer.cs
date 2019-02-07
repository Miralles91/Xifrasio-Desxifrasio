namespace DesgenerarFitxers
{
    partial class FrmDesxifasio
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
            this.desxifraFitxers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // desxifraFitxers
            // 
            this.desxifraFitxers.BackColor = System.Drawing.Color.DarkOrange;
            this.desxifraFitxers.Font = new System.Drawing.Font("Stencil", 45.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desxifraFitxers.Location = new System.Drawing.Point(-2, 12);
            this.desxifraFitxers.Name = "desxifraFitxers";
            this.desxifraFitxers.Size = new System.Drawing.Size(809, 195);
            this.desxifraFitxers.TabIndex = 1;
            this.desxifraFitxers.Text = " Desxifra Fitxers";
            this.desxifraFitxers.UseVisualStyleBackColor = false;
            this.desxifraFitxers.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmDesxifasio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 204);
            this.Controls.Add(this.desxifraFitxers);
            this.Name = "FrmDesxifasio";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button desxifraFitxers;
    }
}

