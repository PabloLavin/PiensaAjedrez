namespace PiensaAjedrez.Pantallas
{
    partial class ArchivarForma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArchivarForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblIngresos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgIngresos = new Bunifu.Framework.UI.BunifuImageButton();
            this.dgvGastos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.gbClasificar = new System.Windows.Forms.GroupBox();
            this.btnArchivar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).BeginInit();
            this.gbClasificar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngresos.Location = new System.Drawing.Point(103, 45);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(224, 33);
            this.lblIngresos.TabIndex = 24;
            this.lblIngresos.Text = "Archivar Gastos";
            // 
            // imgIngresos
            // 
            this.imgIngresos.BackColor = System.Drawing.Color.Transparent;
            this.imgIngresos.Image = ((System.Drawing.Image)(resources.GetObject("imgIngresos.Image")));
            this.imgIngresos.ImageActive = ((System.Drawing.Image)(resources.GetObject("imgIngresos.ImageActive")));
            this.imgIngresos.Location = new System.Drawing.Point(25, 28);
            this.imgIngresos.Name = "imgIngresos";
            this.imgIngresos.Size = new System.Drawing.Size(72, 64);
            this.imgIngresos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIngresos.TabIndex = 23;
            this.imgIngresos.TabStop = false;
            this.imgIngresos.Zoom = 10;
            // 
            // dgvGastos
            // 
            this.dgvGastos.AllowUserToAddRows = false;
            this.dgvGastos.AllowUserToDeleteRows = false;
            this.dgvGastos.AllowUserToResizeColumns = false;
            this.dgvGastos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGastos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGastos.BackgroundColor = System.Drawing.Color.White;
            this.dgvGastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGastos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGastos.DoubleBuffered = true;
            this.dgvGastos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvGastos.EnableHeadersVisualStyles = false;
            this.dgvGastos.GridColor = System.Drawing.Color.Black;
            this.dgvGastos.HeaderBgColor = System.Drawing.Color.Teal;
            this.dgvGastos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvGastos.Location = new System.Drawing.Point(25, 149);
            this.dgvGastos.Name = "dgvGastos";
            this.dgvGastos.ReadOnly = true;
            this.dgvGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGastos.RowHeadersVisible = false;
            this.dgvGastos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvGastos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGastos.RowTemplate.Height = 25;
            this.dgvGastos.RowTemplate.ReadOnly = true;
            this.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGastos.Size = new System.Drawing.Size(682, 302);
            this.dgvGastos.TabIndex = 25;
            // 
            // gbClasificar
            // 
            this.gbClasificar.Controls.Add(this.btnArchivar);
            this.gbClasificar.Controls.Add(this.txtNombre);
            this.gbClasificar.Controls.Add(this.bunifuCustomLabel1);
            this.gbClasificar.Location = new System.Drawing.Point(373, 40);
            this.gbClasificar.Name = "gbClasificar";
            this.gbClasificar.Size = new System.Drawing.Size(334, 100);
            this.gbClasificar.TabIndex = 26;
            this.gbClasificar.TabStop = false;
            // 
            // btnArchivar
            // 
            this.btnArchivar.Activecolor = System.Drawing.Color.Teal;
            this.btnArchivar.BackColor = System.Drawing.Color.Teal;
            this.btnArchivar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnArchivar.BorderRadius = 0;
            this.btnArchivar.ButtonText = "Archivar";
            this.btnArchivar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArchivar.DisabledColor = System.Drawing.Color.Gray;
            this.btnArchivar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnArchivar.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnArchivar.Iconimage")));
            this.btnArchivar.Iconimage_right = null;
            this.btnArchivar.Iconimage_right_Selected = null;
            this.btnArchivar.Iconimage_Selected = null;
            this.btnArchivar.IconMarginLeft = 0;
            this.btnArchivar.IconMarginRight = 0;
            this.btnArchivar.IconRightVisible = true;
            this.btnArchivar.IconRightZoom = 0D;
            this.btnArchivar.IconVisible = true;
            this.btnArchivar.IconZoom = 90D;
            this.btnArchivar.IsTab = false;
            this.btnArchivar.Location = new System.Drawing.Point(217, 37);
            this.btnArchivar.Name = "btnArchivar";
            this.btnArchivar.Normalcolor = System.Drawing.Color.Teal;
            this.btnArchivar.OnHovercolor = System.Drawing.Color.DarkSlateGray;
            this.btnArchivar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnArchivar.selected = false;
            this.btnArchivar.Size = new System.Drawing.Size(104, 31);
            this.btnArchivar.TabIndex = 27;
            this.btnArchivar.Text = "Archivar";
            this.btnArchivar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArchivar.Textcolor = System.Drawing.Color.White;
            this.btnArchivar.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchivar.Click += new System.EventHandler(this.BtnArchivar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(10, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(190, 22);
            this.txtNombre.TabIndex = 26;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 16);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(194, 40);
            this.bunifuCustomLabel1.TabIndex = 25;
            this.bunifuCustomLabel1.Text = "Asigna un nombre a estos\r\ngastos:";
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveBorderThickness = 1;
            this.btnSalir.ActiveCornerRadius = 20;
            this.btnSalir.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.btnSalir.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 20;
            this.btnSalir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.IdleForecolor = System.Drawing.Color.Firebrick;
            this.btnSalir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(641, 2);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 43);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // ArchivarForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(732, 469);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbClasificar);
            this.Controls.Add(this.dgvGastos);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.imgIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArchivarForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Archivar";
            this.Load += new System.EventHandler(this.ArchivarForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastos)).EndInit();
            this.gbClasificar.ResumeLayout(false);
            this.gbClasificar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblIngresos;
        private Bunifu.Framework.UI.BunifuImageButton imgIngresos;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvGastos;
        private System.Windows.Forms.GroupBox gbClasificar;
        private System.Windows.Forms.TextBox txtNombre;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnArchivar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
    }
}