namespace PiensaAjedrez
{
    partial class Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbMetodoPago = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cboCursos = new Bunifu.Framework.UI.BunifuDropdown();
            this.CargarReporteActividades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarAsistencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarReporteMensualidades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarReporteInscripciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CargarTodosIngresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTipoReporte = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lblFinCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmFinCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblInicioCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmInicioCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.gpTipoGasto = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblTipoDeGasto = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkTipoGasto = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkFecha = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblGrupo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chkGrupo = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.cboGrupoGastos = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CargarEgresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            this.bunifuCards3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards1.Controls.Add(this.cbMetodoPago);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuCards1.Controls.Add(this.cboCursos);
            this.bunifuCards1.Controls.Add(this.CargarReporteActividades);
            this.bunifuCards1.Controls.Add(this.CargarAsistencias);
            this.bunifuCards1.Controls.Add(this.CargarReporteMensualidades);
            this.bunifuCards1.Controls.Add(this.CargarReporteInscripciones);
            this.bunifuCards1.Controls.Add(this.cbEscuelas);
            this.bunifuCards1.Controls.Add(this.lblCurso);
            this.bunifuCards1.Controls.Add(this.btnEscuela);
            this.bunifuCards1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards1.Controls.Add(this.CargarTodosIngresos);
            this.bunifuCards1.Controls.Add(this.lblColegios);
            this.bunifuCards1.Controls.Add(this.lblTipoReporte);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(150, 32);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(501, 528);
            this.bunifuCards1.TabIndex = 2;
            this.bunifuCards1.TabStop = true;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.cbMetodoPago.BorderRadius = 3;
            this.cbMetodoPago.DisabledColor = System.Drawing.Color.Gray;
            this.cbMetodoPago.ForeColor = System.Drawing.Color.White;
            this.cbMetodoPago.Items = new string[] {
        "Cualquiera",
        "Efectivo",
        "Deposito",
        "Beca"};
            this.cbMetodoPago.Location = new System.Drawing.Point(167, 274);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbMetodoPago.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbMetodoPago.selectedIndex = 0;
            this.cbMetodoPago.Size = new System.Drawing.Size(304, 35);
            this.cbMetodoPago.TabIndex = 18;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(45, 281);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(116, 18);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "Método de pago";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(44, 246);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(61, 24);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "Filtrar ";
            // 
            // cboCursos
            // 
            this.cboCursos.BackColor = System.Drawing.Color.Transparent;
            this.cboCursos.BorderRadius = 3;
            this.cboCursos.DisabledColor = System.Drawing.Color.Gray;
            this.cboCursos.ForeColor = System.Drawing.Color.White;
            this.cboCursos.Items = new string[0];
            this.cboCursos.Location = new System.Drawing.Point(167, 204);
            this.cboCursos.Name = "cboCursos";
            this.cboCursos.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cboCursos.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cboCursos.selectedIndex = -1;
            this.cboCursos.Size = new System.Drawing.Size(304, 35);
            this.cboCursos.TabIndex = 9;
            // 
            // CargarReporteActividades
            // 
            this.CargarReporteActividades.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteActividades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteActividades.BorderRadius = 7;
            this.CargarReporteActividades.ButtonText = "Actividades ";
            this.CargarReporteActividades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarReporteActividades.DisabledColor = System.Drawing.Color.Gray;
            this.CargarReporteActividades.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarReporteActividades.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarReporteActividades.Iconimage")));
            this.CargarReporteActividades.Iconimage_right = null;
            this.CargarReporteActividades.Iconimage_right_Selected = null;
            this.CargarReporteActividades.Iconimage_Selected = null;
            this.CargarReporteActividades.IconMarginLeft = 0;
            this.CargarReporteActividades.IconMarginRight = 0;
            this.CargarReporteActividades.IconRightVisible = false;
            this.CargarReporteActividades.IconRightZoom = 0D;
            this.CargarReporteActividades.IconVisible = false;
            this.CargarReporteActividades.IconZoom = 90D;
            this.CargarReporteActividades.IsTab = false;
            this.CargarReporteActividades.Location = new System.Drawing.Point(321, 416);
            this.CargarReporteActividades.Name = "CargarReporteActividades";
            this.CargarReporteActividades.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteActividades.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarReporteActividades.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteActividades.selected = false;
            this.CargarReporteActividades.Size = new System.Drawing.Size(115, 40);
            this.CargarReporteActividades.TabIndex = 15;
            this.CargarReporteActividades.Text = "Actividades ";
            this.CargarReporteActividades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteActividades.Textcolor = System.Drawing.Color.White;
            this.CargarReporteActividades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarReporteActividades.Click += new System.EventHandler(this.CargarReporteActividades_Click);
            // 
            // CargarAsistencias
            // 
            this.CargarAsistencias.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarAsistencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarAsistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarAsistencias.BorderRadius = 7;
            this.CargarAsistencias.ButtonText = "Asistencias ";
            this.CargarAsistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarAsistencias.DisabledColor = System.Drawing.Color.Gray;
            this.CargarAsistencias.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarAsistencias.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarAsistencias.Iconimage")));
            this.CargarAsistencias.Iconimage_right = null;
            this.CargarAsistencias.Iconimage_right_Selected = null;
            this.CargarAsistencias.Iconimage_Selected = null;
            this.CargarAsistencias.IconMarginLeft = 0;
            this.CargarAsistencias.IconMarginRight = 0;
            this.CargarAsistencias.IconRightVisible = false;
            this.CargarAsistencias.IconRightZoom = 0D;
            this.CargarAsistencias.IconVisible = false;
            this.CargarAsistencias.IconZoom = 90D;
            this.CargarAsistencias.IsTab = false;
            this.CargarAsistencias.Location = new System.Drawing.Point(71, 468);
            this.CargarAsistencias.Name = "CargarAsistencias";
            this.CargarAsistencias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarAsistencias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarAsistencias.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarAsistencias.selected = false;
            this.CargarAsistencias.Size = new System.Drawing.Size(364, 40);
            this.CargarAsistencias.TabIndex = 12;
            this.CargarAsistencias.Text = "Asistencias ";
            this.CargarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarAsistencias.Textcolor = System.Drawing.Color.White;
            this.CargarAsistencias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarAsistencias.Click += new System.EventHandler(this.CargarAsistencias_Click);
            // 
            // CargarReporteMensualidades
            // 
            this.CargarReporteMensualidades.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteMensualidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteMensualidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteMensualidades.BorderRadius = 7;
            this.CargarReporteMensualidades.ButtonText = "Mensualidades";
            this.CargarReporteMensualidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarReporteMensualidades.DisabledColor = System.Drawing.Color.Gray;
            this.CargarReporteMensualidades.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarReporteMensualidades.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarReporteMensualidades.Iconimage")));
            this.CargarReporteMensualidades.Iconimage_right = null;
            this.CargarReporteMensualidades.Iconimage_right_Selected = null;
            this.CargarReporteMensualidades.Iconimage_Selected = null;
            this.CargarReporteMensualidades.IconMarginLeft = 0;
            this.CargarReporteMensualidades.IconMarginRight = 0;
            this.CargarReporteMensualidades.IconRightVisible = false;
            this.CargarReporteMensualidades.IconRightZoom = 0D;
            this.CargarReporteMensualidades.IconVisible = false;
            this.CargarReporteMensualidades.IconZoom = 90D;
            this.CargarReporteMensualidades.IsTab = false;
            this.CargarReporteMensualidades.Location = new System.Drawing.Point(195, 416);
            this.CargarReporteMensualidades.Name = "CargarReporteMensualidades";
            this.CargarReporteMensualidades.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteMensualidades.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarReporteMensualidades.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteMensualidades.selected = false;
            this.CargarReporteMensualidades.Size = new System.Drawing.Size(116, 40);
            this.CargarReporteMensualidades.TabIndex = 13;
            this.CargarReporteMensualidades.Text = "Mensualidades";
            this.CargarReporteMensualidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteMensualidades.Textcolor = System.Drawing.Color.White;
            this.CargarReporteMensualidades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarReporteMensualidades.Click += new System.EventHandler(this.CargarReporteMensualidades_Click);
            // 
            // CargarReporteInscripciones
            // 
            this.CargarReporteInscripciones.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteInscripciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteInscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteInscripciones.BorderRadius = 7;
            this.CargarReporteInscripciones.ButtonText = "Inscripciones";
            this.CargarReporteInscripciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarReporteInscripciones.DisabledColor = System.Drawing.Color.Gray;
            this.CargarReporteInscripciones.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarReporteInscripciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarReporteInscripciones.Iconimage")));
            this.CargarReporteInscripciones.Iconimage_right = null;
            this.CargarReporteInscripciones.Iconimage_right_Selected = null;
            this.CargarReporteInscripciones.Iconimage_Selected = null;
            this.CargarReporteInscripciones.IconMarginLeft = 0;
            this.CargarReporteInscripciones.IconMarginRight = 0;
            this.CargarReporteInscripciones.IconRightVisible = false;
            this.CargarReporteInscripciones.IconRightZoom = 0D;
            this.CargarReporteInscripciones.IconVisible = false;
            this.CargarReporteInscripciones.IconZoom = 90D;
            this.CargarReporteInscripciones.IsTab = false;
            this.CargarReporteInscripciones.Location = new System.Drawing.Point(71, 416);
            this.CargarReporteInscripciones.Name = "CargarReporteInscripciones";
            this.CargarReporteInscripciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarReporteInscripciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarReporteInscripciones.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteInscripciones.selected = false;
            this.CargarReporteInscripciones.Size = new System.Drawing.Size(116, 40);
            this.CargarReporteInscripciones.TabIndex = 14;
            this.CargarReporteInscripciones.Text = "Inscripciones";
            this.CargarReporteInscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteInscripciones.Textcolor = System.Drawing.Color.White;
            this.CargarReporteInscripciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarReporteInscripciones.Click += new System.EventHandler(this.CargarReporteInscripciones_Click);
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(73, 129);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(362, 35);
            this.cbEscuelas.TabIndex = 8;
            this.cbEscuelas.onItemSelected += new System.EventHandler(this.cbEscuelas_onItemSelected);
            this.cbEscuelas.Load += new System.EventHandler(this.cbEscuelas_Load);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.ForeColor = System.Drawing.Color.Black;
            this.lblCurso.Location = new System.Drawing.Point(45, 210);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(49, 18);
            this.lblCurso.TabIndex = 11;
            this.lblCurso.Text = "Curso";
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.Color.Transparent;
            this.btnEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuela.Image")));
            this.btnEscuela.ImageActive = null;
            this.btnEscuela.Location = new System.Drawing.Point(223, 57);
            this.btnEscuela.Name = "btnEscuela";
            this.btnEscuela.Size = new System.Drawing.Size(78, 60);
            this.btnEscuela.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEscuela.TabIndex = 5;
            this.btnEscuela.TabStop = false;
            this.btnEscuela.Zoom = 10;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(41, 171);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(173, 24);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Selección de curso";
            // 
            // CargarTodosIngresos
            // 
            this.CargarTodosIngresos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarTodosIngresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarTodosIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarTodosIngresos.BorderRadius = 7;
            this.CargarTodosIngresos.ButtonText = "Ingresos";
            this.CargarTodosIngresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarTodosIngresos.DisabledColor = System.Drawing.Color.Gray;
            this.CargarTodosIngresos.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarTodosIngresos.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarTodosIngresos.Iconimage")));
            this.CargarTodosIngresos.Iconimage_right = null;
            this.CargarTodosIngresos.Iconimage_right_Selected = null;
            this.CargarTodosIngresos.Iconimage_Selected = null;
            this.CargarTodosIngresos.IconMarginLeft = 0;
            this.CargarTodosIngresos.IconMarginRight = 0;
            this.CargarTodosIngresos.IconRightVisible = false;
            this.CargarTodosIngresos.IconRightZoom = 0D;
            this.CargarTodosIngresos.IconVisible = false;
            this.CargarTodosIngresos.IconZoom = 90D;
            this.CargarTodosIngresos.IsTab = false;
            this.CargarTodosIngresos.Location = new System.Drawing.Point(72, 367);
            this.CargarTodosIngresos.Name = "CargarTodosIngresos";
            this.CargarTodosIngresos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarTodosIngresos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarTodosIngresos.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarTodosIngresos.selected = false;
            this.CargarTodosIngresos.Size = new System.Drawing.Size(364, 40);
            this.CargarTodosIngresos.TabIndex = 10;
            this.CargarTodosIngresos.Text = "Ingresos";
            this.CargarTodosIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarTodosIngresos.Textcolor = System.Drawing.Color.White;
            this.CargarTodosIngresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarTodosIngresos.Click += new System.EventHandler(this.CargarTodosIngresos_Click);
            // 
            // lblColegios
            // 
            this.lblColegios.AutoSize = true;
            this.lblColegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblColegios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.lblColegios.Location = new System.Drawing.Point(17, 16);
            this.lblColegios.Name = "lblColegios";
            this.lblColegios.Size = new System.Drawing.Size(197, 24);
            this.lblColegios.TabIndex = 3;
            this.lblColegios.Text = "Selección de colegios";
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblTipoReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.lblTipoReporte.Location = new System.Drawing.Point(41, 335);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(252, 24);
            this.lblTipoReporte.TabIndex = 9;
            this.lblTipoReporte.Text = "Selección del tipo de reporte";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCards3.Controls.Add(this.lblFinCurso);
            this.bunifuCards3.Controls.Add(this.dtmFinCurso);
            this.bunifuCards3.Controls.Add(this.lblInicioCurso);
            this.bunifuCards3.Controls.Add(this.dtmInicioCurso);
            this.bunifuCards3.Controls.Add(this.gpTipoGasto);
            this.bunifuCards3.Controls.Add(this.lblTipoDeGasto);
            this.bunifuCards3.Controls.Add(this.chkTipoGasto);
            this.bunifuCards3.Controls.Add(this.lblFecha);
            this.bunifuCards3.Controls.Add(this.chkFecha);
            this.bunifuCards3.Controls.Add(this.lblGrupo);
            this.bunifuCards3.Controls.Add(this.chkGrupo);
            this.bunifuCards3.Controls.Add(this.bunifuImageButton1);
            this.bunifuCards3.Controls.Add(this.cboGrupoGastos);
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards3.Controls.Add(this.CargarEgresos);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(694, 32);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(510, 528);
            this.bunifuCards3.TabIndex = 10;
            // 
            // lblFinCurso
            // 
            this.lblFinCurso.AutoSize = true;
            this.lblFinCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinCurso.ForeColor = System.Drawing.Color.Black;
            this.lblFinCurso.Location = new System.Drawing.Point(219, 279);
            this.lblFinCurso.Name = "lblFinCurso";
            this.lblFinCurso.Size = new System.Drawing.Size(32, 20);
            this.lblFinCurso.TabIndex = 31;
            this.lblFinCurso.Text = "Fin\r\n";
            this.lblFinCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtmFinCurso
            // 
            this.dtmFinCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dtmFinCurso.BorderRadius = 0;
            this.dtmFinCurso.ForeColor = System.Drawing.Color.White;
            this.dtmFinCurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmFinCurso.FormatCustom = "DD/MM/YY";
            this.dtmFinCurso.Location = new System.Drawing.Point(273, 274);
            this.dtmFinCurso.Name = "dtmFinCurso";
            this.dtmFinCurso.Size = new System.Drawing.Size(193, 29);
            this.dtmFinCurso.TabIndex = 29;
            this.dtmFinCurso.Value = new System.DateTime(2019, 3, 5, 10, 54, 35, 360);
            // 
            // lblInicioCurso
            // 
            this.lblInicioCurso.AutoSize = true;
            this.lblInicioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicioCurso.ForeColor = System.Drawing.Color.Black;
            this.lblInicioCurso.Location = new System.Drawing.Point(219, 220);
            this.lblInicioCurso.Name = "lblInicioCurso";
            this.lblInicioCurso.Size = new System.Drawing.Size(48, 20);
            this.lblInicioCurso.TabIndex = 30;
            this.lblInicioCurso.Text = "Inicio\r\n";
            this.lblInicioCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtmInicioCurso
            // 
            this.dtmInicioCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dtmInicioCurso.BorderRadius = 0;
            this.dtmInicioCurso.ForeColor = System.Drawing.Color.White;
            this.dtmInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmInicioCurso.FormatCustom = "DD/MM/YY";
            this.dtmInicioCurso.Location = new System.Drawing.Point(273, 215);
            this.dtmInicioCurso.Name = "dtmInicioCurso";
            this.dtmInicioCurso.Size = new System.Drawing.Size(193, 29);
            this.dtmInicioCurso.TabIndex = 28;
            this.dtmInicioCurso.Value = new System.DateTime(2019, 3, 5, 0, 0, 0, 0);
            // 
            // gpTipoGasto
            // 
            this.gpTipoGasto.BackColor = System.Drawing.Color.Transparent;
            this.gpTipoGasto.BorderRadius = 3;
            this.gpTipoGasto.DisabledColor = System.Drawing.Color.Gray;
            this.gpTipoGasto.ForeColor = System.Drawing.Color.White;
            this.gpTipoGasto.Items = new string[] {
        "Pagos a Colegios",
        "Gasto Adicional",
        "Pago a Maestros"};
            this.gpTipoGasto.Location = new System.Drawing.Point(223, 346);
            this.gpTipoGasto.Name = "gpTipoGasto";
            this.gpTipoGasto.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.gpTipoGasto.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.gpTipoGasto.selectedIndex = 0;
            this.gpTipoGasto.Size = new System.Drawing.Size(243, 35);
            this.gpTipoGasto.TabIndex = 27;
            // 
            // lblTipoDeGasto
            // 
            this.lblTipoDeGasto.AutoSize = true;
            this.lblTipoDeGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeGasto.ForeColor = System.Drawing.Color.Black;
            this.lblTipoDeGasto.Location = new System.Drawing.Point(103, 351);
            this.lblTipoDeGasto.Name = "lblTipoDeGasto";
            this.lblTipoDeGasto.Size = new System.Drawing.Size(98, 18);
            this.lblTipoDeGasto.TabIndex = 26;
            this.lblTipoDeGasto.Text = "Tipo de gasto";
            // 
            // chkTipoGasto
            // 
            this.chkTipoGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkTipoGasto.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkTipoGasto.Checked = true;
            this.chkTipoGasto.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkTipoGasto.ForeColor = System.Drawing.Color.White;
            this.chkTipoGasto.Location = new System.Drawing.Point(67, 351);
            this.chkTipoGasto.Name = "chkTipoGasto";
            this.chkTipoGasto.Size = new System.Drawing.Size(20, 20);
            this.chkTipoGasto.TabIndex = 25;
            this.chkTipoGasto.OnChange += new System.EventHandler(this.chkTipoGasto_OnChange);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(102, 246);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 18);
            this.lblFecha.TabIndex = 24;
            this.lblFecha.Text = "Fecha";
            // 
            // chkFecha
            // 
            this.chkFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkFecha.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkFecha.Checked = true;
            this.chkFecha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkFecha.ForeColor = System.Drawing.Color.White;
            this.chkFecha.Location = new System.Drawing.Point(67, 246);
            this.chkFecha.Name = "chkFecha";
            this.chkFecha.Size = new System.Drawing.Size(20, 20);
            this.chkFecha.TabIndex = 23;
            this.chkFecha.OnChange += new System.EventHandler(this.chkFecha_OnChange);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.ForeColor = System.Drawing.Color.Black;
            this.lblGrupo.Location = new System.Drawing.Point(102, 136);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(50, 18);
            this.lblGrupo.TabIndex = 22;
            this.lblGrupo.Text = "Grupo";
            // 
            // chkGrupo
            // 
            this.chkGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkGrupo.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(128)))), ((int)(((byte)(64)))));
            this.chkGrupo.Checked = true;
            this.chkGrupo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.chkGrupo.ForeColor = System.Drawing.Color.White;
            this.chkGrupo.Location = new System.Drawing.Point(67, 136);
            this.chkGrupo.Name = "chkGrupo";
            this.chkGrupo.Size = new System.Drawing.Size(20, 20);
            this.chkGrupo.TabIndex = 21;
            this.chkGrupo.OnChange += new System.EventHandler(this.chkGrupo_OnChange);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Enabled = false;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(244, 49);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(50, 50);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 20;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // cboGrupoGastos
            // 
            this.cboGrupoGastos.BackColor = System.Drawing.Color.Transparent;
            this.cboGrupoGastos.BorderRadius = 3;
            this.cboGrupoGastos.DisabledColor = System.Drawing.Color.Gray;
            this.cboGrupoGastos.ForeColor = System.Drawing.Color.White;
            this.cboGrupoGastos.Items = new string[0];
            this.cboGrupoGastos.Location = new System.Drawing.Point(223, 130);
            this.cboGrupoGastos.Name = "cboGrupoGastos";
            this.cboGrupoGastos.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cboGrupoGastos.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cboGrupoGastos.selectedIndex = -1;
            this.cboGrupoGastos.Size = new System.Drawing.Size(243, 35);
            this.cboGrupoGastos.TabIndex = 13;
            this.cboGrupoGastos.Load += new System.EventHandler(this.cboGrupoGastos_Load);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(180, 24);
            this.bunifuCustomLabel2.TabIndex = 12;
            this.bunifuCustomLabel2.Text = "Selección de gastos";
            // 
            // CargarEgresos
            // 
            this.CargarEgresos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarEgresos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarEgresos.BorderRadius = 7;
            this.CargarEgresos.ButtonText = "Gastos del grupo seleccionado";
            this.CargarEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarEgresos.DisabledColor = System.Drawing.Color.Gray;
            this.CargarEgresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.CargarEgresos.Iconcolor = System.Drawing.Color.Transparent;
            this.CargarEgresos.Iconimage = ((System.Drawing.Image)(resources.GetObject("CargarEgresos.Iconimage")));
            this.CargarEgresos.Iconimage_right = null;
            this.CargarEgresos.Iconimage_right_Selected = null;
            this.CargarEgresos.Iconimage_Selected = null;
            this.CargarEgresos.IconMarginLeft = 0;
            this.CargarEgresos.IconMarginRight = 0;
            this.CargarEgresos.IconRightVisible = false;
            this.CargarEgresos.IconRightZoom = 0D;
            this.CargarEgresos.IconVisible = false;
            this.CargarEgresos.IconZoom = 90D;
            this.CargarEgresos.IsTab = false;
            this.CargarEgresos.Location = new System.Drawing.Point(84, 464);
            this.CargarEgresos.Name = "CargarEgresos";
            this.CargarEgresos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.CargarEgresos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.CargarEgresos.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarEgresos.selected = false;
            this.CargarEgresos.Size = new System.Drawing.Size(364, 39);
            this.CargarEgresos.TabIndex = 11;
            this.CargarEgresos.Text = "Gastos del grupo seleccionado";
            this.CargarEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarEgresos.Textcolor = System.Drawing.Color.White;
            this.CargarEgresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.CargarEgresos.Click += new System.EventHandler(this.CargarEgresos_Click);
            // 
            // Reportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(1342, 615);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblColegios;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCurso;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuFlatButton CargarTodosIngresos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTipoReporte;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteActividades;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteInscripciones;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteMensualidades;
        private Bunifu.Framework.UI.BunifuFlatButton CargarAsistencias;
        private Bunifu.Framework.UI.BunifuFlatButton CargarEgresos;
        private Bunifu.Framework.UI.BunifuDropdown cboCursos;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuDropdown cboGrupoGastos;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTipoDeGasto;
        private Bunifu.Framework.UI.BunifuCheckbox chkTipoGasto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCheckbox chkFecha;
        private Bunifu.Framework.UI.BunifuCustomLabel lblGrupo;
        private Bunifu.Framework.UI.BunifuCheckbox chkGrupo;
        private Bunifu.Framework.UI.BunifuDropdown gpTipoGasto;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFinCurso;
        private Bunifu.Framework.UI.BunifuDatepicker dtmFinCurso;
        private Bunifu.Framework.UI.BunifuCustomLabel lblInicioCurso;
        private Bunifu.Framework.UI.BunifuDatepicker dtmInicioCurso;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDropdown cbMetodoPago;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
    }
}
