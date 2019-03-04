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
            this.Cerrar = new System.Windows.Forms.Label();
            this.PiensaAjedrez = new System.Windows.Forms.Label();
            this.elpTrabajo = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bnfArrastrar = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnPiensaAjedrez = new System.Windows.Forms.PictureBox();
            this.btnColegios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDesconectar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReportes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMensualidades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPiensaAjedrezEstetico = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnPiensaAjedrez)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPiensaAjedrezEstetico)).BeginInit();
            this.SuspendLayout();
            // 
            // elpSinBordes
            // 
            this.elpSinBordes.ElipseRadius = 5;
            this.elpSinBordes.TargetControl = this;
            // 
            // panTrabajo
            // 
            this.panTrabajo.BackColor = System.Drawing.Color.White;
            this.panTrabajo.Location = new System.Drawing.Point(12, 107);
            this.panTrabajo.Name = "panTrabajo";
            this.panTrabajo.Size = new System.Drawing.Size(1342, 649);
            this.panTrabajo.TabIndex = 0;
            // 
            // Cerrar
            // 
            this.Cerrar.AutoSize = true;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.Color.White;
            this.Cerrar.Location = new System.Drawing.Point(1326, 2);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(26, 25);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "X";
            this.Cerrar.Visible = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            this.Cerrar.MouseEnter += new System.EventHandler(this.Cerrar_MouseEnter);
            this.Cerrar.MouseLeave += new System.EventHandler(this.Cerrar_MouseLeave);
            // 
            // PiensaAjedrez
            // 
            this.PiensaAjedrez.AutoSize = true;
            this.PiensaAjedrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PiensaAjedrez.ForeColor = System.Drawing.Color.White;
            this.PiensaAjedrez.Location = new System.Drawing.Point(600, 1);
            this.PiensaAjedrez.Name = "PiensaAjedrez";
            this.PiensaAjedrez.Size = new System.Drawing.Size(159, 26);
            this.PiensaAjedrez.TabIndex = 2;
            this.PiensaAjedrez.Text = "Piensa Ajedrez";
            // 
            // elpTrabajo
            // 
            this.elpTrabajo.ElipseRadius = 12;
            this.elpTrabajo.TargetControl = this.panTrabajo;
            // 
            // bnfArrastrar
            // 
            this.bnfArrastrar.Fixed = true;
            this.bnfArrastrar.Horizontal = true;
            this.bnfArrastrar.TargetControl = this;
            this.bnfArrastrar.Vertical = true;
            // 
            // panelMenu
            // 
            this.panelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMenu.BackgroundImage")));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnPiensaAjedrez);
            this.panelMenu.Controls.Add(this.btnColegios);
            this.panelMenu.Controls.Add(this.btnDesconectar);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.btnRegistrar);
            this.panelMenu.Controls.Add(this.btnMensualidades);
            this.panelMenu.GradientBottomLeft = System.Drawing.Color.DarkCyan;
            this.panelMenu.GradientBottomRight = System.Drawing.Color.DarkTurquoise;
            this.panelMenu.GradientTopLeft = System.Drawing.Color.DarkTurquoise;
            this.panelMenu.GradientTopRight = System.Drawing.Color.CadetBlue;
            this.panelMenu.Location = new System.Drawing.Point(0, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Quality = 10;
            this.panelMenu.Size = new System.Drawing.Size(1366, 49);
            this.panelMenu.TabIndex = 0;
            // 
            // btnPiensaAjedrez
            // 
            this.btnPiensaAjedrez.BackColor = System.Drawing.Color.Transparent;
            this.btnPiensaAjedrez.Image = global::PiensaAjedrez.Properties.Resources.botonPiensaAjedrez;
            this.btnPiensaAjedrez.Location = new System.Drawing.Point(-9, -25);
            this.btnPiensaAjedrez.Name = "btnPiensaAjedrez";
            this.btnPiensaAjedrez.Size = new System.Drawing.Size(96, 96);
            this.btnPiensaAjedrez.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPiensaAjedrez.TabIndex = 0;
            this.btnPiensaAjedrez.TabStop = false;
            this.btnPiensaAjedrez.Click += new System.EventHandler(this.btnPiensaAjedrez_Click);
            // 
            // btnColegios
            // 
            this.btnColegios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnColegios.BackColor = System.Drawing.Color.Transparent;
            this.btnColegios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColegios.BorderRadius = 0;
            this.btnColegios.ButtonText = "Colegios";
            this.btnColegios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColegios.DisabledColor = System.Drawing.Color.Gray;
            this.btnColegios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnColegios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnColegios.Iconimage")));
            this.btnColegios.Iconimage_right = null;
            this.btnColegios.Iconimage_right_Selected = null;
            this.btnColegios.Iconimage_Selected = null;
            this.btnColegios.IconMarginLeft = 0;
            this.btnColegios.IconMarginRight = 0;
            this.btnColegios.IconRightVisible = false;
            this.btnColegios.IconRightZoom = 0D;
            this.btnColegios.IconVisible = false;
            this.btnColegios.IconZoom = 90D;
            this.btnColegios.IsTab = true;
            this.btnColegios.Location = new System.Drawing.Point(632, 0);
            this.btnColegios.Name = "btnColegios";
            this.btnColegios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnColegios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnColegios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnColegios.selected = false;
            this.btnColegios.Size = new System.Drawing.Size(264, 50);
            this.btnColegios.TabIndex = 5;
            this.btnColegios.Text = "Colegios";
            this.btnColegios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnColegios.Textcolor = System.Drawing.Color.White;
            this.btnColegios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnColegios.Click += new System.EventHandler(this.btnColegios_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnDesconectar.BackColor = System.Drawing.Color.Transparent;
            this.btnDesconectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesconectar.BorderRadius = 0;
            this.btnDesconectar.ButtonText = "Salir";
            this.btnDesconectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDesconectar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDesconectar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDesconectar.Iconimage")));
            this.btnDesconectar.Iconimage_right = null;
            this.btnDesconectar.Iconimage_right_Selected = null;
            this.btnDesconectar.Iconimage_Selected = null;
            this.btnDesconectar.IconMarginLeft = 0;
            this.btnDesconectar.IconMarginRight = 0;
            this.btnDesconectar.IconRightVisible = false;
            this.btnDesconectar.IconRightZoom = 0D;
            this.btnDesconectar.IconVisible = false;
            this.btnDesconectar.IconZoom = 90D;
            this.btnDesconectar.IsTab = false;
            this.btnDesconectar.Location = new System.Drawing.Point(1206, 0);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDesconectar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnDesconectar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDesconectar.selected = false;
            this.btnDesconectar.Size = new System.Drawing.Size(160, 50);
            this.btnDesconectar.TabIndex = 4;
            this.btnDesconectar.Text = "Salir";
            this.btnDesconectar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDesconectar.Textcolor = System.Drawing.Color.White;
            this.btnDesconectar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnReportes.BackColor = System.Drawing.Color.Transparent;
            this.btnReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReportes.BorderRadius = 0;
            this.btnReportes.ButtonText = "Estadisticas";
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.DisabledColor = System.Drawing.Color.Gray;
            this.btnReportes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReportes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReportes.Iconimage")));
            this.btnReportes.Iconimage_right = null;
            this.btnReportes.Iconimage_right_Selected = null;
            this.btnReportes.Iconimage_Selected = null;
            this.btnReportes.IconMarginLeft = 0;
            this.btnReportes.IconMarginRight = 0;
            this.btnReportes.IconRightVisible = false;
            this.btnReportes.IconRightZoom = 0D;
            this.btnReportes.IconVisible = false;
            this.btnReportes.IconZoom = 90D;
            this.btnReportes.IsTab = true;
            this.btnReportes.Location = new System.Drawing.Point(895, 0);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnReportes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnReportes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReportes.selected = false;
            this.btnReportes.Size = new System.Drawing.Size(312, 50);
            this.btnReportes.TabIndex = 3;
            this.btnReportes.Text = "Estadisticas";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReportes.Textcolor = System.Drawing.Color.White;
            this.btnReportes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderRadius = 0;
            this.btnRegistrar.ButtonText = "Registrar alumnos";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegistrar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.Iconimage")));
            this.btnRegistrar.Iconimage_right = null;
            this.btnRegistrar.Iconimage_right_Selected = null;
            this.btnRegistrar.Iconimage_Selected = null;
            this.btnRegistrar.IconMarginLeft = 0;
            this.btnRegistrar.IconMarginRight = 0;
            this.btnRegistrar.IconRightVisible = false;
            this.btnRegistrar.IconRightZoom = 0D;
            this.btnRegistrar.IconVisible = false;
            this.btnRegistrar.IconZoom = 90D;
            this.btnRegistrar.IsTab = true;
            this.btnRegistrar.Location = new System.Drawing.Point(339, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Normalcolor = System.Drawing.Color.Transparent;
            this.btnRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegistrar.selected = false;
            this.btnRegistrar.Size = new System.Drawing.Size(294, 50);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar alumnos";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Textcolor = System.Drawing.Color.White;
            this.btnRegistrar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnMensualidades
            // 
            this.btnMensualidades.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnMensualidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnMensualidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMensualidades.BorderRadius = 0;
            this.btnMensualidades.ButtonText = "Registro de pago";
            this.btnMensualidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMensualidades.DisabledColor = System.Drawing.Color.Gray;
            this.btnMensualidades.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMensualidades.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMensualidades.Iconimage")));
            this.btnMensualidades.Iconimage_right = null;
            this.btnMensualidades.Iconimage_right_Selected = null;
            this.btnMensualidades.Iconimage_Selected = null;
            this.btnMensualidades.IconMarginLeft = 0;
            this.btnMensualidades.IconMarginRight = 0;
            this.btnMensualidades.IconRightVisible = false;
            this.btnMensualidades.IconRightZoom = 0D;
            this.btnMensualidades.IconVisible = false;
            this.btnMensualidades.IconZoom = 90D;
            this.btnMensualidades.IsTab = true;
            this.btnMensualidades.Location = new System.Drawing.Point(93, 0);
            this.btnMensualidades.Name = "btnMensualidades";
            this.btnMensualidades.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMensualidades.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnMensualidades.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMensualidades.selected = true;
            this.btnMensualidades.Size = new System.Drawing.Size(248, 50);
            this.btnMensualidades.TabIndex = 0;
            this.btnMensualidades.Text = "Registro de pago";
            this.btnMensualidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMensualidades.Textcolor = System.Drawing.Color.White;
            this.btnMensualidades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMensualidades.Click += new System.EventHandler(this.btnMensualidades_Click);
            // 
            // btnPiensaAjedrezEstetico
            // 
            this.btnPiensaAjedrezEstetico.BackColor = System.Drawing.Color.Transparent;
            this.btnPiensaAjedrezEstetico.Image = global::PiensaAjedrez.Properties.Resources.botonPiensaAjedrez;
            this.btnPiensaAjedrezEstetico.Location = new System.Drawing.Point(-9, 5);
            this.btnPiensaAjedrezEstetico.Name = "btnPiensaAjedrezEstetico";
            this.btnPiensaAjedrezEstetico.Size = new System.Drawing.Size(96, 96);
            this.btnPiensaAjedrezEstetico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPiensaAjedrezEstetico.TabIndex = 3;
            this.btnPiensaAjedrezEstetico.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.PiensaAjedrez);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panTrabajo);
            this.Controls.Add(this.btnPiensaAjedrezEstetico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnPiensaAjedrez)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPiensaAjedrezEstetico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse elpSinBordes;
        private Bunifu.Framework.UI.BunifuGradientPanel panelMenu;
        private System.Windows.Forms.Panel panTrabajo;
        private System.Windows.Forms.Label Cerrar;
        private System.Windows.Forms.Label PiensaAjedrez;
        private Bunifu.Framework.UI.BunifuFlatButton btnDesconectar;
        private Bunifu.Framework.UI.BunifuFlatButton btnReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegistrar;
        private Bunifu.Framework.UI.BunifuFlatButton btnMensualidades;
        private Bunifu.Framework.UI.BunifuElipse elpTrabajo;
        private Bunifu.Framework.UI.BunifuFlatButton btnColegios;
        private Bunifu.Framework.UI.BunifuDragControl bnfArrastrar;
        private System.Windows.Forms.PictureBox btnPiensaAjedrez;
        private System.Windows.Forms.PictureBox btnPiensaAjedrezEstetico;
    }
}

