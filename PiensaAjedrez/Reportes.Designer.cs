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
            this.panelReportes = new System.Windows.Forms.Panel();
            this.visorReportes = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.lblFechaFin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FechaFinal = new Bunifu.Framework.UI.BunifuDatepicker();
            this.FechaInicio = new Bunifu.Framework.UI.BunifuDatepicker();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.lblTipoReporte = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards4 = new Bunifu.Framework.UI.BunifuCards();
            this.lblEstadisticas = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CargarTodosIngresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarEgresos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarAsistencias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarReporteMensualidades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarReporteInscripciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CargarReporteActividades = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelReportes.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.bunifuCards4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReportes
            // 
            this.panelReportes.BackColor = System.Drawing.SystemColors.Control;
            this.panelReportes.Controls.Add(this.visorReportes);
            this.panelReportes.Location = new System.Drawing.Point(854, 23);
            this.panelReportes.Name = "panelReportes";
            this.panelReportes.Size = new System.Drawing.Size(439, 607);
            this.panelReportes.TabIndex = 0;
            // 
            // visorReportes
            // 
            this.visorReportes.ActiveViewIndex = -1;
            this.visorReportes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visorReportes.Cursor = System.Windows.Forms.Cursors.Default;
            this.visorReportes.DisplayBackgroundEdge = false;
            this.visorReportes.DisplayStatusBar = false;
            this.visorReportes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.visorReportes.Location = new System.Drawing.Point(0, 0);
            this.visorReportes.Name = "visorReportes";
            this.visorReportes.ShowCloseButton = false;
            this.visorReportes.ShowCopyButton = false;
            this.visorReportes.ShowLogo = false;
            this.visorReportes.Size = new System.Drawing.Size(439, 607);
            this.visorReportes.TabIndex = 0;
            this.visorReportes.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.cbEscuelas);
            this.bunifuCards1.Controls.Add(this.btnEscuela);
            this.bunifuCards1.Controls.Add(this.lblColegios);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(52, 23);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(334, 180);
            this.bunifuCards1.TabIndex = 2;
            this.bunifuCards1.TabStop = true;
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
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.Teal;
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(285, 35);
            this.cbEscuelas.TabIndex = 8;
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
            // lblColegios
            // 
            this.lblColegios.AutoSize = true;
            this.lblColegios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblColegios.ForeColor = System.Drawing.Color.Teal;
            this.lblColegios.Location = new System.Drawing.Point(15, 18);
            this.lblColegios.Name = "lblColegios";
            this.lblColegios.Size = new System.Drawing.Size(222, 25);
            this.lblColegios.TabIndex = 3;
            this.lblColegios.Text = "Selección de colegios";
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.lblFechaFin);
            this.bunifuCards2.Controls.Add(this.lblFecha);
            this.bunifuCards2.Controls.Add(this.FechaFinal);
            this.bunifuCards2.Controls.Add(this.FechaInicio);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(416, 23);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(397, 180);
            this.bunifuCards2.TabIndex = 9;
            this.bunifuCards2.TabStop = true;
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.Color.Black;
            this.lblFechaFin.Location = new System.Drawing.Point(25, 122);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(88, 18);
            this.lblFechaFin.TabIndex = 12;
            this.lblFechaFin.Text = "Fecha de fin";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(25, 68);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(107, 18);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha de inicio";
            // 
            // FechaFinal
            // 
            this.FechaFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.FechaFinal.BorderRadius = 3;
            this.FechaFinal.ForeColor = System.Drawing.Color.White;
            this.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaFinal.FormatCustom = null;
            this.FechaFinal.Location = new System.Drawing.Point(149, 116);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(221, 36);
            this.FechaFinal.TabIndex = 5;
            this.FechaFinal.Value = new System.DateTime(2019, 6, 20, 0, 30, 5, 136);
            // 
            // FechaInicio
            // 
            this.FechaInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.FechaInicio.BorderRadius = 3;
            this.FechaInicio.ForeColor = System.Drawing.Color.White;
            this.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaInicio.FormatCustom = null;
            this.FechaInicio.Location = new System.Drawing.Point(149, 62);
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.Size = new System.Drawing.Size(221, 36);
            this.FechaInicio.TabIndex = 4;
            this.FechaInicio.Value = new System.DateTime(2019, 6, 20, 0, 30, 1, 166);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(15, 18);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(206, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Selección de fechas";
            // 
            // bunifuCards3
            // 
            this.bunifuCards3.BackColor = System.Drawing.Color.White;
            this.bunifuCards3.BorderRadius = 5;
            this.bunifuCards3.BottomSahddow = true;
            this.bunifuCards3.color = System.Drawing.Color.Teal;
            this.bunifuCards3.Controls.Add(this.CargarReporteActividades);
            this.bunifuCards3.Controls.Add(this.CargarReporteInscripciones);
            this.bunifuCards3.Controls.Add(this.CargarReporteMensualidades);
            this.bunifuCards3.Controls.Add(this.CargarAsistencias);
            this.bunifuCards3.Controls.Add(this.CargarEgresos);
            this.bunifuCards3.Controls.Add(this.CargarTodosIngresos);
            this.bunifuCards3.Controls.Add(this.lblTipoReporte);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(54, 222);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(332, 408);
            this.bunifuCards3.TabIndex = 10;
            // 
            // lblTipoReporte
            // 
            this.lblTipoReporte.AutoSize = true;
            this.lblTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTipoReporte.ForeColor = System.Drawing.Color.Teal;
            this.lblTipoReporte.Location = new System.Drawing.Point(14, 20);
            this.lblTipoReporte.Name = "lblTipoReporte";
            this.lblTipoReporte.Size = new System.Drawing.Size(286, 25);
            this.lblTipoReporte.TabIndex = 9;
            this.lblTipoReporte.Text = "Selección del tipo de reporte";
            // 
            // bunifuCards4
            // 
            this.bunifuCards4.BackColor = System.Drawing.Color.White;
            this.bunifuCards4.BorderRadius = 5;
            this.bunifuCards4.BottomSahddow = true;
            this.bunifuCards4.color = System.Drawing.Color.Teal;
            this.bunifuCards4.Controls.Add(this.lblEstadisticas);
            this.bunifuCards4.LeftSahddow = false;
            this.bunifuCards4.Location = new System.Drawing.Point(416, 222);
            this.bunifuCards4.Name = "bunifuCards4";
            this.bunifuCards4.RightSahddow = true;
            this.bunifuCards4.ShadowDepth = 20;
            this.bunifuCards4.Size = new System.Drawing.Size(397, 408);
            this.bunifuCards4.TabIndex = 11;
            // 
            // lblEstadisticas
            // 
            this.lblEstadisticas.AutoSize = true;
            this.lblEstadisticas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblEstadisticas.ForeColor = System.Drawing.Color.Teal;
            this.lblEstadisticas.Location = new System.Drawing.Point(14, 20);
            this.lblEstadisticas.Name = "lblEstadisticas";
            this.lblEstadisticas.Size = new System.Drawing.Size(128, 25);
            this.lblEstadisticas.TabIndex = 9;
            this.lblEstadisticas.Text = "Estadísticas";
            // 
            // CargarTodosIngresos
            // 
            this.CargarTodosIngresos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarTodosIngresos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CargarTodosIngresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarTodosIngresos.BorderRadius = 5;
            this.CargarTodosIngresos.ButtonText = "Cargar reporte de ingresos";
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
            this.CargarTodosIngresos.IsTab = true;
            this.CargarTodosIngresos.Location = new System.Drawing.Point(43, 61);
            this.CargarTodosIngresos.Name = "CargarTodosIngresos";
            this.CargarTodosIngresos.Normalcolor = System.Drawing.Color.Teal;
            this.CargarTodosIngresos.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarTodosIngresos.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarTodosIngresos.selected = true;
            this.CargarTodosIngresos.Size = new System.Drawing.Size(241, 48);
            this.CargarTodosIngresos.TabIndex = 10;
            this.CargarTodosIngresos.Text = "Cargar reporte de ingresos";
            this.CargarTodosIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarTodosIngresos.Textcolor = System.Drawing.Color.White;
            this.CargarTodosIngresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CargarEgresos
            // 
            this.CargarEgresos.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarEgresos.BackColor = System.Drawing.Color.Teal;
            this.CargarEgresos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarEgresos.BorderRadius = 5;
            this.CargarEgresos.ButtonText = "Cargar reporte de egresos";
            this.CargarEgresos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CargarEgresos.DisabledColor = System.Drawing.Color.Gray;
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
            this.CargarEgresos.IsTab = true;
            this.CargarEgresos.Location = new System.Drawing.Point(43, 111);
            this.CargarEgresos.Name = "CargarEgresos";
            this.CargarEgresos.Normalcolor = System.Drawing.Color.Teal;
            this.CargarEgresos.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarEgresos.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarEgresos.selected = false;
            this.CargarEgresos.Size = new System.Drawing.Size(241, 48);
            this.CargarEgresos.TabIndex = 11;
            this.CargarEgresos.Text = "Cargar reporte de egresos";
            this.CargarEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarEgresos.Textcolor = System.Drawing.Color.White;
            this.CargarEgresos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CargarAsistencias
            // 
            this.CargarAsistencias.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarAsistencias.BackColor = System.Drawing.Color.Teal;
            this.CargarAsistencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarAsistencias.BorderRadius = 5;
            this.CargarAsistencias.ButtonText = "Cargar reporte de asistencias";
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
            this.CargarAsistencias.IsTab = true;
            this.CargarAsistencias.Location = new System.Drawing.Point(43, 336);
            this.CargarAsistencias.Name = "CargarAsistencias";
            this.CargarAsistencias.Normalcolor = System.Drawing.Color.Teal;
            this.CargarAsistencias.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarAsistencias.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarAsistencias.selected = false;
            this.CargarAsistencias.Size = new System.Drawing.Size(241, 48);
            this.CargarAsistencias.TabIndex = 12;
            this.CargarAsistencias.Text = "Cargar reporte de asistencias";
            this.CargarAsistencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarAsistencias.Textcolor = System.Drawing.Color.White;
            this.CargarAsistencias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CargarReporteMensualidades
            // 
            this.CargarReporteMensualidades.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteMensualidades.BackColor = System.Drawing.Color.Teal;
            this.CargarReporteMensualidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteMensualidades.BorderRadius = 5;
            this.CargarReporteMensualidades.ButtonText = "Cargar reporte de Mensualidades";
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
            this.CargarReporteMensualidades.IsTab = true;
            this.CargarReporteMensualidades.Location = new System.Drawing.Point(43, 225);
            this.CargarReporteMensualidades.Name = "CargarReporteMensualidades";
            this.CargarReporteMensualidades.Normalcolor = System.Drawing.Color.Teal;
            this.CargarReporteMensualidades.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarReporteMensualidades.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteMensualidades.selected = false;
            this.CargarReporteMensualidades.Size = new System.Drawing.Size(241, 48);
            this.CargarReporteMensualidades.TabIndex = 13;
            this.CargarReporteMensualidades.Text = "Cargar reporte de Mensualidades";
            this.CargarReporteMensualidades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteMensualidades.Textcolor = System.Drawing.Color.White;
            this.CargarReporteMensualidades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CargarReporteInscripciones
            // 
            this.CargarReporteInscripciones.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteInscripciones.BackColor = System.Drawing.Color.Teal;
            this.CargarReporteInscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteInscripciones.BorderRadius = 5;
            this.CargarReporteInscripciones.ButtonText = "Cargar reporte de Inscripciones";
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
            this.CargarReporteInscripciones.IsTab = true;
            this.CargarReporteInscripciones.Location = new System.Drawing.Point(43, 176);
            this.CargarReporteInscripciones.Name = "CargarReporteInscripciones";
            this.CargarReporteInscripciones.Normalcolor = System.Drawing.Color.Teal;
            this.CargarReporteInscripciones.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarReporteInscripciones.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteInscripciones.selected = false;
            this.CargarReporteInscripciones.Size = new System.Drawing.Size(241, 48);
            this.CargarReporteInscripciones.TabIndex = 14;
            this.CargarReporteInscripciones.Text = "Cargar reporte de Inscripciones";
            this.CargarReporteInscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteInscripciones.Textcolor = System.Drawing.Color.White;
            this.CargarReporteInscripciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // CargarReporteActividades
            // 
            this.CargarReporteActividades.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.CargarReporteActividades.BackColor = System.Drawing.Color.Teal;
            this.CargarReporteActividades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CargarReporteActividades.BorderRadius = 5;
            this.CargarReporteActividades.ButtonText = "Cargar reporte de Actividades";
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
            this.CargarReporteActividades.IsTab = true;
            this.CargarReporteActividades.Location = new System.Drawing.Point(43, 274);
            this.CargarReporteActividades.Name = "CargarReporteActividades";
            this.CargarReporteActividades.Normalcolor = System.Drawing.Color.Teal;
            this.CargarReporteActividades.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.CargarReporteActividades.OnHoverTextColor = System.Drawing.Color.White;
            this.CargarReporteActividades.selected = false;
            this.CargarReporteActividades.Size = new System.Drawing.Size(241, 48);
            this.CargarReporteActividades.TabIndex = 15;
            this.CargarReporteActividades.Text = "Cargar reporte de Actividades";
            this.CargarReporteActividades.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CargarReporteActividades.Textcolor = System.Drawing.Color.White;
            this.CargarReporteActividades.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Reportes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuCards4);
            this.Controls.Add(this.bunifuCards3);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.panelReportes);
            this.Name = "Reportes";
            this.Size = new System.Drawing.Size(1342, 670);
            this.panelReportes.ResumeLayout(false);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.bunifuCards4.ResumeLayout(false);
            this.bunifuCards4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReportes;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer visorReportes;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblColegios;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuDatepicker FechaFinal;
        private Bunifu.Framework.UI.BunifuDatepicker FechaInicio;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFechaFin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuFlatButton CargarTodosIngresos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTipoReporte;
        private Bunifu.Framework.UI.BunifuCards bunifuCards4;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEstadisticas;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteActividades;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteInscripciones;
        private Bunifu.Framework.UI.BunifuFlatButton CargarReporteMensualidades;
        private Bunifu.Framework.UI.BunifuFlatButton CargarAsistencias;
        private Bunifu.Framework.UI.BunifuFlatButton CargarEgresos;
    }
}
