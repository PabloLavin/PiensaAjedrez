namespace PiensaAjedrez
{
    partial class Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnDesmarcar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMarcarTodos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbFechas = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.txtFiltroNoCtrl = new System.Windows.Forms.TextBox();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.lblfiltrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            this.chkCorreo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.chkNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            this.bunifuCards1.SuspendLayout();
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvAlumnos.GridColor = System.Drawing.Color.Black;
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(368, 17);
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
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(947, 584);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAlumnos_CellClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            this.dgvAlumnos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgvAlumnos_CellPainting);
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards2.Controls.Add(this.btnDesmarcar);
            this.bunifuCards2.Controls.Add(this.btnMarcarTodos);
            this.bunifuCards2.Controls.Add(this.lblFecha);
            this.bunifuCards2.Controls.Add(this.cbFechas);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(17, 228);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(334, 157);
            this.bunifuCards2.TabIndex = 9;
            this.bunifuCards2.TabStop = true;
            // 
            // btnDesmarcar
            // 
            this.btnDesmarcar.Activecolor = System.Drawing.Color.Firebrick;
            this.btnDesmarcar.BackColor = System.Drawing.Color.Firebrick;
            this.btnDesmarcar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDesmarcar.BorderRadius = 0;
            this.btnDesmarcar.ButtonText = "Desmarcar todos";
            this.btnDesmarcar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesmarcar.DisabledColor = System.Drawing.Color.Gray;
            this.btnDesmarcar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDesmarcar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDesmarcar.Iconimage")));
            this.btnDesmarcar.Iconimage_right = null;
            this.btnDesmarcar.Iconimage_right_Selected = null;
            this.btnDesmarcar.Iconimage_Selected = null;
            this.btnDesmarcar.IconMarginLeft = 0;
            this.btnDesmarcar.IconMarginRight = 0;
            this.btnDesmarcar.IconRightVisible = true;
            this.btnDesmarcar.IconRightZoom = 0D;
            this.btnDesmarcar.IconVisible = true;
            this.btnDesmarcar.IconZoom = 90D;
            this.btnDesmarcar.IsTab = false;
            this.btnDesmarcar.Location = new System.Drawing.Point(168, 94);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnDesmarcar.OnHovercolor = System.Drawing.Color.IndianRed;
            this.btnDesmarcar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDesmarcar.selected = false;
            this.btnDesmarcar.Size = new System.Drawing.Size(139, 48);
            this.btnDesmarcar.TabIndex = 12;
            this.btnDesmarcar.Text = "Desmarcar todos";
            this.btnDesmarcar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesmarcar.Textcolor = System.Drawing.Color.White;
            this.btnDesmarcar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcar.Click += new System.EventHandler(this.BtnDesmarcar_Click);
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(162)))), ((int)(((byte)(58)))));
            this.btnMarcarTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.btnMarcarTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMarcarTodos.BorderRadius = 0;
            this.btnMarcarTodos.ButtonText = "Marcar todos";
            this.btnMarcarTodos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarcarTodos.DisabledColor = System.Drawing.Color.Gray;
            this.btnMarcarTodos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMarcarTodos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMarcarTodos.Iconimage")));
            this.btnMarcarTodos.Iconimage_right = null;
            this.btnMarcarTodos.Iconimage_right_Selected = null;
            this.btnMarcarTodos.Iconimage_Selected = null;
            this.btnMarcarTodos.IconMarginLeft = 0;
            this.btnMarcarTodos.IconMarginRight = 0;
            this.btnMarcarTodos.IconRightVisible = true;
            this.btnMarcarTodos.IconRightZoom = 0D;
            this.btnMarcarTodos.IconVisible = true;
            this.btnMarcarTodos.IconZoom = 90D;
            this.btnMarcarTodos.IsTab = false;
            this.btnMarcarTodos.Location = new System.Drawing.Point(168, 25);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.btnMarcarTodos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(162)))), ((int)(((byte)(58)))));
            this.btnMarcarTodos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMarcarTodos.selected = false;
            this.btnMarcarTodos.Size = new System.Drawing.Size(139, 48);
            this.btnMarcarTodos.TabIndex = 11;
            this.btnMarcarTodos.Text = "Marcar todos";
            this.btnMarcarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcarTodos.Textcolor = System.Drawing.Color.White;
            this.btnMarcarTodos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarTodos.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(10, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(138, 36);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Seleccione la\r\n fecha de asistencia";
            // 
            // cbFechas
            // 
            this.cbFechas.BackColor = System.Drawing.Color.Transparent;
            this.cbFechas.BorderRadius = 3;
            this.cbFechas.DisabledColor = System.Drawing.Color.Gray;
            this.cbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFechas.ForeColor = System.Drawing.Color.White;
            this.cbFechas.Items = new string[0];
            this.cbFechas.Location = new System.Drawing.Point(13, 97);
            this.cbFechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFechas.Name = "cbFechas";
            this.cbFechas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbFechas.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbFechas.selectedIndex = -1;
            this.cbFechas.Size = new System.Drawing.Size(129, 35);
            this.cbFechas.TabIndex = 9;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Opciones";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards3.Controls.Add(this.txtFiltroNoCtrl);
            this.bunifuCards3.Controls.Add(this.txtFiltroNombre);
            this.bunifuCards3.Controls.Add(this.lblfiltrar);
            this.bunifuCards3.Controls.Add(this.imgFiltro);
            this.bunifuCards3.Controls.Add(this.chkCorreo);
            this.bunifuCards3.Controls.Add(this.chkNombre);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(17, 412);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(334, 180);
            this.bunifuCards3.TabIndex = 19;
            // 
            // txtFiltroNoCtrl
            // 
            this.txtFiltroNoCtrl.Enabled = false;
            this.txtFiltroNoCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNoCtrl.Location = new System.Drawing.Point(105, 118);
            this.txtFiltroNoCtrl.Name = "txtFiltroNoCtrl";
            this.txtFiltroNoCtrl.Size = new System.Drawing.Size(124, 22);
            this.txtFiltroNoCtrl.TabIndex = 27;
            this.txtFiltroNoCtrl.Text = "Número de Control";
            this.txtFiltroNoCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroNoCtrl.TextChanged += new System.EventHandler(this.TxtFiltroNoCtrl_TextChanged);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Enabled = false;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.Location = new System.Drawing.Point(38, 66);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(261, 22);
            this.txtFiltroNombre.TabIndex = 26;
            this.txtFiltroNombre.Text = "Nombre";
            this.txtFiltroNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroNombre.TextChanged += new System.EventHandler(this.TxtFiltroNombre_TextChanged);
            // 
            // lblfiltrar
            // 
            this.lblfiltrar.AutoSize = true;
            this.lblfiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.lblfiltrar.Location = new System.Drawing.Point(49, 19);
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
            this.imgFiltro.Size = new System.Drawing.Size(31, 30);
            this.imgFiltro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFiltro.TabIndex = 17;
            this.imgFiltro.TabStop = false;
            this.imgFiltro.Zoom = 10;
            // 
            // chkCorreo
            // 
            this.chkCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkCorreo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.chkCorreo.Checked = false;
            this.chkCorreo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkCorreo.ForeColor = System.Drawing.Color.White;
            this.chkCorreo.Location = new System.Drawing.Point(79, 117);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(20, 20);
            this.chkCorreo.TabIndex = 12;
            this.chkCorreo.OnChange += new System.EventHandler(this.ChkCorreo_OnChange);
            // 
            // chkNombre
            // 
            this.chkNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkNombre.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.chkNombre.Checked = false;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(12, 66);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(20, 20);
            this.chkNombre.TabIndex = 8;
            this.chkNombre.OnChange += new System.EventHandler(this.ChkNombre_OnChange);
            // 
            // lblColegios
            // 
            this.lblColegios.AutoSize = true;
            this.lblColegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblColegios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.lblColegios.Location = new System.Drawing.Point(15, 18);
            this.lblColegios.Name = "lblColegios";
            this.lblColegios.Size = new System.Drawing.Size(222, 25);
            this.lblColegios.TabIndex = 3;
            this.lblColegios.Text = "Selección de colegios";
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.Color.Transparent;
            this.btnEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuela.Image")));
            this.btnEscuela.ImageActive = null;
            this.btnEscuela.Location = new System.Drawing.Point(133, 51);
            this.btnEscuela.Name = "btnEscuela";
            this.btnEscuela.Size = new System.Drawing.Size(82, 65);
            this.btnEscuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEscuela.TabIndex = 5;
            this.btnEscuela.TabStop = false;
            this.btnEscuela.Zoom = 10;
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(21, 122);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(285, 35);
            this.cbEscuelas.TabIndex = 8;
            this.cbEscuelas.onItemSelected += new System.EventHandler(this.cbEscuelas_onItemSelected);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards1.Controls.Add(this.cbEscuelas);
            this.bunifuCards1.Controls.Add(this.btnEscuela);
            this.bunifuCards1.Controls.Add(this.lblColegios);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(17, 28);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(334, 180);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.TabStop = true;
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Asistencia";
            this.Size = new System.Drawing.Size(1342, 615);
            this.Load += new System.EventHandler(this.Asistencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuDropdown cbFechas;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarcarTodos;
        private Bunifu.Framework.UI.BunifuFlatButton btnDesmarcar;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfiltrar;
        private Bunifu.Framework.UI.BunifuImageButton imgFiltro;
        private Bunifu.Framework.UI.BunifuCheckbox chkCorreo;
        private Bunifu.Framework.UI.BunifuCheckbox chkNombre;
        private System.Windows.Forms.TextBox txtFiltroNoCtrl;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblColegios;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
    }
}
