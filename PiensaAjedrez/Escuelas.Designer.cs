﻿namespace PiensaAjedrez
{
    partial class Escuelas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escuelas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.btnAgregado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAgregarColegio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombreColegio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblNombreColegio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnCancelarCurso = new System.Windows.Forms.PictureBox();
            this.btnAgregadoCurso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblFinCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmFinCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblInicioCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmInicioCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnAgregarCurso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvEscuelas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dgvCursos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEliminarCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarCurso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.btnCancelar);
            this.bunifuCards1.Controls.Add(this.btnAgregado);
            this.bunifuCards1.Controls.Add(this.btnEscuela);
            this.bunifuCards1.Controls.Add(this.btnAgregarColegio);
            this.bunifuCards1.Controls.Add(this.lblColegios);
            this.bunifuCards1.Controls.Add(this.txtNombreColegio);
            this.bunifuCards1.Controls.Add(this.lblNombreColegio);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(25, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(631, 252);
            this.bunifuCards1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.InitialImage")));
            this.btnCancelar.Location = new System.Drawing.Point(386, 200);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(27, 27);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCancelar, "Cancelar edición");
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregado
            // 
            this.btnAgregado.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregado.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregado.BorderRadius = 0;
            this.btnAgregado.ButtonText = "bunifuFlatButton1";
            this.btnAgregado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregado.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregado.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregado.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregado.Iconimage")));
            this.btnAgregado.Iconimage_right = null;
            this.btnAgregado.Iconimage_right_Selected = null;
            this.btnAgregado.Iconimage_Selected = null;
            this.btnAgregado.IconMarginLeft = 0;
            this.btnAgregado.IconMarginRight = 0;
            this.btnAgregado.IconRightVisible = true;
            this.btnAgregado.IconRightZoom = 0D;
            this.btnAgregado.IconVisible = true;
            this.btnAgregado.IconZoom = 61D;
            this.btnAgregado.IsTab = false;
            this.btnAgregado.Location = new System.Drawing.Point(580, 205);
            this.btnAgregado.Name = "btnAgregado";
            this.btnAgregado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregado.selected = false;
            this.btnAgregado.Size = new System.Drawing.Size(25, 25);
            this.btnAgregado.TabIndex = 14;
            this.btnAgregado.Text = "bunifuFlatButton1";
            this.btnAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregado.Textcolor = System.Drawing.Color.White;
            this.btnAgregado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.Color.Transparent;
            this.btnEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuela.Image")));
            this.btnEscuela.ImageActive = null;
            this.btnEscuela.Location = new System.Drawing.Point(277, 60);
            this.btnEscuela.Name = "btnEscuela";
            this.btnEscuela.Size = new System.Drawing.Size(82, 65);
            this.btnEscuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEscuela.TabIndex = 5;
            this.btnEscuela.TabStop = false;
            this.btnEscuela.Zoom = 10;
            // 
            // btnAgregarColegio
            // 
            this.btnAgregarColegio.ActiveBorderThickness = 1;
            this.btnAgregarColegio.ActiveCornerRadius = 20;
            this.btnAgregarColegio.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnAgregarColegio.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregarColegio.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnAgregarColegio.BackColor = System.Drawing.Color.White;
            this.btnAgregarColegio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarColegio.BackgroundImage")));
            this.btnAgregarColegio.ButtonText = "Agregar";
            this.btnAgregarColegio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarColegio.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.btnAgregarColegio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarColegio.IdleBorderThickness = 1;
            this.btnAgregarColegio.IdleCornerRadius = 20;
            this.btnAgregarColegio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarColegio.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarColegio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarColegio.Location = new System.Drawing.Point(254, 195);
            this.btnAgregarColegio.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarColegio.Name = "btnAgregarColegio";
            this.btnAgregarColegio.Size = new System.Drawing.Size(124, 35);
            this.btnAgregarColegio.TabIndex = 4;
            this.btnAgregarColegio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarColegio.Click += new System.EventHandler(this.btnAgregarColegio_Click);
            // 
            // lblColegios
            // 
            this.lblColegios.AutoSize = true;
            this.lblColegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblColegios.ForeColor = System.Drawing.Color.Teal;
            this.lblColegios.Location = new System.Drawing.Point(15, 18);
            this.lblColegios.Name = "lblColegios";
            this.lblColegios.Size = new System.Drawing.Size(208, 25);
            this.lblColegios.TabIndex = 3;
            this.lblColegios.Text = "Registro de colegios";
            // 
            // txtNombreColegio
            // 
            this.txtNombreColegio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreColegio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtNombreColegio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreColegio.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombreColegio.HintText = "";
            this.txtNombreColegio.isPassword = false;
            this.txtNombreColegio.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtNombreColegio.LineIdleColor = System.Drawing.Color.Teal;
            this.txtNombreColegio.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtNombreColegio.LineThickness = 4;
            this.txtNombreColegio.Location = new System.Drawing.Point(116, 158);
            this.txtNombreColegio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreColegio.Name = "txtNombreColegio";
            this.txtNombreColegio.Size = new System.Drawing.Size(404, 27);
            this.txtNombreColegio.TabIndex = 2;
            this.txtNombreColegio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblNombreColegio
            // 
            this.lblNombreColegio.AutoSize = true;
            this.lblNombreColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombreColegio.Location = new System.Drawing.Point(278, 128);
            this.lblNombreColegio.Name = "lblNombreColegio";
            this.lblNombreColegio.Size = new System.Drawing.Size(81, 25);
            this.lblNombreColegio.TabIndex = 1;
            this.lblNombreColegio.Text = "Nombre";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.btnCancelarCurso);
            this.bunifuCards2.Controls.Add(this.btnAgregadoCurso);
            this.bunifuCards2.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards2.Controls.Add(this.lblFinCurso);
            this.bunifuCards2.Controls.Add(this.dtmFinCurso);
            this.bunifuCards2.Controls.Add(this.lblInicioCurso);
            this.bunifuCards2.Controls.Add(this.dtmInicioCurso);
            this.bunifuCards2.Controls.Add(this.btnAgregarCurso);
            this.bunifuCards2.Controls.Add(this.lblCurso);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(680, 17);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(631, 252);
            this.bunifuCards2.TabIndex = 5;
            // 
            // btnCancelarCurso
            // 
            this.btnCancelarCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarCurso.BackgroundImage")));
            this.btnCancelarCurso.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCancelarCurso.InitialImage")));
            this.btnCancelarCurso.Location = new System.Drawing.Point(392, 198);
            this.btnCancelarCurso.Name = "btnCancelarCurso";
            this.btnCancelarCurso.Size = new System.Drawing.Size(30, 32);
            this.btnCancelarCurso.TabIndex = 19;
            this.btnCancelarCurso.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCancelarCurso, "Cancelar edición");
            this.btnCancelarCurso.Visible = false;
            this.btnCancelarCurso.Click += new System.EventHandler(this.btnCancelarCurso_Click);
            // 
            // btnAgregadoCurso
            // 
            this.btnAgregadoCurso.Activecolor = System.Drawing.Color.Transparent;
            this.btnAgregadoCurso.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregadoCurso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregadoCurso.BorderRadius = 0;
            this.btnAgregadoCurso.ButtonText = "bunifuFlatButton1";
            this.btnAgregadoCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregadoCurso.DisabledColor = System.Drawing.Color.Gray;
            this.btnAgregadoCurso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAgregadoCurso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAgregadoCurso.Iconimage")));
            this.btnAgregadoCurso.Iconimage_right = null;
            this.btnAgregadoCurso.Iconimage_right_Selected = null;
            this.btnAgregadoCurso.Iconimage_Selected = null;
            this.btnAgregadoCurso.IconMarginLeft = 0;
            this.btnAgregadoCurso.IconMarginRight = 0;
            this.btnAgregadoCurso.IconRightVisible = true;
            this.btnAgregadoCurso.IconRightZoom = 0D;
            this.btnAgregadoCurso.IconVisible = true;
            this.btnAgregadoCurso.IconZoom = 61D;
            this.btnAgregadoCurso.IsTab = false;
            this.btnAgregadoCurso.Location = new System.Drawing.Point(584, 205);
            this.btnAgregadoCurso.Name = "btnAgregadoCurso";
            this.btnAgregadoCurso.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregadoCurso.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregadoCurso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregadoCurso.selected = false;
            this.btnAgregadoCurso.Size = new System.Drawing.Size(25, 25);
            this.btnAgregadoCurso.TabIndex = 14;
            this.btnAgregadoCurso.Text = "bunifuFlatButton1";
            this.btnAgregadoCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregadoCurso.Textcolor = System.Drawing.Color.White;
            this.btnAgregadoCurso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(277, 60);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 123);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 9;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // lblFinCurso
            // 
            this.lblFinCurso.AutoSize = true;
            this.lblFinCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblFinCurso.ForeColor = System.Drawing.Color.Black;
            this.lblFinCurso.Location = new System.Drawing.Point(443, 71);
            this.lblFinCurso.Name = "lblFinCurso";
            this.lblFinCurso.Size = new System.Drawing.Size(100, 50);
            this.lblFinCurso.TabIndex = 8;
            this.lblFinCurso.Text = "Fin\r\ndel curso";
            this.lblFinCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtmFinCurso
            // 
            this.dtmFinCurso.BackColor = System.Drawing.Color.Teal;
            this.dtmFinCurso.BorderRadius = 0;
            this.dtmFinCurso.ForeColor = System.Drawing.Color.White;
            this.dtmFinCurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFinCurso.FormatCustom = null;
            this.dtmFinCurso.Location = new System.Drawing.Point(405, 124);
            this.dtmFinCurso.Name = "dtmFinCurso";
            this.dtmFinCurso.Size = new System.Drawing.Size(169, 36);
            this.dtmFinCurso.TabIndex = 7;
            this.dtmFinCurso.Value = new System.DateTime(2019, 3, 5, 10, 54, 35, 360);
            // 
            // lblInicioCurso
            // 
            this.lblInicioCurso.AutoSize = true;
            this.lblInicioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblInicioCurso.ForeColor = System.Drawing.Color.Black;
            this.lblInicioCurso.Location = new System.Drawing.Point(87, 71);
            this.lblInicioCurso.Name = "lblInicioCurso";
            this.lblInicioCurso.Size = new System.Drawing.Size(100, 50);
            this.lblInicioCurso.TabIndex = 6;
            this.lblInicioCurso.Text = "Inicio\r\ndel curso\r\n";
            this.lblInicioCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtmInicioCurso
            // 
            this.dtmInicioCurso.BackColor = System.Drawing.Color.Teal;
            this.dtmInicioCurso.BorderRadius = 0;
            this.dtmInicioCurso.ForeColor = System.Drawing.Color.White;
            this.dtmInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInicioCurso.FormatCustom = null;
            this.dtmInicioCurso.Location = new System.Drawing.Point(54, 124);
            this.dtmInicioCurso.Name = "dtmInicioCurso";
            this.dtmInicioCurso.Size = new System.Drawing.Size(169, 36);
            this.dtmInicioCurso.TabIndex = 5;
            this.dtmInicioCurso.Value = new System.DateTime(2019, 3, 5, 0, 0, 0, 0);
            // 
            // btnAgregarCurso
            // 
            this.btnAgregarCurso.ActiveBorderThickness = 1;
            this.btnAgregarCurso.ActiveCornerRadius = 20;
            this.btnAgregarCurso.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnAgregarCurso.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregarCurso.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnAgregarCurso.BackColor = System.Drawing.Color.White;
            this.btnAgregarCurso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregarCurso.BackgroundImage")));
            this.btnAgregarCurso.ButtonText = "Agregar curso";
            this.btnAgregarCurso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCurso.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarCurso.IdleBorderThickness = 1;
            this.btnAgregarCurso.IdleCornerRadius = 20;
            this.btnAgregarCurso.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarCurso.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarCurso.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarCurso.Location = new System.Drawing.Point(245, 195);
            this.btnAgregarCurso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(140, 35);
            this.btnAgregarCurso.TabIndex = 4;
            this.btnAgregarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregarCurso.Click += new System.EventHandler(this.btnAgregarCurso_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCurso.ForeColor = System.Drawing.Color.Teal;
            this.lblCurso.Location = new System.Drawing.Point(23, 18);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(80, 25);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Cursos";
            // 
            // dgvEscuelas
            // 
            this.dgvEscuelas.AllowUserToAddRows = false;
            this.dgvEscuelas.AllowUserToDeleteRows = false;
            this.dgvEscuelas.AllowUserToResizeColumns = false;
            this.dgvEscuelas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEscuelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEscuelas.BackgroundColor = System.Drawing.Color.White;
            this.dgvEscuelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEscuelas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvEscuelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscuelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEscuelas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEscuelas.DoubleBuffered = true;
            this.dgvEscuelas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEscuelas.EnableHeadersVisualStyles = false;
            this.dgvEscuelas.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvEscuelas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvEscuelas.Location = new System.Drawing.Point(25, 302);
            this.dgvEscuelas.Name = "dgvEscuelas";
            this.dgvEscuelas.ReadOnly = true;
            this.dgvEscuelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEscuelas.RowHeadersVisible = false;
            this.dgvEscuelas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvEscuelas.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEscuelas.RowTemplate.Height = 25;
            this.dgvEscuelas.RowTemplate.ReadOnly = true;
            this.dgvEscuelas.Size = new System.Drawing.Size(631, 336);
            this.dgvEscuelas.TabIndex = 8;
            this.dgvEscuelas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEscuelas_CellClick);
            // 
            // dgvCursos
            // 
            this.dgvCursos.AllowUserToAddRows = false;
            this.dgvCursos.AllowUserToDeleteRows = false;
            this.dgvCursos.AllowUserToResizeColumns = false;
            this.dgvCursos.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCursos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCursos.BackgroundColor = System.Drawing.Color.White;
            this.dgvCursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCursos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCursos.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCursos.DoubleBuffered = true;
            this.dgvCursos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCursos.EnableHeadersVisualStyles = false;
            this.dgvCursos.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvCursos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCursos.Location = new System.Drawing.Point(680, 302);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.ReadOnly = true;
            this.dgvCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCursos.RowHeadersVisible = false;
            this.dgvCursos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvCursos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCursos.RowTemplate.Height = 25;
            this.dgvCursos.RowTemplate.ReadOnly = true;
            this.dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCursos.Size = new System.Drawing.Size(631, 336);
            this.dgvCursos.TabIndex = 9;
            this.dgvCursos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCursos_CellClick);
            this.dgvCursos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCursos_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEliminarCurso});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 26);
            // 
            // tsEliminarCurso
            // 
            this.tsEliminarCurso.Name = "tsEliminarCurso";
            this.tsEliminarCurso.Size = new System.Drawing.Size(149, 22);
            this.tsEliminarCurso.Text = "Eliminar curso";
            this.tsEliminarCurso.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 250;
            this.toolTip1.ReshowDelay = 100;
            // 
            // Escuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.dgvEscuelas);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Escuelas";
            this.Size = new System.Drawing.Size(1342, 670);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelarCurso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombreColegio;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombreColegio;
        private Bunifu.Framework.UI.BunifuCustomLabel lblColegios;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarColegio;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFinCurso;
        private Bunifu.Framework.UI.BunifuDatepicker dtmFinCurso;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInicioCurso;
        private Bunifu.Framework.UI.BunifuDatepicker dtmInicioCurso;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregarCurso;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCurso;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEscuelas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCursos;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregadoCurso;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnCancelarCurso;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsEliminarCurso;
    }
}
