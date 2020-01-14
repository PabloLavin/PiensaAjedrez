namespace PiensaAjedrez.Pantallas
{
    partial class ClaveSeguridad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaveSeguridad));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeclinar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeclinar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            this.btnDeclinar.ButtonText = "Cancelar";
            this.btnDeclinar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeclinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeclinar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeclinar.IdleBorderThickness = 1;
            this.btnDeclinar.IdleCornerRadius = 20;
            this.btnDeclinar.IdleFillColor = System.Drawing.Color.IndianRed;
            this.btnDeclinar.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnDeclinar.IdleLineColor = System.Drawing.Color.IndianRed;
            this.btnDeclinar.Location = new System.Drawing.Point(189, 122);
            this.btnDeclinar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeclinar.Name = "btnDeclinar";
            this.btnDeclinar.Size = new System.Drawing.Size(83, 31);
            this.btnDeclinar.TabIndex = 16;
            this.btnDeclinar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeclinar.Click += new System.EventHandler(this.BtnDeclinar_Click);
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
            this.btnAceptar.Location = new System.Drawing.Point(98, 122);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 31);
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(136, 75);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(100, 24);
            this.txtClave.TabIndex = 1;
            this.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(57, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca Clave de Seguridad";
            // 
            // ClaveSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(383, 163);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClaveSeguridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaveSeguridad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAceptar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeclinar;
    }
}