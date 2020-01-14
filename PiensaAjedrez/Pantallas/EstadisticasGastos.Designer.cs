namespace PiensaAjedrez
{
    partial class Cumpleaños
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cumpleaños));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblCumple = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvCumpleaneros = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleaneros)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ImageActive")));
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveBorderThickness = 1;
            this.btnSalir.ActiveCornerRadius = 20;
            this.btnSalir.ActiveFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.btnSalir.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            resources.ApplyResources(this.btnSalir, "btnSalir");
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 20;
            this.btnSalir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.IdleForecolor = System.Drawing.Color.Firebrick;
            this.btnSalir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // lblCumple
            // 
            resources.ApplyResources(this.lblCumple, "lblCumple");
            this.lblCumple.BackColor = System.Drawing.Color.Transparent;
            this.lblCumple.ForeColor = System.Drawing.Color.White;
            this.lblCumple.Name = "lblCumple";
            // 
            // dgvCumpleaneros
            // 
            this.dgvCumpleaneros.AllowUserToAddRows = false;
            this.dgvCumpleaneros.AllowUserToDeleteRows = false;
            this.dgvCumpleaneros.AllowUserToResizeColumns = false;
            this.dgvCumpleaneros.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCumpleaneros.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCumpleaneros.BackgroundColor = System.Drawing.Color.White;
            this.dgvCumpleaneros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCumpleaneros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCumpleaneros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCumpleaneros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.PaleTurquoise;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCumpleaneros.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCumpleaneros.DoubleBuffered = true;
            this.dgvCumpleaneros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvCumpleaneros.EnableHeadersVisualStyles = false;
            this.dgvCumpleaneros.GridColor = System.Drawing.Color.Black;
            this.dgvCumpleaneros.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(139)))), ((int)(((byte)(58)))));
            this.dgvCumpleaneros.HeaderForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.dgvCumpleaneros, "dgvCumpleaneros");
            this.dgvCumpleaneros.Name = "dgvCumpleaneros";
            this.dgvCumpleaneros.ReadOnly = true;
            this.dgvCumpleaneros.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCumpleaneros.RowHeadersVisible = false;
            this.dgvCumpleaneros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvCumpleaneros.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCumpleaneros.RowTemplate.Height = 25;
            this.dgvCumpleaneros.RowTemplate.ReadOnly = true;
            this.dgvCumpleaneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // Cumpleaños
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblCumple);
            this.Controls.Add(this.dgvCumpleaneros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cumpleaños";
            this.Load += new System.EventHandler(this.Cumpleaños_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCumpleaneros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private Bunifu.Framework.UI.BunifuCustomLabel lblCumple;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCumpleaneros;
    }
}
