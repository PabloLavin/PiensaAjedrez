namespace PiensaAjedrez
{
    partial class FormMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensaje));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEncabezado = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.btnImagen = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeclinar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmHora = new System.Windows.Forms.DateTimePicker();
            this.btnRecordar = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.btnImagen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(-3, 13);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(460, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "___________________________________________________________________________-";
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEncabezado.Location = new System.Drawing.Point(14, 5);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(101, 18);
            this.lblEncabezado.TabIndex = 2;
            this.lblEncabezado.Text = "Encabezado";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMensaje.Location = new System.Drawing.Point(41, 59);
            this.lblMensaje.MaximumSize = new System.Drawing.Size(240, 217);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(45, 64);
            this.lblMensaje.TabIndex = 12;
            this.lblMensaje.Text = "label1\r\n-\r\n-\r\n-";
            // 
            // btnImagen
            // 
            this.btnImagen.BackColor = System.Drawing.Color.Transparent;
            this.btnImagen.Enabled = false;
            this.btnImagen.Image = ((System.Drawing.Image)(resources.GetObject("btnImagen.Image")));
            this.btnImagen.ImageActive = null;
            this.btnImagen.Location = new System.Drawing.Point(290, 61);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(64, 64);
            this.btnImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnImagen.TabIndex = 13;
            this.btnImagen.TabStop = false;
            this.btnImagen.Zoom = 10;
            // 
            // btnAceptar
            // 
            this.btnAceptar.ActiveBorderThickness = 1;
            this.btnAceptar.ActiveCornerRadius = 20;
            this.btnAceptar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.btnAceptar.ActiveForecolor = System.Drawing.Color.White;
            this.btnAceptar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(112)))), ((int)(((byte)(8)))));
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnAceptar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAceptar.BackgroundImage")));
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAceptar.IdleBorderThickness = 1;
            this.btnAceptar.IdleCornerRadius = 20;
            this.btnAceptar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(162)))), ((int)(((byte)(58)))));
            this.btnAceptar.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnAceptar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(162)))), ((int)(((byte)(58)))));
            this.btnAceptar.Location = new System.Drawing.Point(44, 119);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 14;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnDeclinar
            // 
            this.btnDeclinar.ActiveBorderThickness = 1;
            this.btnDeclinar.ActiveCornerRadius = 20;
            this.btnDeclinar.ActiveFillColor = System.Drawing.Color.Firebrick;
            this.btnDeclinar.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeclinar.ActiveLineColor = System.Drawing.Color.Firebrick;
            this.btnDeclinar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnDeclinar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeclinar.BackgroundImage")));
            this.btnDeclinar.ButtonText = "No";
            this.btnDeclinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeclinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclinar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeclinar.IdleBorderThickness = 1;
            this.btnDeclinar.IdleCornerRadius = 20;
            this.btnDeclinar.IdleFillColor = System.Drawing.Color.IndianRed;
            this.btnDeclinar.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnDeclinar.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnDeclinar.Location = new System.Drawing.Point(164, 119);
            this.btnDeclinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeclinar.Name = "btnDeclinar";
            this.btnDeclinar.Size = new System.Drawing.Size(83, 31);
            this.btnDeclinar.TabIndex = 15;
            this.btnDeclinar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeclinar.Click += new System.EventHandler(this.BtnDeclinar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmHora);
            this.groupBox1.Location = new System.Drawing.Point(0, -6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 168);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // dtmHora
            // 
            this.dtmHora.CustomFormat = "HH:MM:SS";
            this.dtmHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtmHora.Location = new System.Drawing.Point(58, 94);
            this.dtmHora.Name = "dtmHora";
            this.dtmHora.ShowUpDown = true;
            this.dtmHora.Size = new System.Drawing.Size(89, 20);
            this.dtmHora.TabIndex = 1;
            this.dtmHora.Value = new System.DateTime(2019, 6, 11, 15, 53, 39, 0);
            this.dtmHora.Visible = false;
            // 
            // btnRecordar
            // 
            this.btnRecordar.ActiveBorderThickness = 1;
            this.btnRecordar.ActiveCornerRadius = 20;
            this.btnRecordar.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.btnRecordar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRecordar.ActiveLineColor = System.Drawing.Color.RoyalBlue;
            this.btnRecordar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRecordar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecordar.BackgroundImage")));
            this.btnRecordar.ButtonText = "Recordar mas tarde";
            this.btnRecordar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecordar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecordar.IdleBorderThickness = 1;
            this.btnRecordar.IdleCornerRadius = 20;
            this.btnRecordar.IdleFillColor = System.Drawing.Color.SlateGray;
            this.btnRecordar.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnRecordar.IdleLineColor = System.Drawing.Color.SlateGray;
            this.btnRecordar.Location = new System.Drawing.Point(77, 150);
            this.btnRecordar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordar.Name = "btnRecordar";
            this.btnRecordar.Size = new System.Drawing.Size(147, 31);
            this.btnRecordar.TabIndex = 52;
            this.btnRecordar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRecordar.Visible = false;
            this.btnRecordar.Click += new System.EventHandler(this.BtnRecordar_Click);
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(383, 163);
            this.Controls.Add(this.btnRecordar);
            this.Controls.Add(this.btnDeclinar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(691, 235);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMensaje";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnImagen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEncabezado;
        private System.Windows.Forms.Label lblMensaje;
        private Bunifu.Framework.UI.BunifuImageButton btnImagen;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeclinar;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRecordar;
        private System.Windows.Forms.DateTimePicker dtmHora;
    }
}