namespace PiensaAjedrez
{
    partial class Mensualidades
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensualidades));
            this.lblMensualidades = new System.Windows.Forms.Label();
            this.lblSampleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMensualidades
            // 
            this.lblMensualidades.AutoSize = true;
            this.lblMensualidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblMensualidades.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblMensualidades.Location = new System.Drawing.Point(20, 20);
            this.lblMensualidades.Name = "lblMensualidades";
            this.lblMensualidades.Size = new System.Drawing.Size(324, 46);
            this.lblMensualidades.TabIndex = 3;
            this.lblMensualidades.Text = "Registro de pago";
            // 
            // lblSampleText
            // 
            this.lblSampleText.AutoSize = true;
            this.lblSampleText.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSampleText.ForeColor = System.Drawing.Color.Black;
            this.lblSampleText.Location = new System.Drawing.Point(23, 89);
            this.lblSampleText.Name = "lblSampleText";
            this.lblSampleText.Size = new System.Drawing.Size(833, 174);
            this.lblSampleText.TabIndex = 4;
            this.lblSampleText.Text = resources.GetString("lblSampleText.Text");
            // 
            // Mensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblSampleText);
            this.Controls.Add(this.lblMensualidades);
            this.Name = "Mensualidades";
            this.Size = new System.Drawing.Size(1342, 670);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensualidades;
        private System.Windows.Forms.Label lblSampleText;
    }
}
