﻿namespace PiensaAjedrez
{
    partial class RegistroAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlumnos));
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsEliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.txtTutor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblTutor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnAgregado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblActivo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblnumerocontrol = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNocontrol = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtFechaNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblCorreo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTelefono = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFechaNacimiento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkEscuela = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkFechaNacimiento = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkTelefono = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkCorreo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtFiltonombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblFiltroActivo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFiltroActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblFiltroEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboFiltroEscuela = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtFiltroAño = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.lblfiltrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cancelartt = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.White;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.DoubleBuffered = true;
            this.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(27, 297);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnos.RowHeadersVisible = false;
            this.dgvAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnos.RowTemplate.Height = 25;
            this.dgvAlumnos.RowTemplate.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1288, 347);
            this.dgvAlumnos.TabIndex = 7;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            this.dgvAlumnos.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumnos_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsEliminarAlumno});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(162, 24);
            // 
            // tsEliminarAlumno
            // 
            this.tsEliminarAlumno.Name = "tsEliminarAlumno";
            this.tsEliminarAlumno.Padding = new System.Windows.Forms.Padding(0);
            this.tsEliminarAlumno.Size = new System.Drawing.Size(161, 20);
            this.tsEliminarAlumno.Text = "Eliminar alumno";
            this.tsEliminarAlumno.Click += new System.EventHandler(this.tsEliminarAlumno_Click);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.btnLimpiar);
            this.bunifuCards1.Controls.Add(this.btnCancelar);
            this.bunifuCards1.Controls.Add(this.txtTutor);
            this.bunifuCards1.Controls.Add(this.lblTutor);
            this.bunifuCards1.Controls.Add(this.cbEscuelas);
            this.bunifuCards1.Controls.Add(this.btnAgregado);
            this.bunifuCards1.Controls.Add(this.lblActivo);
            this.bunifuCards1.Controls.Add(this.chkActivo);
            this.bunifuCards1.Controls.Add(this.lblnumerocontrol);
            this.bunifuCards1.Controls.Add(this.lblNocontrol);
            this.bunifuCards1.Controls.Add(this.btnAgregar);
            this.bunifuCards1.Controls.Add(this.dtFechaNacimiento);
            this.bunifuCards1.Controls.Add(this.txtCorreo);
            this.bunifuCards1.Controls.Add(this.txtTelefono);
            this.bunifuCards1.Controls.Add(this.txtNombre);
            this.bunifuCards1.Controls.Add(this.lblCorreo);
            this.bunifuCards1.Controls.Add(this.lblTelefono);
            this.bunifuCards1.Controls.Add(this.lblFechaNacimiento);
            this.bunifuCards1.Controls.Add(this.lblEscuela);
            this.bunifuCards1.Controls.Add(this.lblNombre);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(27, 24);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(923, 257);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.InitialImage")));
            this.btnLimpiar.Location = new System.Drawing.Point(874, 21);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(30, 32);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.TabStop = false;
            this.Cancelartt.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.InitialImage")));
            this.btnCancelar.Location = new System.Drawing.Point(874, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(30, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.TabStop = false;
            this.Cancelartt.SetToolTip(this.btnCancelar, "Cancelar edición");
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtTutor
            // 
            this.txtTutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTutor.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtTutor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTutor.HintForeColor = System.Drawing.Color.Empty;
            this.txtTutor.HintText = "";
            this.txtTutor.isPassword = false;
            this.txtTutor.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtTutor.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTutor.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtTutor.LineThickness = 4;
            this.txtTutor.Location = new System.Drawing.Point(102, 150);
            this.txtTutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(385, 33);
            this.txtTutor.TabIndex = 15;
            this.txtTutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(14, 158);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(58, 25);
            this.lblTutor.TabIndex = 16;
            this.lblTutor.Text = "Tutor";
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(105, 102);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.Teal;
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(382, 35);
            this.cbEscuelas.TabIndex = 14;
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
            this.btnAgregado.Location = new System.Drawing.Point(879, 212);
            this.btnAgregado.Name = "btnAgregado";
            this.btnAgregado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregado.selected = false;
            this.btnAgregado.Size = new System.Drawing.Size(25, 25);
            this.btnAgregado.TabIndex = 13;
            this.btnAgregado.Text = "bunifuFlatButton1";
            this.btnAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregado.Textcolor = System.Drawing.Color.White;
            this.btnAgregado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.Color.Black;
            this.lblActivo.Location = new System.Drawing.Point(533, 212);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(66, 25);
            this.lblActivo.TabIndex = 10;
            this.lblActivo.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.SkyBlue;
            this.chkActivo.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkActivo.Checked = false;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(507, 217);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(20, 20);
            this.chkActivo.TabIndex = 9;
            // 
            // lblnumerocontrol
            // 
            this.lblnumerocontrol.AutoSize = true;
            this.lblnumerocontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerocontrol.ForeColor = System.Drawing.Color.Teal;
            this.lblnumerocontrol.Location = new System.Drawing.Point(97, 13);
            this.lblnumerocontrol.Name = "lblnumerocontrol";
            this.lblnumerocontrol.Size = new System.Drawing.Size(74, 25);
            this.lblnumerocontrol.TabIndex = 7;
            this.lblnumerocontrol.Text = "No.ctrl";
            // 
            // lblNocontrol
            // 
            this.lblNocontrol.AutoSize = true;
            this.lblNocontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNocontrol.ForeColor = System.Drawing.Color.Teal;
            this.lblNocontrol.Location = new System.Drawing.Point(14, 13);
            this.lblNocontrol.Name = "lblNocontrol";
            this.lblNocontrol.Size = new System.Drawing.Size(74, 25);
            this.lblNocontrol.TabIndex = 6;
            this.lblNocontrol.Text = "No.ctrl";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregar.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregar.Location = new System.Drawing.Point(686, 202);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.dtFechaNacimiento.BorderRadius = 0;
            this.dtFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.FormatCustom = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(214, 198);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(167, 36);
            this.dtFechaNacimiento.TabIndex = 4;
            this.dtFechaNacimiento.Value = new System.DateTime(2010, 9, 2, 0, 0, 0, 0);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.HintText = "";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtCorreo.LineIdleColor = System.Drawing.Color.Teal;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtCorreo.LineThickness = 4;
            this.txtCorreo.Location = new System.Drawing.Point(606, 104);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(265, 33);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "ejemplo@hotmail.com";
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            this.txtCorreo.MouseEnter += new System.EventHandler(this.txtCorreo_MouseEnter);
            this.txtCorreo.MouseLeave += new System.EventHandler(this.txtCorreo_MouseLeave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtTelefono.LineThickness = 4;
            this.txtTelefono.Location = new System.Drawing.Point(606, 50);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(204, 33);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Teal;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(102, 50);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(385, 33);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(527, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(72, 25);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(510, 58);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(89, 25);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(15, 209);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(193, 25);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuela.ForeColor = System.Drawing.Color.Black;
            this.lblEscuela.Location = new System.Drawing.Point(14, 110);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(82, 25);
            this.lblEscuela.TabIndex = 2;
            this.lblEscuela.Text = "Escuela";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(14, 58);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // chkNombre
            // 
            this.chkNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.chkNombre.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkNombre.Checked = false;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(12, 63);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(20, 20);
            this.chkNombre.TabIndex = 8;
            this.chkNombre.OnChange += new System.EventHandler(this.chkNombre_OnChange);
            // 
            // chkEscuela
            // 
            this.chkEscuela.BackColor = System.Drawing.Color.SkyBlue;
            this.chkEscuela.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkEscuela.Checked = false;
            this.chkEscuela.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkEscuela.ForeColor = System.Drawing.Color.White;
            this.chkEscuela.Location = new System.Drawing.Point(12, 100);
            this.chkEscuela.Name = "chkEscuela";
            this.chkEscuela.Size = new System.Drawing.Size(20, 20);
            this.chkEscuela.TabIndex = 9;
            this.chkEscuela.OnChange += new System.EventHandler(this.chkEscuela_OnChange);
            // 
            // chkFechaNacimiento
            // 
            this.chkFechaNacimiento.BackColor = System.Drawing.Color.SkyBlue;
            this.chkFechaNacimiento.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkFechaNacimiento.Checked = false;
            this.chkFechaNacimiento.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.chkFechaNacimiento.Location = new System.Drawing.Point(12, 149);
            this.chkFechaNacimiento.Name = "chkFechaNacimiento";
            this.chkFechaNacimiento.Size = new System.Drawing.Size(20, 20);
            this.chkFechaNacimiento.TabIndex = 10;
            this.chkFechaNacimiento.OnChange += new System.EventHandler(this.chkFechaNacimiento_OnChange);
            // 
            // chkTelefono
            // 
            this.chkTelefono.BackColor = System.Drawing.Color.SkyBlue;
            this.chkTelefono.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkTelefono.Checked = false;
            this.chkTelefono.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkTelefono.ForeColor = System.Drawing.Color.White;
            this.chkTelefono.Location = new System.Drawing.Point(178, 149);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(20, 20);
            this.chkTelefono.TabIndex = 11;
            this.chkTelefono.OnChange += new System.EventHandler(this.chkTelefono_OnChange);
            // 
            // chkCorreo
            // 
            this.chkCorreo.BackColor = System.Drawing.Color.SkyBlue;
            this.chkCorreo.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkCorreo.Checked = false;
            this.chkCorreo.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkCorreo.ForeColor = System.Drawing.Color.White;
            this.chkCorreo.Location = new System.Drawing.Point(12, 190);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(20, 20);
            this.chkCorreo.TabIndex = 12;
            this.chkCorreo.OnChange += new System.EventHandler(this.chkCorreo_OnChange);
            // 
            // txtFiltonombre
            // 
            this.txtFiltonombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltonombre.Enabled = false;
            this.txtFiltonombre.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltonombre.ForeColor = System.Drawing.Color.Black;
            this.txtFiltonombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltonombre.HintText = "";
            this.txtFiltonombre.isPassword = false;
            this.txtFiltonombre.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltonombre.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltonombre.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltonombre.LineThickness = 3;
            this.txtFiltonombre.Location = new System.Drawing.Point(38, 57);
            this.txtFiltonombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltonombre.Name = "txtFiltonombre";
            this.txtFiltonombre.Size = new System.Drawing.Size(279, 27);
            this.txtFiltonombre.TabIndex = 6;
            this.txtFiltonombre.Text = "Nombre";
            this.txtFiltonombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltonombre.OnValueChanged += new System.EventHandler(this.txtFiltonombre_OnValueChanged);
            this.txtFiltonombre.Enter += new System.EventHandler(this.txtFiltonombre_Enter);
            this.txtFiltonombre.Leave += new System.EventHandler(this.txtFiltonombre_Leave);
            this.txtFiltonombre.MouseEnter += new System.EventHandler(this.txtFiltonombre_MouseEnter);
            this.txtFiltonombre.MouseLeave += new System.EventHandler(this.txtFiltonombre_MouseLeave);
            // 
            // txtFiltroTelefono
            // 
            this.txtFiltroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroTelefono.Enabled = false;
            this.txtFiltroTelefono.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroTelefono.HintText = "";
            this.txtFiltroTelefono.isPassword = false;
            this.txtFiltroTelefono.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroTelefono.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroTelefono.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroTelefono.LineThickness = 3;
            this.txtFiltroTelefono.Location = new System.Drawing.Point(204, 142);
            this.txtFiltroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroTelefono.Name = "txtFiltroTelefono";
            this.txtFiltroTelefono.Size = new System.Drawing.Size(113, 27);
            this.txtFiltroTelefono.TabIndex = 15;
            this.txtFiltroTelefono.Text = "Teléfono";
            this.txtFiltroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroTelefono.OnValueChanged += new System.EventHandler(this.txtFiltroTelefono_OnValueChanged);
            this.txtFiltroTelefono.Enter += new System.EventHandler(this.txtFiltroTelefono_Enter);
            this.txtFiltroTelefono.Leave += new System.EventHandler(this.txtFiltroTelefono_Leave);
            this.txtFiltroTelefono.MouseEnter += new System.EventHandler(this.txtFiltroTelefono_MouseEnter);
            this.txtFiltroTelefono.MouseLeave += new System.EventHandler(this.txtFiltroTelefono_MouseLeave);
            // 
            // txtFiltroCorreo
            // 
            this.txtFiltroCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroCorreo.Enabled = false;
            this.txtFiltroCorreo.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroCorreo.HintText = "";
            this.txtFiltroCorreo.isPassword = false;
            this.txtFiltroCorreo.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroCorreo.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroCorreo.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroCorreo.LineThickness = 3;
            this.txtFiltroCorreo.Location = new System.Drawing.Point(38, 183);
            this.txtFiltroCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroCorreo.Name = "txtFiltroCorreo";
            this.txtFiltroCorreo.Size = new System.Drawing.Size(279, 27);
            this.txtFiltroCorreo.TabIndex = 16;
            this.txtFiltroCorreo.Text = "Correo";
            this.txtFiltroCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroCorreo.OnValueChanged += new System.EventHandler(this.txtFiltroCorreo_OnValueChanged);
            this.txtFiltroCorreo.Enter += new System.EventHandler(this.txtFiltroCorreo_Enter);
            this.txtFiltroCorreo.Leave += new System.EventHandler(this.txtFiltroCorreo_Leave);
            this.txtFiltroCorreo.MouseEnter += new System.EventHandler(this.txtFiltroCorreo_MouseEnter);
            this.txtFiltroCorreo.MouseLeave += new System.EventHandler(this.txtFiltroCorreo_MouseLeave);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.lblFiltroActivo);
            this.bunifuCards2.Controls.Add(this.chkFiltroActivo);
            this.bunifuCards2.Controls.Add(this.lblFiltroEscuela);
            this.bunifuCards2.Controls.Add(this.cboFiltroEscuela);
            this.bunifuCards2.Controls.Add(this.txtFiltroAño);
            this.bunifuCards2.Controls.Add(this.cbMes);
            this.bunifuCards2.Controls.Add(this.cbDia);
            this.bunifuCards2.Controls.Add(this.lblfiltrar);
            this.bunifuCards2.Controls.Add(this.imgFiltro);
            this.bunifuCards2.Controls.Add(this.chkCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroTelefono);
            this.bunifuCards2.Controls.Add(this.chkTelefono);
            this.bunifuCards2.Controls.Add(this.chkFechaNacimiento);
            this.bunifuCards2.Controls.Add(this.txtFiltonombre);
            this.bunifuCards2.Controls.Add(this.chkNombre);
            this.bunifuCards2.Controls.Add(this.chkEscuela);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(980, 24);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(335, 257);
            this.bunifuCards2.TabIndex = 17;
            // 
            // lblFiltroActivo
            // 
            this.lblFiltroActivo.AutoSize = true;
            this.lblFiltroActivo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFiltroActivo.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroActivo.Location = new System.Drawing.Point(37, 222);
            this.lblFiltroActivo.Name = "lblFiltroActivo";
            this.lblFiltroActivo.Size = new System.Drawing.Size(171, 21);
            this.lblFiltroActivo.TabIndex = 23;
            this.lblFiltroActivo.Text = "Sólo alumnos activos";
            // 
            // chkFiltroActivo
            // 
            this.chkFiltroActivo.BackColor = System.Drawing.Color.SkyBlue;
            this.chkFiltroActivo.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkFiltroActivo.Checked = false;
            this.chkFiltroActivo.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkFiltroActivo.ForeColor = System.Drawing.Color.White;
            this.chkFiltroActivo.Location = new System.Drawing.Point(12, 223);
            this.chkFiltroActivo.Name = "chkFiltroActivo";
            this.chkFiltroActivo.Size = new System.Drawing.Size(20, 20);
            this.chkFiltroActivo.TabIndex = 15;
            this.chkFiltroActivo.OnChange += new System.EventHandler(this.chkFiltroActivo_OnChange);
            // 
            // lblFiltroEscuela
            // 
            this.lblFiltroEscuela.AutoSize = true;
            this.lblFiltroEscuela.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFiltroEscuela.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroEscuela.Location = new System.Drawing.Point(47, 100);
            this.lblFiltroEscuela.Name = "lblFiltroEscuela";
            this.lblFiltroEscuela.Size = new System.Drawing.Size(69, 21);
            this.lblFiltroEscuela.TabIndex = 15;
            this.lblFiltroEscuela.Text = "Escuela";
            // 
            // cboFiltroEscuela
            // 
            this.cboFiltroEscuela.BackColor = System.Drawing.Color.Transparent;
            this.cboFiltroEscuela.BorderRadius = 3;
            this.cboFiltroEscuela.DisabledColor = System.Drawing.Color.SkyBlue;
            this.cboFiltroEscuela.Enabled = false;
            this.cboFiltroEscuela.ForeColor = System.Drawing.Color.White;
            this.cboFiltroEscuela.Items = new string[0];
            this.cboFiltroEscuela.Location = new System.Drawing.Point(120, 94);
            this.cboFiltroEscuela.Name = "cboFiltroEscuela";
            this.cboFiltroEscuela.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cboFiltroEscuela.onHoverColor = System.Drawing.Color.Teal;
            this.cboFiltroEscuela.selectedIndex = -1;
            this.cboFiltroEscuela.Size = new System.Drawing.Size(191, 35);
            this.cboFiltroEscuela.TabIndex = 22;
            this.cboFiltroEscuela.onItemSelected += new System.EventHandler(this.cboFiltroEscuela_OnItemSelected);
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroAño.Enabled = false;
            this.txtFiltroAño.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAño.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroAño.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroAño.HintText = "";
            this.txtFiltroAño.isPassword = false;
            this.txtFiltroAño.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroAño.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroAño.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroAño.LineThickness = 3;
            this.txtFiltroAño.Location = new System.Drawing.Point(126, 142);
            this.txtFiltroAño.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(40, 27);
            this.txtFiltroAño.TabIndex = 21;
            this.txtFiltroAño.Text = "Año";
            this.txtFiltroAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroAño.OnValueChanged += new System.EventHandler(this.txtFiltroAño_OnValueChanged);
            this.txtFiltroAño.Enter += new System.EventHandler(this.txtFiltroAño_Enter);
            this.txtFiltroAño.Leave += new System.EventHandler(this.txtFiltroAño_Leave);
            this.txtFiltroAño.MouseEnter += new System.EventHandler(this.txtFiltroAño_MouseEnter);
            this.txtFiltroAño.MouseLeave += new System.EventHandler(this.txtFiltroAño_MouseLeave);
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMes.Enabled = false;
            this.cbMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMes.ForeColor = System.Drawing.Color.White;
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbMes.Location = new System.Drawing.Point(83, 147);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(36, 25);
            this.cbMes.TabIndex = 20;
            this.cbMes.TextChanged += new System.EventHandler(this.cbMes_TextChanged);
            // 
            // cbDia
            // 
            this.cbDia.BackColor = System.Drawing.Color.LightSeaGreen;
            this.cbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDia.Enabled = false;
            this.cbDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDia.ForeColor = System.Drawing.Color.White;
            this.cbDia.FormattingEnabled = true;
            this.cbDia.IntegralHeight = false;
            this.cbDia.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDia.Location = new System.Drawing.Point(42, 146);
            this.cbDia.MaxDropDownItems = 12;
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(37, 25);
            this.cbDia.TabIndex = 19;
            this.cbDia.TextChanged += new System.EventHandler(this.cbDia_TextChanged);
            // 
            // lblfiltrar
            // 
            this.lblfiltrar.AutoSize = true;
            this.lblfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblfiltrar.Location = new System.Drawing.Point(49, 22);
            this.lblfiltrar.Name = "lblfiltrar";
            this.lblfiltrar.Size = new System.Drawing.Size(113, 25);
            this.lblfiltrar.TabIndex = 18;
            this.lblfiltrar.Text = "Filtrar por... ";
            // 
            // imgFiltro
            // 
            this.imgFiltro.BackColor = System.Drawing.Color.Transparent;
            this.imgFiltro.Image = ((System.Drawing.Image)(resources.GetObject("imgFiltro.Image")));
            this.imgFiltro.ImageActive = ((System.Drawing.Image)(resources.GetObject("imgFiltro.ImageActive")));
            this.imgFiltro.Location = new System.Drawing.Point(12, 17);
            this.imgFiltro.Name = "imgFiltro";
            this.imgFiltro.Size = new System.Drawing.Size(31, 36);
            this.imgFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiltro.TabIndex = 17;
            this.imgFiltro.TabStop = false;
            this.imgFiltro.Zoom = 10;
            // 
            // Cancelartt
            // 
            this.Cancelartt.AutomaticDelay = 0;
            this.Cancelartt.AutoPopDelay = 5000;
            this.Cancelartt.InitialDelay = 250;
            this.Cancelartt.ReshowDelay = 100;
            // 
            // RegistroAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.bunifuCards2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegistroAlumnos";
            this.Size = new System.Drawing.Size(1342, 670);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCorreo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefono;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCheckbox chkNombre;
        private Bunifu.Framework.UI.BunifuCheckbox chkEscuela;
        private Bunifu.Framework.UI.BunifuCheckbox chkFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCheckbox chkTelefono;
        private Bunifu.Framework.UI.BunifuCheckbox chkCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltonombre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroCorreo;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton imgFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfiltrar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnumerocontrol;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNocontrol;
        private Bunifu.Framework.UI.BunifuCustomLabel lblActivo;
        private Bunifu.Framework.UI.BunifuCheckbox chkActivo;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregado;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ComboBox cbMes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroAño;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltroEscuela;
        private Bunifu.Framework.UI.BunifuDropdown cboFiltroEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltroActivo;
        private Bunifu.Framework.UI.BunifuCheckbox chkFiltroActivo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTutor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTutor;
        private System.Windows.Forms.ToolTip Cancelartt;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsEliminarAlumno;
    }
}
