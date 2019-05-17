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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.btnEscuela = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblColegios = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuCards2 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCards3 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbFechas = new Bunifu.Framework.UI.BunifuDropdown();
            this.lblFecha = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMarcarTodos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDesmarcar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.bunifuCards2.SuspendLayout();
            this.bunifuCards3.SuspendLayout();
            this.SuspendLayout();
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
            this.bunifuCards1.Location = new System.Drawing.Point(17, 17);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(496, 180);
            this.bunifuCards1.TabIndex = 1;
            this.bunifuCards1.TabStop = true;
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(52, 122);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.Teal;
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(391, 35);
            this.cbEscuelas.TabIndex = 8;
            this.cbEscuelas.onItemSelected += new System.EventHandler(this.cbEscuelas_onItemSelected);
            // 
            // btnEscuela
            // 
            this.btnEscuela.BackColor = System.Drawing.Color.Transparent;
            this.btnEscuela.Image = ((System.Drawing.Image)(resources.GetObject("btnEscuela.Image")));
            this.btnEscuela.ImageActive = null;
            this.btnEscuela.Location = new System.Drawing.Point(205, 51);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
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
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(17, 214);
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
            this.dgvAlumnos.Size = new System.Drawing.Size(1308, 434);
            this.dgvAlumnos.TabIndex = 2;
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
         
            // 
            // bunifuCards2
            // 
            this.bunifuCards2.BackColor = System.Drawing.Color.White;
            this.bunifuCards2.BorderRadius = 5;
            this.bunifuCards2.BottomSahddow = true;
            this.bunifuCards2.color = System.Drawing.Color.Teal;
            this.bunifuCards2.Controls.Add(this.btnDesmarcar);
            this.bunifuCards2.Controls.Add(this.btnMarcarTodos);
            this.bunifuCards2.Controls.Add(this.lblFecha);
            this.bunifuCards2.Controls.Add(this.cbFechas);
            this.bunifuCards2.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuCards2.LeftSahddow = false;
            this.bunifuCards2.Location = new System.Drawing.Point(533, 17);
            this.bunifuCards2.Name = "bunifuCards2";
            this.bunifuCards2.RightSahddow = true;
            this.bunifuCards2.ShadowDepth = 20;
            this.bunifuCards2.Size = new System.Drawing.Size(496, 180);
            this.bunifuCards2.TabIndex = 9;
            this.bunifuCards2.TabStop = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Teal;
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
            this.bunifuCards3.color = System.Drawing.Color.Teal;
            this.bunifuCards3.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuCards3.LeftSahddow = false;
            this.bunifuCards3.Location = new System.Drawing.Point(1049, 17);
            this.bunifuCards3.Name = "bunifuCards3";
            this.bunifuCards3.RightSahddow = true;
            this.bunifuCards3.ShadowDepth = 20;
            this.bunifuCards3.Size = new System.Drawing.Size(276, 180);
            this.bunifuCards3.TabIndex = 9;
            this.bunifuCards3.TabStop = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Teal;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(15, 18);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(71, 25);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Filtros";
            // 
            // cbFechas
            // 
            this.cbFechas.BackColor = System.Drawing.Color.Transparent;
            this.cbFechas.BorderRadius = 3;
            this.cbFechas.DisabledColor = System.Drawing.Color.Gray;
            this.cbFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFechas.ForeColor = System.Drawing.Color.White;
            this.cbFechas.Items = new string[0];
            this.cbFechas.Location = new System.Drawing.Point(20, 102);
            this.cbFechas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFechas.Name = "cbFechas";
            this.cbFechas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(202)))), ((int)(((byte)(192)))));
            this.cbFechas.onHoverColor = System.Drawing.Color.Teal;
            this.cbFechas.selectedIndex = -1;
            this.cbFechas.Size = new System.Drawing.Size(296, 35);
            this.cbFechas.TabIndex = 9;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.Black;
            this.lblFecha.Location = new System.Drawing.Point(15, 69);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(301, 25);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Seleccione la fecha de asistencia";
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMarcarTodos.BackColor = System.Drawing.Color.Teal;
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
            this.btnMarcarTodos.Location = new System.Drawing.Point(332, 33);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Normalcolor = System.Drawing.Color.Teal;
            this.btnMarcarTodos.OnHovercolor = System.Drawing.Color.Teal;
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
            // btnDesmarcar
            // 
            this.btnDesmarcar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
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
            this.btnDesmarcar.Location = new System.Drawing.Point(332, 102);
            this.btnDesmarcar.Name = "btnDesmarcar";
            this.btnDesmarcar.Normalcolor = System.Drawing.Color.Firebrick;
            this.btnDesmarcar.OnHovercolor = System.Drawing.Color.Firebrick;
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
            this.Size = new System.Drawing.Size(1342, 670);
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEscuela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.bunifuCards2.ResumeLayout(false);
            this.bunifuCards2.PerformLayout();
            this.bunifuCards3.ResumeLayout(false);
            this.bunifuCards3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuImageButton btnEscuela;
        private Bunifu.Framework.UI.BunifuCustomLabel lblColegios;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
        private Bunifu.Framework.UI.BunifuCards bunifuCards2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblFecha;
        private Bunifu.Framework.UI.BunifuDropdown cbFechas;
        private Bunifu.Framework.UI.BunifuFlatButton btnMarcarTodos;
        private Bunifu.Framework.UI.BunifuFlatButton btnDesmarcar;
    }
}
