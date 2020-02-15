namespace PiensaAjedrez
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
            this.bnfcarAgregar = new Bunifu.Framework.UI.BunifuCards();
            this.lblCumple = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCumple = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtGrado = new System.Windows.Forms.TextBox();
            this.txtTutor = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellidoM = new System.Windows.Forms.TextBox();
            this.txtApellidoP = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblGrado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancelar = new System.Windows.Forms.PictureBox();
            this.lblTutor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellidoM = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblApellidoP = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnAgregado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblActivo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblnumerocontrol = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNocontrol = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dtFechaNacimiento = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblCorreo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTelefono = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFechaNacimiento = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkEscuela = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkFechaNacimiento = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkTelefono = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkCorreo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.txtFiltroAño = new System.Windows.Forms.TextBox();
            this.txtFiltroCorreo = new System.Windows.Forms.TextBox();
            this.txtFiltroTelefono = new System.Windows.Forms.TextBox();
            this.txtFiltonombre = new System.Windows.Forms.TextBox();
            this.lblFiltroActivo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFiltroActivo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblFiltroEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboFiltroEscuela = new Bunifu.Framework.UI.BunifuDropdown();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.lblfiltrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            this.Cancelartt = new System.Windows.Forms.ToolTip(this.components);
            this.cbRango = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblRango = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.lblProfesor = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.bnfcarAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCumple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
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
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAlumnos.DoubleBuffered = true;
            this.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.GridColor = System.Drawing.Color.Black;
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(27, 279);
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
            this.dgvAlumnos.Size = new System.Drawing.Size(1288, 321);
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
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // tsEliminarAlumno
            // 
            this.tsEliminarAlumno.Name = "tsEliminarAlumno";
            this.tsEliminarAlumno.Padding = new System.Windows.Forms.Padding(0);
            this.tsEliminarAlumno.Size = new System.Drawing.Size(161, 20);
            this.tsEliminarAlumno.Text = "Eliminar alumno";
            this.tsEliminarAlumno.Click += new System.EventHandler(this.tsEliminarAlumno_Click);
            // 
            // bnfcarAgregar
            // 
            this.bnfcarAgregar.BackColor = System.Drawing.Color.White;
            this.bnfcarAgregar.BorderRadius = 5;
            this.bnfcarAgregar.BottomSahddow = true;
            this.bnfcarAgregar.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bnfcarAgregar.Controls.Add(this.txtProfesor);
            this.bnfcarAgregar.Controls.Add(this.lblProfesor);
            this.bnfcarAgregar.Controls.Add(this.cbRango);
            this.bnfcarAgregar.Controls.Add(this.lblRango);
            this.bnfcarAgregar.Controls.Add(this.lblCumple);
            this.bnfcarAgregar.Controls.Add(this.btnCumple);
            this.bnfcarAgregar.Controls.Add(this.txtGrado);
            this.bnfcarAgregar.Controls.Add(this.txtTutor);
            this.bnfcarAgregar.Controls.Add(this.txtCorreo);
            this.bnfcarAgregar.Controls.Add(this.txtTelefono);
            this.bnfcarAgregar.Controls.Add(this.txtApellidoM);
            this.bnfcarAgregar.Controls.Add(this.txtApellidoP);
            this.bnfcarAgregar.Controls.Add(this.txtNombre);
            this.bnfcarAgregar.Controls.Add(this.lblGrado);
            this.bnfcarAgregar.Controls.Add(this.btnCancelar);
            this.bnfcarAgregar.Controls.Add(this.lblTutor);
            this.bnfcarAgregar.Controls.Add(this.lblApellidoM);
            this.bnfcarAgregar.Controls.Add(this.lblApellidoP);
            this.bnfcarAgregar.Controls.Add(this.lblNombre);
            this.bnfcarAgregar.Controls.Add(this.btnLimpiar);
            this.bnfcarAgregar.Controls.Add(this.cbEscuelas);
            this.bnfcarAgregar.Controls.Add(this.btnAgregado);
            this.bnfcarAgregar.Controls.Add(this.lblActivo);
            this.bnfcarAgregar.Controls.Add(this.chkActivo);
            this.bnfcarAgregar.Controls.Add(this.lblnumerocontrol);
            this.bnfcarAgregar.Controls.Add(this.lblNocontrol);
            this.bnfcarAgregar.Controls.Add(this.btnAgregar);
            this.bnfcarAgregar.Controls.Add(this.dtFechaNacimiento);
            this.bnfcarAgregar.Controls.Add(this.lblCorreo);
            this.bnfcarAgregar.Controls.Add(this.lblTelefono);
            this.bnfcarAgregar.Controls.Add(this.lblFechaNacimiento);
            this.bnfcarAgregar.Controls.Add(this.lblEscuela);
            this.bnfcarAgregar.LeftSahddow = false;
            this.bnfcarAgregar.Location = new System.Drawing.Point(27, 8);
            this.bnfcarAgregar.Name = "bnfcarAgregar";
            this.bnfcarAgregar.RightSahddow = true;
            this.bnfcarAgregar.ShadowDepth = 20;
            this.bnfcarAgregar.Size = new System.Drawing.Size(923, 252);
            this.bnfcarAgregar.TabIndex = 0;
            this.bnfcarAgregar.TabStop = true;
            this.bnfcarAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            this.bnfcarAgregar.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // lblCumple
            // 
            this.lblCumple.AutoSize = true;
            this.lblCumple.BackColor = System.Drawing.Color.Transparent;
            this.lblCumple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCumple.ForeColor = System.Drawing.Color.Black;
            this.lblCumple.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCumple.Location = new System.Drawing.Point(69, 219);
            this.lblCumple.Name = "lblCumple";
            this.lblCumple.Size = new System.Drawing.Size(138, 20);
            this.lblCumple.TabIndex = 23;
            this.lblCumple.Text = "Cumpleañeros de ";
            // 
            // btnCumple
            // 
            this.btnCumple.BackColor = System.Drawing.Color.Transparent;
            this.btnCumple.Image = ((System.Drawing.Image)(resources.GetObject("btnCumple.Image")));
            this.btnCumple.ImageActive = ((System.Drawing.Image)(resources.GetObject("btnCumple.ImageActive")));
            this.btnCumple.Location = new System.Drawing.Point(12, 210);
            this.btnCumple.Name = "btnCumple";
            this.btnCumple.Size = new System.Drawing.Size(51, 36);
            this.btnCumple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCumple.TabIndex = 32;
            this.btnCumple.TabStop = false;
            this.Cancelartt.SetToolTip(this.btnCumple, "Ver Alumnos que cumplen años");
            this.btnCumple.Zoom = 10;
            this.btnCumple.Click += new System.EventHandler(this.BtnCumple_Click);
            // 
            // txtGrado
            // 
            this.txtGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrado.Location = new System.Drawing.Point(474, 220);
            this.txtGrado.Name = "txtGrado";
            this.txtGrado.Size = new System.Drawing.Size(73, 24);
            this.txtGrado.TabIndex = 31;
            // 
            // txtTutor
            // 
            this.txtTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTutor.Location = new System.Drawing.Point(144, 147);
            this.txtTutor.Name = "txtTutor";
            this.txtTutor.Size = new System.Drawing.Size(259, 24);
            this.txtTutor.TabIndex = 30;
            // 
            // txtCorreo
            // 
            this.txtCorreo.AutoCompleteCustomSource.AddRange(new string[] {
            "@hotmail.com",
            "@gmail.com",
            "@outlook.com",
            " gmail.com",
            " hotmail.com",
            " outlook.com"});
            this.txtCorreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCorreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(625, 89);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(251, 24);
            this.txtCorreo.TabIndex = 29;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(432, 89);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(115, 24);
            this.txtTelefono.TabIndex = 28;
            // 
            // txtApellidoM
            // 
            this.txtApellidoM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtApellidoM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoM.Location = new System.Drawing.Point(715, 54);
            this.txtApellidoM.Name = "txtApellidoM";
            this.txtApellidoM.Size = new System.Drawing.Size(161, 24);
            this.txtApellidoM.TabIndex = 27;
            // 
            // txtApellidoP
            // 
            this.txtApellidoP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtApellidoP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoP.Location = new System.Drawing.Point(447, 54);
            this.txtApellidoP.Name = "txtApellidoP";
            this.txtApellidoP.Size = new System.Drawing.Size(154, 24);
            this.txtApellidoP.TabIndex = 26;
            // 
            // txtNombre
            // 
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtNombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 56);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(212, 24);
            this.txtNombre.TabIndex = 25;
            // 
            // lblGrado
            // 
            this.lblGrado.AutoSize = true;
            this.lblGrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrado.ForeColor = System.Drawing.Color.Black;
            this.lblGrado.Location = new System.Drawing.Point(409, 221);
            this.lblGrado.Name = "lblGrado";
            this.lblGrado.Size = new System.Drawing.Size(59, 20);
            this.lblGrado.TabIndex = 24;
            this.lblGrado.Text = "Grado";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.InitialImage")));
            this.btnCancelar.Location = new System.Drawing.Point(877, 209);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(30, 30);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.TabStop = false;
            this.Cancelartt.SetToolTip(this.btnCancelar, "Cancelar edición");
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTutor
            // 
            this.lblTutor.AutoSize = true;
            this.lblTutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutor.ForeColor = System.Drawing.Color.Black;
            this.lblTutor.Location = new System.Drawing.Point(20, 147);
            this.lblTutor.Name = "lblTutor";
            this.lblTutor.Size = new System.Drawing.Size(118, 20);
            this.lblTutor.TabIndex = 16;
            this.lblTutor.Text = "Padre o Tutor";
            // 
            // lblApellidoM
            // 
            this.lblApellidoM.AutoSize = true;
            this.lblApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoM.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoM.Location = new System.Drawing.Point(612, 55);
            this.lblApellidoM.Name = "lblApellidoM";
            this.lblApellidoM.Size = new System.Drawing.Size(97, 20);
            this.lblApellidoM.TabIndex = 22;
            this.lblApellidoM.Text = "Apellido M.";
            // 
            // lblApellidoP
            // 
            this.lblApellidoP.AutoSize = true;
            this.lblApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoP.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoP.Location = new System.Drawing.Point(346, 55);
            this.lblApellidoP.Name = "lblApellidoP";
            this.lblApellidoP.Size = new System.Drawing.Size(94, 20);
            this.lblApellidoP.TabIndex = 20;
            this.lblApellidoP.Text = "Apellido P.";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(19, 55);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(92, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre(s)";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.BackgroundImage")));
            this.btnLimpiar.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.InitialImage")));
            this.btnLimpiar.Location = new System.Drawing.Point(874, 15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(30, 32);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.TabStop = false;
            this.Cancelartt.SetToolTip(this.btnLimpiar, "Limpiar campos");
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(485, 136);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(391, 35);
            this.cbEscuelas.TabIndex = 7;
            this.cbEscuelas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
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
            this.lblActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivo.ForeColor = System.Drawing.Color.Black;
            this.lblActivo.Location = new System.Drawing.Point(607, 220);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(58, 20);
            this.lblActivo.TabIndex = 10;
            this.lblActivo.Text = "Activo";
            // 
            // chkActivo
            // 
            this.chkActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkActivo.Checked = true;
            this.chkActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkActivo.ForeColor = System.Drawing.Color.White;
            this.chkActivo.Location = new System.Drawing.Point(581, 220);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(20, 20);
            this.chkActivo.TabIndex = 9;
            this.chkActivo.OnChange += new System.EventHandler(this.chkActivo_OnChange);
            this.chkActivo.Click += new System.EventHandler(this.chkActivo_Click);
            this.chkActivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lblnumerocontrol
            // 
            this.lblnumerocontrol.AutoSize = true;
            this.lblnumerocontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerocontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.lblnumerocontrol.Location = new System.Drawing.Point(97, 13);
            this.lblnumerocontrol.Name = "lblnumerocontrol";
            this.lblnumerocontrol.Size = new System.Drawing.Size(74, 25);
            this.lblnumerocontrol.TabIndex = 7;
            this.lblnumerocontrol.Text = "No.ctrl";
            // 
            // lblNocontrol
            // 
            this.lblNocontrol.AutoSize = true;
            this.lblNocontrol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNocontrol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.lblNocontrol.Location = new System.Drawing.Point(14, 13);
            this.lblNocontrol.Name = "lblNocontrol";
            this.lblNocontrol.Size = new System.Drawing.Size(81, 25);
            this.lblNocontrol.TabIndex = 6;
            this.lblNocontrol.Text = "No.ctrl";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ActiveBorderThickness = 1;
            this.btnAgregar.ActiveCornerRadius = 20;
            this.btnAgregar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(104)))), ((int)(((byte)(29)))));
            this.btnAgregar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAgregar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(104)))), ((int)(((byte)(29)))));
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgregar.BackgroundImage")));
            this.btnAgregar.ButtonText = "Agregar";
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnAgregar.IdleBorderThickness = 1;
            this.btnAgregar.IdleCornerRadius = 20;
            this.btnAgregar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btnAgregar.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.btnAgregar.Location = new System.Drawing.Point(691, 202);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(185, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dtFechaNacimiento.BorderRadius = 0;
            this.dtFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.dtFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaNacimiento.FormatCustom = null;
            this.dtFechaNacimiento.Location = new System.Drawing.Point(163, 90);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(167, 36);
            this.dtFechaNacimiento.TabIndex = 3;
            this.dtFechaNacimiento.Value = new System.DateTime(2010, 9, 2, 0, 0, 0, 0);
            this.dtFechaNacimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Black;
            this.lblCorreo.Location = new System.Drawing.Point(555, 89);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(63, 20);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(346, 89);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(79, 20);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 95);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(141, 20);
            this.lblFechaNacimiento.TabIndex = 3;
            this.lblFechaNacimiento.Text = "Fecha de nacim.";
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscuela.ForeColor = System.Drawing.Color.Black;
            this.lblEscuela.Location = new System.Drawing.Point(409, 147);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(73, 20);
            this.lblEscuela.TabIndex = 2;
            this.lblEscuela.Text = "Escuela";
            // 
            // chkNombre
            // 
            this.chkNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkNombre.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkNombre.Checked = false;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(12, 54);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(20, 20);
            this.chkNombre.TabIndex = 8;
            this.chkNombre.OnChange += new System.EventHandler(this.chkNombre_OnChange);
            // 
            // chkEscuela
            // 
            this.chkEscuela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkEscuela.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkEscuela.Checked = false;
            this.chkEscuela.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkEscuela.ForeColor = System.Drawing.Color.White;
            this.chkEscuela.Location = new System.Drawing.Point(12, 94);
            this.chkEscuela.Name = "chkEscuela";
            this.chkEscuela.Size = new System.Drawing.Size(20, 20);
            this.chkEscuela.TabIndex = 9;
            this.chkEscuela.OnChange += new System.EventHandler(this.chkEscuela_OnChange);
            // 
            // chkFechaNacimiento
            // 
            this.chkFechaNacimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkFechaNacimiento.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkFechaNacimiento.Checked = false;
            this.chkFechaNacimiento.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkFechaNacimiento.ForeColor = System.Drawing.Color.White;
            this.chkFechaNacimiento.Location = new System.Drawing.Point(12, 134);
            this.chkFechaNacimiento.Name = "chkFechaNacimiento";
            this.chkFechaNacimiento.Size = new System.Drawing.Size(20, 20);
            this.chkFechaNacimiento.TabIndex = 10;
            this.chkFechaNacimiento.OnChange += new System.EventHandler(this.chkFechaNacimiento_OnChange);
            // 
            // chkTelefono
            // 
            this.chkTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkTelefono.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkTelefono.Checked = false;
            this.chkTelefono.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkTelefono.ForeColor = System.Drawing.Color.White;
            this.chkTelefono.Location = new System.Drawing.Point(178, 134);
            this.chkTelefono.Name = "chkTelefono";
            this.chkTelefono.Size = new System.Drawing.Size(20, 20);
            this.chkTelefono.TabIndex = 11;
            this.chkTelefono.OnChange += new System.EventHandler(this.chkTelefono_OnChange);
            // 
            // chkCorreo
            // 
            this.chkCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkCorreo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkCorreo.Checked = false;
            this.chkCorreo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkCorreo.ForeColor = System.Drawing.Color.White;
            this.chkCorreo.Location = new System.Drawing.Point(12, 173);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(20, 20);
            this.chkCorreo.TabIndex = 12;
            this.chkCorreo.OnChange += new System.EventHandler(this.chkCorreo_OnChange);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards2.Controls.Add(this.txtFiltroAño);
            this.bunifuCards2.Controls.Add(this.txtFiltroCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroTelefono);
            this.bunifuCards2.Controls.Add(this.txtFiltonombre);
            this.bunifuCards2.Controls.Add(this.lblFiltroActivo);
            this.bunifuCards2.Controls.Add(this.chkFiltroActivo);
            this.bunifuCards2.Controls.Add(this.lblFiltroEscuela);
            this.bunifuCards2.Controls.Add(this.cboFiltroEscuela);
            this.bunifuCards2.Controls.Add(this.cbMes);
            this.bunifuCards2.Controls.Add(this.cbDia);
            this.bunifuCards2.Controls.Add(this.lblfiltrar);
            this.bunifuCards2.Controls.Add(this.imgFiltro);
            this.bunifuCards2.Controls.Add(this.chkCorreo);
            this.bunifuCards2.Controls.Add(this.chkTelefono);
            this.bunifuCards2.Controls.Add(this.chkFechaNacimiento);
            this.bunifuCards2.Controls.Add(this.chkNombre);
            this.bunifuCards2.Controls.Add(this.chkEscuela);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(980, 8);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(335, 252);
            this.bunifuCards2.TabIndex = 17;
            // 
            // txtFiltroAño
            // 
            this.txtFiltroAño.Enabled = false;
            this.txtFiltroAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroAño.Location = new System.Drawing.Point(111, 133);
            this.txtFiltroAño.Name = "txtFiltroAño";
            this.txtFiltroAño.Size = new System.Drawing.Size(52, 24);
            this.txtFiltroAño.TabIndex = 27;
            this.txtFiltroAño.Text = "Año";
            this.txtFiltroAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroAño.TextChanged += new System.EventHandler(this.TxtFiltroAño_TextChanged);
            // 
            // txtFiltroCorreo
            // 
            this.txtFiltroCorreo.Enabled = false;
            this.txtFiltroCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroCorreo.Location = new System.Drawing.Point(38, 173);
            this.txtFiltroCorreo.Name = "txtFiltroCorreo";
            this.txtFiltroCorreo.Size = new System.Drawing.Size(273, 24);
            this.txtFiltroCorreo.TabIndex = 26;
            this.txtFiltroCorreo.Text = "Correo";
            this.txtFiltroCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroCorreo.TextChanged += new System.EventHandler(this.TxtFiltroCorreo_TextChanged);
            // 
            // txtFiltroTelefono
            // 
            this.txtFiltroTelefono.Enabled = false;
            this.txtFiltroTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroTelefono.Location = new System.Drawing.Point(204, 134);
            this.txtFiltroTelefono.Name = "txtFiltroTelefono";
            this.txtFiltroTelefono.Size = new System.Drawing.Size(107, 24);
            this.txtFiltroTelefono.TabIndex = 25;
            this.txtFiltroTelefono.Text = "Teléfono";
            this.txtFiltroTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroTelefono.TextChanged += new System.EventHandler(this.TxtFiltroTelefono_TextChanged);
            // 
            // txtFiltonombre
            // 
            this.txtFiltonombre.Enabled = false;
            this.txtFiltonombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltonombre.Location = new System.Drawing.Point(38, 54);
            this.txtFiltonombre.Name = "txtFiltonombre";
            this.txtFiltonombre.Size = new System.Drawing.Size(273, 24);
            this.txtFiltonombre.TabIndex = 24;
            this.txtFiltonombre.Text = "Nombre";
            this.txtFiltonombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltonombre.TextChanged += new System.EventHandler(this.TxtFiltonombre_TextChanged);
            // 
            // lblFiltroActivo
            // 
            this.lblFiltroActivo.AutoSize = true;
            this.lblFiltroActivo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblFiltroActivo.ForeColor = System.Drawing.Color.Black;
            this.lblFiltroActivo.Location = new System.Drawing.Point(37, 209);
            this.lblFiltroActivo.Name = "lblFiltroActivo";
            this.lblFiltroActivo.Size = new System.Drawing.Size(171, 21);
            this.lblFiltroActivo.TabIndex = 23;
            this.lblFiltroActivo.Text = "Sólo alumnos activos";
            // 
            // chkFiltroActivo
            // 
            this.chkFiltroActivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkFiltroActivo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkFiltroActivo.Checked = false;
            this.chkFiltroActivo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkFiltroActivo.ForeColor = System.Drawing.Color.White;
            this.chkFiltroActivo.Location = new System.Drawing.Point(12, 210);
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
            this.lblFiltroEscuela.Location = new System.Drawing.Point(47, 94);
            this.lblFiltroEscuela.Name = "lblFiltroEscuela";
            this.lblFiltroEscuela.Size = new System.Drawing.Size(69, 21);
            this.lblFiltroEscuela.TabIndex = 15;
            this.lblFiltroEscuela.Text = "Escuela";
            // 
            // cboFiltroEscuela
            // 
            this.cboFiltroEscuela.BackColor = System.Drawing.Color.Transparent;
            this.cboFiltroEscuela.BorderRadius = 3;
            this.cboFiltroEscuela.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.cboFiltroEscuela.Enabled = false;
            this.cboFiltroEscuela.ForeColor = System.Drawing.Color.White;
            this.cboFiltroEscuela.Items = new string[0];
            this.cboFiltroEscuela.Location = new System.Drawing.Point(120, 88);
            this.cboFiltroEscuela.Name = "cboFiltroEscuela";
            this.cboFiltroEscuela.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cboFiltroEscuela.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cboFiltroEscuela.selectedIndex = -1;
            this.cboFiltroEscuela.Size = new System.Drawing.Size(191, 35);
            this.cboFiltroEscuela.TabIndex = 22;
            this.cboFiltroEscuela.onItemSelected += new System.EventHandler(this.cboFiltroEscuela_OnItemSelected);
            // 
            // cbMes
            // 
            this.cbMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
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
            this.cbMes.Location = new System.Drawing.Point(54, 131);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(51, 25);
            this.cbMes.TabIndex = 20;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.TextChanged += new System.EventHandler(this.cbMes_TextChanged);
            // 
            // cbDia
            // 
            this.cbDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
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
            this.cbDia.Location = new System.Drawing.Point(42, 131);
            this.cbDia.MaxDropDownItems = 12;
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(37, 25);
            this.cbDia.TabIndex = 19;
            this.cbDia.Visible = false;
            this.cbDia.TextChanged += new System.EventHandler(this.cbDia_TextChanged);
            // 
            // lblfiltrar
            // 
            this.lblfiltrar.AutoSize = true;
            this.lblfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrar.ForeColor = System.Drawing.Color.DimGray;
            this.lblfiltrar.Location = new System.Drawing.Point(49, 18);
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
            this.imgFiltro.Location = new System.Drawing.Point(12, 10);
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
            // cbRango
            // 
            this.cbRango.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbRango.BorderRadius = 3;
            this.cbRango.DisabledColor = System.Drawing.Color.Gray;
            this.cbRango.ForeColor = System.Drawing.Color.White;
            this.cbRango.Items = new string[0];
            this.cbRango.Location = new System.Drawing.Point(96, 176);
            this.cbRango.Name = "cbRango";
            this.cbRango.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbRango.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbRango.selectedIndex = -1;
            this.cbRango.Size = new System.Drawing.Size(234, 35);
            this.cbRango.TabIndex = 34;
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.ForeColor = System.Drawing.Color.Black;
            this.lblRango.Location = new System.Drawing.Point(20, 187);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(62, 20);
            this.lblRango.TabIndex = 33;
            this.lblRango.Text = "Rango";
            // 
            // txtProfesor
            // 
            this.txtProfesor.AutoCompleteCustomSource.AddRange(new string[] {
            "@hotmail.com",
            "@gmail.com",
            "@outlook.com",
            " gmail.com",
            " hotmail.com",
            " outlook.com"});
            this.txtProfesor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProfesor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfesor.Location = new System.Drawing.Point(432, 187);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(251, 24);
            this.txtProfesor.TabIndex = 36;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfesor.ForeColor = System.Drawing.Color.Black;
            this.lblProfesor.Location = new System.Drawing.Point(346, 187);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(77, 20);
            this.lblProfesor.TabIndex = 35;
            this.lblProfesor.Text = "Profesor";
            // 
            // RegistroAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bnfcarAgregar);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.bunifuCards2);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RegistroAlumnos";
            this.Size = new System.Drawing.Size(1342, 615);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.bnfcarAgregar.ResumeLayout(false);
            this.bnfcarAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCumple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
        private Bunifu.Framework.UI.BunifuCards bnfcarAgregar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCorreo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTelefono;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAgregar;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCheckbox chkNombre;
        private Bunifu.Framework.UI.BunifuCheckbox chkEscuela;
        private Bunifu.Framework.UI.BunifuCheckbox chkFechaNacimiento;
        private Bunifu.Framework.UI.BunifuCheckbox chkTelefono;
        private Bunifu.Framework.UI.BunifuCheckbox chkCorreo;
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
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltroEscuela;
        private Bunifu.Framework.UI.BunifuDropdown cboFiltroEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFiltroActivo;
        private Bunifu.Framework.UI.BunifuCheckbox chkFiltroActivo;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTutor;
        private System.Windows.Forms.ToolTip Cancelartt;
        private System.Windows.Forms.PictureBox btnCancelar;
        private System.Windows.Forms.PictureBox btnLimpiar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsEliminarAlumno;
        private Bunifu.Framework.UI.BunifuCustomLabel lblApellidoM;
        private Bunifu.Framework.UI.BunifuCustomLabel lblApellidoP;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGrado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidoP;
        private System.Windows.Forms.TextBox txtApellidoM;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtGrado;
        private System.Windows.Forms.TextBox txtTutor;
        private System.Windows.Forms.TextBox txtFiltroAño;
        private System.Windows.Forms.TextBox txtFiltroCorreo;
        private System.Windows.Forms.TextBox txtFiltroTelefono;
        private System.Windows.Forms.TextBox txtFiltonombre;
        private Bunifu.Framework.UI.BunifuImageButton btnCumple;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCumple;
        private System.Windows.Forms.TextBox txtProfesor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblProfesor;
        private Bunifu.Framework.UI.BunifuDropdown cbRango;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRango;
    }
}
