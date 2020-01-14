namespace PiensaAjedrez
{
    partial class IngresosForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IngresosForma));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEscuela = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cbEscuelas = new Bunifu.Framework.UI.BunifuDropdown();
            this.imgIngresos = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblIngresos = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.dgvIngresos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscuela
            // 
            this.lblEscuela.AutoSize = true;
            this.lblEscuela.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblEscuela.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEscuela.Location = new System.Drawing.Point(271, 45);
            this.lblEscuela.Name = "lblEscuela";
            this.lblEscuela.Size = new System.Drawing.Size(82, 25);
            this.lblEscuela.TabIndex = 18;
            this.lblEscuela.Text = "Escuela";
            // 
            // cbEscuelas
            // 
            this.cbEscuelas.BackColor = System.Drawing.Color.Transparent;
            this.cbEscuelas.BorderRadius = 3;
            this.cbEscuelas.DisabledColor = System.Drawing.Color.Gray;
            this.cbEscuelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscuelas.ForeColor = System.Drawing.Color.White;
            this.cbEscuelas.Items = new string[0];
            this.cbEscuelas.Location = new System.Drawing.Point(360, 39);
            this.cbEscuelas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbEscuelas.Name = "cbEscuelas";
            this.cbEscuelas.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.cbEscuelas.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(157)))), ((int)(((byte)(80)))));
            this.cbEscuelas.selectedIndex = -1;
            this.cbEscuelas.Size = new System.Drawing.Size(313, 39);
            this.cbEscuelas.TabIndex = 17;
            this.cbEscuelas.onItemSelected += new System.EventHandler(this.CbEscuelas_onItemSelected);
            // 
            // imgIngresos
            // 
            this.imgIngresos.BackColor = System.Drawing.Color.Transparent;
            this.imgIngresos.Image = ((System.Drawing.Image)(resources.GetObject("imgIngresos.Image")));
            this.imgIngresos.ImageActive = ((System.Drawing.Image)(resources.GetObject("imgIngresos.ImageActive")));
            this.imgIngresos.Location = new System.Drawing.Point(22, 29);
            this.imgIngresos.Name = "imgIngresos";
            this.imgIngresos.Size = new System.Drawing.Size(46, 43);
            this.imgIngresos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIngresos.TabIndex = 21;
            this.imgIngresos.TabStop = false;
            this.imgIngresos.Zoom = 10;
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngresos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblIngresos.Location = new System.Drawing.Point(84, 26);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(181, 66);
            this.lblIngresos.TabIndex = 22;
            this.lblIngresos.Text = "Ingresos   |\r\nCurso Activo";
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
            this.btnSalir.Location = new System.Drawing.Point(695, 39);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(89, 43);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // dgvIngresos
            // 
            this.dgvIngresos.AllowUserToAddRows = false;
            this.dgvIngresos.AllowUserToDeleteRows = false;
            this.dgvIngresos.AllowUserToResizeColumns = false;
            this.dgvIngresos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvIngresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIngresos.BackgroundColor = System.Drawing.Color.White;
            this.dgvIngresos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvIngresos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIngresos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvIngresos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIngresos.DoubleBuffered = true;
            this.dgvIngresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvIngresos.EnableHeadersVisualStyles = false;
            this.dgvIngresos.GridColor = System.Drawing.Color.Black;
            this.dgvIngresos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dgvIngresos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvIngresos.Location = new System.Drawing.Point(22, 94);
            this.dgvIngresos.Name = "dgvIngresos";
            this.dgvIngresos.ReadOnly = true;
            this.dgvIngresos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvIngresos.RowHeadersVisible = false;
            this.dgvIngresos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvIngresos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvIngresos.RowTemplate.Height = 25;
            this.dgvIngresos.RowTemplate.ReadOnly = true;
            this.dgvIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIngresos.Size = new System.Drawing.Size(762, 344);
            this.dgvIngresos.TabIndex = 24;
            // 
            // IngresosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(809, 467);
            this.Controls.Add(this.dgvIngresos);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblIngresos);
            this.Controls.Add(this.imgIngresos);
            this.Controls.Add(this.lblEscuela);
            this.Controls.Add(this.cbEscuelas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngresosForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngresosForma";
            this.Load += new System.EventHandler(this.IngresosForma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIngresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel lblEscuela;
        private Bunifu.Framework.UI.BunifuDropdown cbEscuelas;
        private Bunifu.Framework.UI.BunifuImageButton imgIngresos;
        private Bunifu.Framework.UI.BunifuCustomLabel lblIngresos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvIngresos;
    }
}