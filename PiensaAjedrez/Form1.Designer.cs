namespace PiensaAjedrez
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.elpSinBordes = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panTrabajo = new System.Windows.Forms.Panel();
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Cerrar = new System.Windows.Forms.Label();
            this.PiensaAjedrez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elpSinBordes
            // 
            this.elpSinBordes.ElipseRadius = 5;
            this.elpSinBordes.TargetControl = this;
            // 
            // panTrabajo
            // 
            this.panTrabajo.Location = new System.Drawing.Point(300, 30);
            this.panTrabajo.Name = "panTrabajo";
            this.panTrabajo.Size = new System.Drawing.Size(1050, 720);
            this.panTrabajo.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.Maroon;
            this.panelMenu.GradientBottomRight = System.Drawing.Color.Firebrick;
            this.panelMenu.GradientTopLeft = System.Drawing.Color.Brown;
            this.panelMenu.GradientTopRight = System.Drawing.Color.Maroon;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(293, 767);
            this.panelMenu.TabIndex = 0;
            // 
            // Cerrar
            // 
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Doppio One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(1326, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(25, 26);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "X";
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            this.Cerrar.MouseEnter += new System.EventHandler(this.Cerrar_MouseEnter);
            this.Cerrar.MouseLeave += new System.EventHandler(this.Cerrar_MouseLeave);
            // 
            // PiensaAjedrez
            // 
            this.PiensaAjedrez.AutoSize = true;
            this.PiensaAjedrez.Font = new System.Drawing.Font("Doppio One", 16F);
            this.PiensaAjedrez.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.PiensaAjedrez.Location = new System.Drawing.Point(708, 1);
            this.PiensaAjedrez.Name = "PiensaAjedrez";
            this.PiensaAjedrez.Size = new System.Drawing.Size(163, 27);
            this.PiensaAjedrez.TabIndex = 2;
            this.PiensaAjedrez.Text = "Piensa Ajedrez";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.PiensaAjedrez);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panTrabajo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elpSinBordes;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private System.Windows.Forms.Panel panTrabajo;
        private System.Windows.Forms.Label Cerrar;
        private System.Windows.Forms.Label PiensaAjedrez;
    }
}

