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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAlumnos));
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtFechaNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEscuela = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.txtFiltoescuela = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroFechaNacimiento = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroTelefono = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroCorreo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblfiltrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.bunifuCards1.SuspendLayout();
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
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.DoubleBuffered = true;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(27, 297);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvAlumnos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAlumnos.Size = new System.Drawing.Size(1288, 347);
            this.dgvAlumnos.TabIndex = 7;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.btnAgregar);
            this.bunifuCards1.Controls.Add(this.dtFechaNacimiento);
            this.bunifuCards1.Controls.Add(this.txtCorreo);
            this.bunifuCards1.Controls.Add(this.txtTelefono);
            this.bunifuCards1.Controls.Add(this.txtEscuela);
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
            this.bunifuCards1.Size = new System.Drawing.Size(923, 245);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
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
            this.btnAgregar.Location = new System.Drawing.Point(708, 187);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(181, 41);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.dtFechaNacimiento.BorderRadius = 0;
            this.dtFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtFechaNacimiento.FormatCustom = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(20, 193);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(302, 36);
            this.dtFechaNacimiento.TabIndex = 4;
            this.dtFechaNacimiento.Value = new System.DateTime(2019, 2, 25, 17, 51, 30, 840);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.txtCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtCorreo.HintText = "";
            this.txtCorreo.isPassword = false;
            this.txtCorreo.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtCorreo.LineIdleColor = System.Drawing.Color.Teal;
            this.txtCorreo.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtCorreo.LineThickness = 4;
            this.txtCorreo.Location = new System.Drawing.Point(607, 97);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(282, 33);
            this.txtCorreo.TabIndex = 3;
            this.txtCorreo.Text = "ejemplo@hotmail.com";
            this.txtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCorreo.Click += new System.EventHandler(this.txtCorreo_Click_1);
            this.txtCorreo.Enter += new System.EventHandler(this.txtCorreo_Enter);
            this.txtCorreo.Leave += new System.EventHandler(this.txtCorreo_Leave);
            this.txtCorreo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCorreo_MouseClick);
            this.txtCorreo.MouseEnter += new System.EventHandler(this.txtCorreo_MouseEnter);
            this.txtCorreo.MouseLeave += new System.EventHandler(this.txtCorreo_MouseLeave);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefono.HintText = "";
            this.txtTelefono.isPassword = false;
            this.txtTelefono.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtTelefono.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTelefono.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtTelefono.LineThickness = 4;
            this.txtTelefono.Location = new System.Drawing.Point(607, 23);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(222, 33);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefono.OnValueChanged += new System.EventHandler(this.txtTelefono_OnValueChanged);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // txtEscuela
            // 
            this.txtEscuela.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEscuela.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEscuela.HintForeColor = System.Drawing.Color.Empty;
            this.txtEscuela.HintText = "";
            this.txtEscuela.isPassword = false;
            this.txtEscuela.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtEscuela.LineIdleColor = System.Drawing.Color.Teal;
            this.txtEscuela.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtEscuela.LineThickness = 4;
            this.txtEscuela.Location = new System.Drawing.Point(103, 97);
            this.txtEscuela.Margin = new System.Windows.Forms.Padding(4);
            this.txtEscuela.Name = "txtEscuela";
            this.txtEscuela.Size = new System.Drawing.Size(385, 33);
            this.txtEscuela.TabIndex = 1;
            this.txtEscuela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Teal;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtNombre.LineThickness = 4;
            this.txtNombre.Location = new System.Drawing.Point(103, 23);
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
            this.lblCorreo.Location = new System.Drawing.Point(528, 105);
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
            this.lblTelefono.Location = new System.Drawing.Point(511, 31);
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
            this.lblFechaNacimiento.Location = new System.Drawing.Point(15, 165);
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
            this.lblEscuela.Location = new System.Drawing.Point(14, 105);
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
            this.lblNombre.Location = new System.Drawing.Point(15, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(81, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // chkNombre
            // 
            this.chkNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkNombre.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkNombre.Checked = false;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(20, 67);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(20, 20);
            this.chkNombre.TabIndex = 8;
            // 
            // chkEscuela
            // 
            this.chkEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkEscuela.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkEscuela.Checked = false;
            this.chkEscuela.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkEscuela.ForeColor = System.Drawing.Color.White;
            this.chkEscuela.Location = new System.Drawing.Point(20, 118);
            this.chkEscuela.Name = "chkEscuela";
            this.chkEscuela.Size = new System.Drawing.Size(20, 20);
            this.chkEscuela.TabIndex = 9;
            // 
            // chkFechaNacimiento
            // 
            this.chkFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkFechaNacimiento.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkFechaNacimiento.Checked = false;
            this.chkFechaNacimiento.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.chkFechaNacimiento.Location = new System.Drawing.Point(20, 167);
            this.chkFechaNacimiento.Name = "chkFechaNacimiento";
            this.chkFechaNacimiento.Size = new System.Drawing.Size(20, 20);
            this.chkFechaNacimiento.TabIndex = 10;
            // 
            // chkTelefono
            // 
            this.chkTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkTelefono.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkTelefono.Checked = false;
            this.chkTelefono.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkTelefono.ForeColor = System.Drawing.Color.White;
            this.chkTelefono.Location = new System.Drawing.Point(172, 167);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(20, 20);
            this.chkTelefono.TabIndex = 11;
            // 
            // chkCorreo
            // 
            this.chkCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.chkCorreo.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkCorreo.Checked = false;
            this.chkCorreo.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkCorreo.ForeColor = System.Drawing.Color.White;
            this.chkCorreo.Location = new System.Drawing.Point(20, 208);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(20, 20);
            this.chkCorreo.TabIndex = 12;
            // 
            // txtFiltonombre
            // 
            this.txtFiltonombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltonombre.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltonombre.ForeColor = System.Drawing.Color.Black;
            this.txtFiltonombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltonombre.HintText = "";
            this.txtFiltonombre.isPassword = false;
            this.txtFiltonombre.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltonombre.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltonombre.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltonombre.LineThickness = 3;
            this.txtFiltonombre.Location = new System.Drawing.Point(46, 60);
            this.txtFiltonombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltonombre.Name = "txtFiltonombre";
            this.txtFiltonombre.Size = new System.Drawing.Size(266, 27);
            this.txtFiltonombre.TabIndex = 6;
            this.txtFiltonombre.Text = "Nombre";
            this.txtFiltonombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltoescuela
            // 
            this.txtFiltoescuela.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltoescuela.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltoescuela.ForeColor = System.Drawing.Color.Black;
            this.txtFiltoescuela.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltoescuela.HintText = "";
            this.txtFiltoescuela.isPassword = false;
            this.txtFiltoescuela.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltoescuela.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltoescuela.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltoescuela.LineThickness = 3;
            this.txtFiltoescuela.Location = new System.Drawing.Point(46, 106);
            this.txtFiltoescuela.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltoescuela.Name = "txtFiltoescuela";
            this.txtFiltoescuela.Size = new System.Drawing.Size(265, 32);
            this.txtFiltoescuela.TabIndex = 13;
            this.txtFiltoescuela.Text = "Escuela";
            this.txtFiltoescuela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltroFechaNacimiento
            // 
            this.txtFiltroFechaNacimiento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroFechaNacimiento.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroFechaNacimiento.HintText = "";
            this.txtFiltroFechaNacimiento.isPassword = false;
            this.txtFiltroFechaNacimiento.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroFechaNacimiento.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroFechaNacimiento.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroFechaNacimiento.LineThickness = 3;
            this.txtFiltroFechaNacimiento.Location = new System.Drawing.Point(46, 160);
            this.txtFiltroFechaNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroFechaNacimiento.Name = "txtFiltroFechaNacimiento";
            this.txtFiltroFechaNacimiento.Size = new System.Drawing.Size(106, 27);
            this.txtFiltroFechaNacimiento.TabIndex = 14;
            this.txtFiltroFechaNacimiento.Text = "dd/mm/aa";
            this.txtFiltroFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltroTelefono
            // 
            this.txtFiltroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroTelefono.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroTelefono.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroTelefono.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroTelefono.HintText = "";
            this.txtFiltroTelefono.isPassword = false;
            this.txtFiltroTelefono.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroTelefono.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroTelefono.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroTelefono.LineThickness = 3;
            this.txtFiltroTelefono.Location = new System.Drawing.Point(198, 160);
            this.txtFiltroTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroTelefono.Name = "txtFiltroTelefono";
            this.txtFiltroTelefono.Size = new System.Drawing.Size(113, 27);
            this.txtFiltroTelefono.TabIndex = 15;
            this.txtFiltroTelefono.Text = "Telefono";
            this.txtFiltroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFiltroCorreo
            // 
            this.txtFiltroCorreo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroCorreo.Font = new System.Drawing.Font("Century Gothic", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCorreo.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroCorreo.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroCorreo.HintText = "";
            this.txtFiltroCorreo.isPassword = false;
            this.txtFiltroCorreo.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroCorreo.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroCorreo.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroCorreo.LineThickness = 3;
            this.txtFiltroCorreo.Location = new System.Drawing.Point(46, 201);
            this.txtFiltroCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroCorreo.Name = "txtFiltroCorreo";
            this.txtFiltroCorreo.Size = new System.Drawing.Size(265, 27);
            this.txtFiltroCorreo.TabIndex = 16;
            this.txtFiltroCorreo.Text = "Correo";
            this.txtFiltroCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.lblfiltrar);
            this.bunifuCards2.Controls.Add(this.imgFiltro);
            this.bunifuCards2.Controls.Add(this.chkCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroTelefono);
            this.bunifuCards2.Controls.Add(this.chkTelefono);
            this.bunifuCards2.Controls.Add(this.chkFechaNacimiento);
            this.bunifuCards2.Controls.Add(this.txtFiltroFechaNacimiento);
            this.bunifuCards2.Controls.Add(this.txtFiltoescuela);
            this.bunifuCards2.Controls.Add(this.txtFiltonombre);
            this.bunifuCards2.Controls.Add(this.chkNombre);
            this.bunifuCards2.Controls.Add(this.chkEscuela);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(980, 24);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(335, 245);
            this.bunifuCards2.TabIndex = 17;
            // 
            // lblfiltrar
            // 
            this.lblfiltrar.AutoSize = true;
            this.lblfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblfiltrar.Location = new System.Drawing.Point(57, 23);
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
            this.imgFiltro.Location = new System.Drawing.Point(20, 18);
            this.imgFiltro.Name = "imgFiltro";
            this.imgFiltro.Size = new System.Drawing.Size(31, 36);
            this.imgFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiltro.TabIndex = 17;
            this.imgFiltro.TabStop = false;
            this.imgFiltro.Zoom = 10;
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
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEscuela;
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltoescuela;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroFechaNacimiento;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroTelefono;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroCorreo;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuImageButton imgFiltro;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfiltrar;
    }
}
