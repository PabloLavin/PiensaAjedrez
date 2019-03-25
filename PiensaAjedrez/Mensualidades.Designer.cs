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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensualidades));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.cbAño = new System.Windows.Forms.ComboBox();
            this.chkAño = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblfiltrar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgFiltro = new Bunifu.Framework.UI.BunifuImageButton();
            this.chkCorreo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtFiltroNoCtrl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtFiltroNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chkNombre = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblNota = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNota = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblMesAPagar = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFechaPago = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtFechaPago = new Bunifu.Framework.UI.BunifuDatepicker();
            this.btnRegistroPago = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAgregado = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMetodoPago = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbMetodoPago = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblMonto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMonto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblAlumno = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNombre = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNroControl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.cbAño);
            this.bunifuCards2.Controls.Add(this.chkAño);
            this.bunifuCards2.Controls.Add(this.lblfiltrar);
            this.bunifuCards2.Controls.Add(this.imgFiltro);
            this.bunifuCards2.Controls.Add(this.chkCorreo);
            this.bunifuCards2.Controls.Add(this.txtFiltroNoCtrl);
            this.bunifuCards2.Controls.Add(this.txtFiltroNombre);
            this.bunifuCards2.Controls.Add(this.chkNombre);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(980, 24);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(335, 257);
            this.bunifuCards2.TabIndex = 18;
            // 
            // cbAño
            // 
            this.cbAño.BackColor = System.Drawing.Color.SkyBlue;
            this.cbAño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAño.Enabled = false;
            this.cbAño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAño.ForeColor = System.Drawing.Color.White;
            this.cbAño.FormattingEnabled = true;
            this.cbAño.IntegralHeight = false;
            this.cbAño.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbAño.Location = new System.Drawing.Point(128, 187);
            this.cbAño.MaxDropDownItems = 12;
            this.cbAño.Name = "cbAño";
            this.cbAño.Size = new System.Drawing.Size(105, 32);
            this.cbAño.TabIndex = 25;
            this.cbAño.TextChanged += new System.EventHandler(this.cbAño_TextChanged);
            // 
            // chkAño
            // 
            this.chkAño.BackColor = System.Drawing.Color.SkyBlue;
            this.chkAño.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkAño.Checked = false;
            this.chkAño.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkAño.ForeColor = System.Drawing.Color.White;
            this.chkAño.Location = new System.Drawing.Point(102, 192);
            this.chkAño.Name = "chkAño";
            this.chkAño.Size = new System.Drawing.Size(20, 20);
            this.chkAño.TabIndex = 24;
            this.chkAño.OnChange += new System.EventHandler(this.chkAño_OnChange);
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
            // chkCorreo
            // 
            this.chkCorreo.BackColor = System.Drawing.Color.SkyBlue;
            this.chkCorreo.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkCorreo.Checked = false;
            this.chkCorreo.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkCorreo.ForeColor = System.Drawing.Color.White;
            this.chkCorreo.Location = new System.Drawing.Point(12, 142);
            this.chkCorreo.Name = "chkCorreo";
            this.chkCorreo.Size = new System.Drawing.Size(20, 20);
            this.chkCorreo.TabIndex = 12;
            this.chkCorreo.OnChange += new System.EventHandler(this.chkCorreo_OnChange);
            // 
            // txtFiltroNoCtrl
            // 
            this.txtFiltroNoCtrl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroNoCtrl.Enabled = false;
            this.txtFiltroNoCtrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNoCtrl.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroNoCtrl.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroNoCtrl.HintText = "";
            this.txtFiltroNoCtrl.isPassword = false;
            this.txtFiltroNoCtrl.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroNoCtrl.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroNoCtrl.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroNoCtrl.LineThickness = 3;
            this.txtFiltroNoCtrl.Location = new System.Drawing.Point(38, 135);
            this.txtFiltroNoCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroNoCtrl.Name = "txtFiltroNoCtrl";
            this.txtFiltroNoCtrl.Size = new System.Drawing.Size(279, 27);
            this.txtFiltroNoCtrl.TabIndex = 16;
            this.txtFiltroNoCtrl.Text = "No. ctrl.";
            this.txtFiltroNoCtrl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroNoCtrl.OnValueChanged += new System.EventHandler(this.txtFiltroNoCtrl_OnValueChanged);
            this.txtFiltroNoCtrl.Enter += new System.EventHandler(this.txtFiltroNoCtrl_Enter);
            this.txtFiltroNoCtrl.Leave += new System.EventHandler(this.txtFiltroNoCtrl_Leave);
            this.txtFiltroNoCtrl.MouseEnter += new System.EventHandler(this.txtFiltroNoCtrl_MouseEnter);
            this.txtFiltroNoCtrl.MouseLeave += new System.EventHandler(this.txtFiltroNoCtrl_MouseLeave);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltroNombre.Enabled = false;
            this.txtFiltroNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroNombre.ForeColor = System.Drawing.Color.Black;
            this.txtFiltroNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtFiltroNombre.HintText = "";
            this.txtFiltroNombre.isPassword = false;
            this.txtFiltroNombre.LineFocusedColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroNombre.LineIdleColor = System.Drawing.Color.Teal;
            this.txtFiltroNombre.LineMouseHoverColor = System.Drawing.Color.DeepSkyBlue;
            this.txtFiltroNombre.LineThickness = 3;
            this.txtFiltroNombre.Location = new System.Drawing.Point(38, 83);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(279, 27);
            this.txtFiltroNombre.TabIndex = 6;
            this.txtFiltroNombre.Text = "Nombre";
            this.txtFiltroNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFiltroNombre.OnValueChanged += new System.EventHandler(this.txtFiltroNombre_OnValueChanged);
            this.txtFiltroNombre.Enter += new System.EventHandler(this.txtFiltroNombre_Enter);
            this.txtFiltroNombre.Leave += new System.EventHandler(this.txtFiltroNombre_Leave);
            this.txtFiltroNombre.MouseEnter += new System.EventHandler(this.txtFiltroNombre_MouseEnter);
            this.txtFiltroNombre.MouseLeave += new System.EventHandler(this.txtFiltroNombre_MouseLeave);
            // 
            // chkNombre
            // 
            this.chkNombre.BackColor = System.Drawing.Color.SkyBlue;
            this.chkNombre.ChechedOffColor = System.Drawing.Color.SkyBlue;
            this.chkNombre.Checked = false;
            this.chkNombre.CheckedOnColor = System.Drawing.Color.LightSeaGreen;
            this.chkNombre.ForeColor = System.Drawing.Color.White;
            this.chkNombre.Location = new System.Drawing.Point(12, 89);
            this.chkNombre.Name = "chkNombre";
            this.chkNombre.Size = new System.Drawing.Size(20, 20);
            this.chkNombre.TabIndex = 8;
            this.chkNombre.OnChange += new System.EventHandler(this.chkNombre_OnChange);
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.lblNota);
            this.bunifuCards1.Controls.Add(this.txtNota);
            this.bunifuCards1.Controls.Add(this.lblMesAPagar);
            this.bunifuCards1.Controls.Add(this.lblFechaPago);
            this.bunifuCards1.Controls.Add(this.dtFechaPago);
            this.bunifuCards1.Controls.Add(this.btnRegistroPago);
            this.bunifuCards1.Controls.Add(this.btnAgregado);
            this.bunifuCards1.Controls.Add(this.lblMetodoPago);
            this.bunifuCards1.Controls.Add(this.cbMetodoPago);
            this.bunifuCards1.Controls.Add(this.lblMonto);
            this.bunifuCards1.Controls.Add(this.txtMonto);
            this.bunifuCards1.Controls.Add(this.lblAlumno);
            this.bunifuCards1.Controls.Add(this.lblNombre);
            this.bunifuCards1.Controls.Add(this.lblNroControl);
            this.bunifuCards1.Controls.Add(this.bunifuImageButton2);
            this.bunifuCards1.Controls.Add(this.btnEscuela);
            this.bunifuCards1.Controls.Add(this.lblEscuela);
            this.bunifuCards1.Controls.Add(this.cbEscuelas);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(27, 24);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(923, 257);
            this.bunifuCards1.TabIndex = 19;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.Black;
            this.lblNota.Location = new System.Drawing.Point(673, 178);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(43, 20);
            this.lblNota.TabIndex = 32;
            this.lblNota.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNota.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNota.HintForeColor = System.Drawing.Color.Empty;
            this.txtNota.HintText = "";
            this.txtNota.isPassword = false;
            this.txtNota.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtNota.LineIdleColor = System.Drawing.Color.Teal;
            this.txtNota.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtNota.LineThickness = 4;
            this.txtNota.Location = new System.Drawing.Point(723, 165);
            this.txtNota.Margin = new System.Windows.Forms.Padding(4);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(132, 33);
            this.txtNota.TabIndex = 31;
            this.txtNota.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblMesAPagar
            // 
            this.lblMesAPagar.AutoSize = true;
            this.lblMesAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAPagar.ForeColor = System.Drawing.Color.Black;
            this.lblMesAPagar.Location = new System.Drawing.Point(730, 42);
            this.lblMesAPagar.Name = "lblMesAPagar";
            this.lblMesAPagar.Size = new System.Drawing.Size(49, 24);
            this.lblMesAPagar.TabIndex = 30;
            this.lblMesAPagar.Text = "Mes";
            // 
            // lblFechaPago
            // 
            this.lblFechaPago.AutoSize = true;
            this.lblFechaPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPago.ForeColor = System.Drawing.Color.Black;
            this.lblFechaPago.Location = new System.Drawing.Point(455, 178);
            this.lblFechaPago.Name = "lblFechaPago";
            this.lblFechaPago.Size = new System.Drawing.Size(116, 20);
            this.lblFechaPago.TabIndex = 29;
            this.lblFechaPago.Text = "Fecha de pago";
            // 
            // dtFechaPago
            // 
            this.dtFechaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.dtFechaPago.BorderRadius = 0;
            this.dtFechaPago.ForeColor = System.Drawing.Color.White;
            this.dtFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaPago.FormatCustom = null;
            this.dtFechaPago.Location = new System.Drawing.Point(459, 201);
            this.dtFechaPago.Name = "dtFechaPago";
            this.dtFechaPago.Size = new System.Drawing.Size(148, 28);
            this.dtFechaPago.TabIndex = 28;
            this.toolTip1.SetToolTip(this.dtFechaPago, "Fecha de pago");
            this.dtFechaPago.Value = new System.DateTime(2019, 3, 12, 0, 0, 0, 0);
            // 
            // btnRegistroPago
            // 
            this.btnRegistroPago.ActiveBorderThickness = 1;
            this.btnRegistroPago.ActiveCornerRadius = 20;
            this.btnRegistroPago.ActiveFillColor = System.Drawing.Color.Teal;
            this.btnRegistroPago.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistroPago.ActiveLineColor = System.Drawing.Color.Teal;
            this.btnRegistroPago.BackColor = System.Drawing.Color.White;
            this.btnRegistroPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistroPago.BackgroundImage")));
            this.btnRegistroPago.ButtonText = "Registrar pago";
            this.btnRegistroPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistroPago.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroPago.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btnRegistroPago.IdleBorderThickness = 1;
            this.btnRegistroPago.IdleCornerRadius = 20;
            this.btnRegistroPago.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnRegistroPago.IdleForecolor = System.Drawing.Color.White;
            this.btnRegistroPago.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnRegistroPago.Location = new System.Drawing.Point(670, 211);
            this.btnRegistroPago.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistroPago.Name = "btnRegistroPago";
            this.btnRegistroPago.Size = new System.Drawing.Size(185, 41);
            this.btnRegistroPago.TabIndex = 27;
            this.btnRegistroPago.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistroPago.Click += new System.EventHandler(this.btnRegistroPago_Click);
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
            this.btnAgregado.Location = new System.Drawing.Point(863, 220);
            this.btnAgregado.Name = "btnAgregado";
            this.btnAgregado.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAgregado.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAgregado.selected = false;
            this.btnAgregado.Size = new System.Drawing.Size(25, 25);
            this.btnAgregado.TabIndex = 20;
            this.btnAgregado.Text = "bunifuFlatButton1";
            this.btnAgregado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregado.Textcolor = System.Drawing.Color.White;
            this.btnAgregado.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetodoPago.ForeColor = System.Drawing.Color.Black;
            this.lblMetodoPago.Location = new System.Drawing.Point(602, 121);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(125, 20);
            this.lblMetodoPago.TabIndex = 24;
            this.lblMetodoPago.Text = "Método de pago";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cbMetodoPago.BorderRadius = 3;
            this.cbMetodoPago.DisabledColor = System.Drawing.Color.SkyBlue;
            this.cbMetodoPago.ForeColor = System.Drawing.Color.White;
            this.cbMetodoPago.Items = new string[] {
        "Efectivo",
        "Depósito"};
            this.cbMetodoPago.Location = new System.Drawing.Point(733, 113);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbMetodoPago.onHoverColor = System.Drawing.Color.Teal;
            this.cbMetodoPago.selectedIndex = 0;
            this.cbMetodoPago.Size = new System.Drawing.Size(122, 35);
            this.cbMetodoPago.TabIndex = 23;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.ForeColor = System.Drawing.Color.Black;
            this.lblMonto.Location = new System.Drawing.Point(455, 121);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(67, 20);
            this.lblMonto.TabIndex = 22;
            this.lblMonto.Text = "Monto $";
            // 
            // txtMonto
            // 
            this.txtMonto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMonto.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMonto.HintForeColor = System.Drawing.Color.Empty;
            this.txtMonto.HintText = "";
            this.txtMonto.isPassword = false;
            this.txtMonto.LineFocusedColor = System.Drawing.Color.SkyBlue;
            this.txtMonto.LineIdleColor = System.Drawing.Color.Teal;
            this.txtMonto.LineMouseHoverColor = System.Drawing.Color.SkyBlue;
            this.txtMonto.LineThickness = 4;
            this.txtMonto.Location = new System.Drawing.Point(518, 108);
            this.txtMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(66, 33);
            this.txtMonto.TabIndex = 21;
            this.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Black;
            this.lblAlumno.Location = new System.Drawing.Point(454, 35);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(94, 29);
            this.lblAlumno.TabIndex = 20;
            this.lblAlumno.Text = "Alumno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Teal;
            this.lblNombre.Location = new System.Drawing.Point(559, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(296, 24);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre(s) Apellido P. Apellido M.";
            // 
            // lblNroControl
            // 
            this.lblNroControl.AutoSize = true;
            this.lblNroControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroControl.ForeColor = System.Drawing.Color.Teal;
            this.lblNroControl.Location = new System.Drawing.Point(455, 75);
            this.lblNroControl.Name = "lblNroControl";
            this.lblNroControl.Size = new System.Drawing.Size(98, 24);
            this.lblNroControl.TabIndex = 18;
            this.lblNroControl.Text = "19100000";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(377, 40);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(71, 180);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 17;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.Color.Transparent;
            this.btnEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuela.Image")));
            this.btnEscuela.ImageActive = null;
            this.btnEscuela.Location = new System.Drawing.Point(157, 54);
            this.btnEscuela.Name = "btnEscuela";
            this.btnEscuela.Size = new System.Drawing.Size(82, 65);
            this.btnEscuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEscuela.TabIndex = 16;
            this.btnEscuela.TabStop = false;
            this.btnEscuela.Zoom = 10;
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEscuela.Location = new System.Drawing.Point(158, 122);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(82, 25);
            this.lblEscuela.TabIndex = 15;
            this.lblEscuela.Text = "Escuela";
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(41, 166);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.Teal;
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(319, 39);
            this.cbEscuelas.TabIndex = 14;
            this.cbEscuelas.onItemSelected += new System.EventHandler(this.cbEscuelas_onItemSelected);
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
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(1288, 347);
            this.dgvAlumnos.TabIndex = 20;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            // 
            // Mensualidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.bunifuCards2);
            this.Name = "Mensualidades";
            this.Size = new System.Drawing.Size(1342, 670);
            this.Load += new System.EventHandler(this.Mensualidades_Load);
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFiltro)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblfiltrar;
        private Bunifu.Framework.UI.BunifuImageButton imgFiltro;
        private Bunifu.Framework.UI.BunifuCheckbox chkCorreo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroNoCtrl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFiltroNombre;
        private Bunifu.Framework.UI.BunifuCheckbox chkNombre;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEscuela;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAlumno;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNroControl;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMonto;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMonto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMetodoPago;
        private Bunifu.Framework.UI.BunifuDropdown cbMetodoPago;
        private Bunifu.Framework.UI.BunifuFlatButton btnAgregado;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistroPago;
        private Bunifu.Framework.UI.BunifuDatepicker dtFechaPago;
        private System.Windows.Forms.ToolTip toolTip1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaPago;
        private Bunifu.Framework.UI.BunifuCustomLabel lblMesAPagar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNota;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNota;
        private Bunifu.Framework.UI.BunifuCheckbox chkAño;
        private System.Windows.Forms.ComboBox cbAño;
    }
}
