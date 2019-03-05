namespace PiensaAjedrez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Escuelas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.lblNombreColegio = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombreColegio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAgregarColegio = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.btnAgregarCurso = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmInicioCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.lblInicioCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblFinCurso = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtmFinCurso = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dgvEscuelas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards1.SuspendLayout();
            this.bunifuCards2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Teal;
            this.bunifuCards1.Controls.Add(this.btnAgregarColegio);
            this.bunifuCards1.Controls.Add(this.lblColegios);
            this.bunifuCards1.Controls.Add(this.txtNombreColegio);
            this.bunifuCards1.Controls.Add(this.lblNombreColegio);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(25, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(622, 272);
            this.bunifuCards1.TabIndex = 0;
            // 
            // lblNombreColegio
            // 
            this.lblNombreColegio.AutoSize = true;
            this.lblNombreColegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNombreColegio.Location = new System.Drawing.Point(15, 135);
            this.lblNombreColegio.Name = "lblNombreColegio";
            this.lblNombreColegio.Size = new System.Drawing.Size(81, 25);
            this.lblNombreColegio.TabIndex = 1;
            this.lblNombreColegio.Text = "Nombre";
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
            this.txtNombreColegio.Location = new System.Drawing.Point(115, 121);
            this.txtNombreColegio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombreColegio.Name = "txtNombreColegio";
            this.txtNombreColegio.Size = new System.Drawing.Size(465, 39);
            this.txtNombreColegio.TabIndex = 2;
            this.txtNombreColegio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnAgregarColegio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarColegio.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarColegio.IdleBorderThickness = 1;
            this.btnAgregarColegio.IdleCornerRadius = 20;
            this.btnAgregarColegio.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarColegio.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarColegio.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarColegio.Location = new System.Drawing.Point(410, 211);
            this.btnAgregarColegio.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarColegio.Name = "btnAgregarColegio";
            this.btnAgregarColegio.Size = new System.Drawing.Size(181, 41);
            this.btnAgregarColegio.TabIndex = 4;
            this.btnAgregarColegio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
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
            this.bunifuCards2.Size = new System.Drawing.Size(631, 272);
            this.bunifuCards2.TabIndex = 5;
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
            this.btnAgregarCurso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCurso.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAgregarCurso.IdleBorderThickness = 1;
            this.btnAgregarCurso.IdleCornerRadius = 20;
            this.btnAgregarCurso.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarCurso.IdleForecolor = System.Drawing.Color.White;
            this.btnAgregarCurso.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.btnAgregarCurso.Location = new System.Drawing.Point(431, 211);
            this.btnAgregarCurso.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregarCurso.Name = "btnAgregarCurso";
            this.btnAgregarCurso.Size = new System.Drawing.Size(181, 41);
            this.btnAgregarCurso.TabIndex = 4;
            this.btnAgregarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblCurso.ForeColor = System.Drawing.Color.Teal;
            this.lblCurso.Location = new System.Drawing.Point(15, 18);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(80, 25);
            this.lblCurso.TabIndex = 3;
            this.lblCurso.Text = "Cursos";
            // 
            // dtmInicioCurso
            // 
            this.dtmInicioCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.dtmInicioCurso.BorderRadius = 0;
            this.dtmInicioCurso.ForeColor = System.Drawing.Color.White;
            this.dtmInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmInicioCurso.FormatCustom = null;
            this.dtmInicioCurso.Location = new System.Drawing.Point(168, 71);
            this.dtmInicioCurso.Name = "dtmInicioCurso";
            this.dtmInicioCurso.Size = new System.Drawing.Size(303, 36);
            this.dtmInicioCurso.TabIndex = 5;
            this.dtmInicioCurso.Value = new System.DateTime(2019, 3, 5, 10, 54, 35, 360);
            // 
            // lblInicioCurso
            // 
            this.lblInicioCurso.AutoSize = true;
            this.lblInicioCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblInicioCurso.ForeColor = System.Drawing.Color.Black;
            this.lblInicioCurso.Location = new System.Drawing.Point(50, 60);
            this.lblInicioCurso.Name = "lblInicioCurso";
            this.lblInicioCurso.Size = new System.Drawing.Size(95, 50);
            this.lblInicioCurso.TabIndex = 6;
            this.lblInicioCurso.Text = "Inicio\r\nde curso\r\n";
            // 
            // lblFinCurso
            // 
            this.lblFinCurso.AutoSize = true;
            this.lblFinCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblFinCurso.ForeColor = System.Drawing.Color.Black;
            this.lblFinCurso.Location = new System.Drawing.Point(50, 148);
            this.lblFinCurso.Name = "lblFinCurso";
            this.lblFinCurso.Size = new System.Drawing.Size(95, 50);
            this.lblFinCurso.TabIndex = 8;
            this.lblFinCurso.Text = "Fin\r\nde curso";
            // 
            // dtmFinCurso
            // 
            this.dtmFinCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.dtmFinCurso.BorderRadius = 0;
            this.dtmFinCurso.ForeColor = System.Drawing.Color.White;
            this.dtmFinCurso.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtmFinCurso.FormatCustom = null;
            this.dtmFinCurso.Location = new System.Drawing.Point(168, 159);
            this.dtmFinCurso.Name = "dtmFinCurso";
            this.dtmFinCurso.Size = new System.Drawing.Size(303, 36);
            this.dtmFinCurso.TabIndex = 7;
            this.dtmFinCurso.Value = new System.DateTime(2019, 3, 5, 10, 54, 35, 360);
            // 
            // dgvEscuelas
            // 
            this.dgvEscuelas.AllowUserToAddRows = false;
            this.dgvEscuelas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvEscuelas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvEscuelas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvEscuelas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEscuelas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEscuelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscuelas.DoubleBuffered = true;
            this.dgvEscuelas.EnableHeadersVisualStyles = false;
            this.dgvEscuelas.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvEscuelas.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvEscuelas.Location = new System.Drawing.Point(25, 306);
            this.dgvEscuelas.Name = "dgvEscuelas";
            this.dgvEscuelas.ReadOnly = true;
            this.dgvEscuelas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEscuelas.Size = new System.Drawing.Size(622, 336);
            this.dgvEscuelas.TabIndex = 6;
            // 
            // bunifuCustomDataGrid1
            // 
            this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
            this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid1.DoubleBuffered = true;
            this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(680, 306);
            this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
            this.bunifuCustomDataGrid1.ReadOnly = true;
            this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(631, 336);
            this.bunifuCustomDataGrid1.TabIndex = 7;
            // 
            // Escuelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuCustomDataGrid1);
            this.Controls.Add(this.dgvEscuelas);
            this.Controls.Add(this.bunifuCards2);
            this.Controls.Add(this.bunifuCards1);
            this.Name = "Escuelas";
            this.Size = new System.Drawing.Size(1342, 670);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscuelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvEscuelas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
    }
}
