namespace PiensaAjedrez.Pantallas
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.lblTopico = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.imgIngresos = new Bunifu.Framework.UI.BunifuImageButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbUsuario = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtContrasenaConfirmar = new System.Windows.Forms.TextBox();
            this.lblConfirmarContrasena = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbCorreo = new System.Windows.Forms.TabPage();
            this.btnRegistrarCorreo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtConfirmarPassCuenta = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassCuenta = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCorreoCuenta = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbUsuario.SuspendLayout();
            this.tbCorreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTopico
            // 
            this.lblTopico.AutoSize = true;
            this.lblTopico.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopico.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTopico.Location = new System.Drawing.Point(272, 43);
            this.lblTopico.Name = "lblTopico";
            this.lblTopico.Size = new System.Drawing.Size(273, 33);
            this.lblTopico.TabIndex = 24;
            this.lblTopico.Text = "Registro de Usuario";
            // 
            // imgIngresos
            // 
            this.imgIngresos.BackColor = System.Drawing.Color.Transparent;
            this.imgIngresos.Enabled = false;
            this.imgIngresos.Image = ((System.Drawing.Image)(resources.GetObject("imgIngresos.Image")));
            this.imgIngresos.ImageActive = ((System.Drawing.Image)(resources.GetObject("imgIngresos.ImageActive")));
            this.imgIngresos.Location = new System.Drawing.Point(12, 13);
            this.imgIngresos.Name = "imgIngresos";
            this.imgIngresos.Size = new System.Drawing.Size(254, 98);
            this.imgIngresos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgIngresos.TabIndex = 23;
            this.imgIngresos.TabStop = false;
            this.imgIngresos.Zoom = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbUsuario);
            this.tabControl1.Controls.Add(this.tbCorreo);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(12, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 241);
            this.tabControl1.TabIndex = 25;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // tbUsuario
            // 
            this.tbUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbUsuario.Controls.Add(this.btnRegistrar);
            this.tbUsuario.Controls.Add(this.btnSalir);
            this.tbUsuario.Controls.Add(this.txtContrasenaConfirmar);
            this.tbUsuario.Controls.Add(this.lblConfirmarContrasena);
            this.tbUsuario.Controls.Add(this.txtContrasena);
            this.tbUsuario.Controls.Add(this.lblPassword);
            this.tbUsuario.Controls.Add(this.txtNombreUsuario);
            this.tbUsuario.Controls.Add(this.lblNombreUsuario);
            this.tbUsuario.Location = new System.Drawing.Point(4, 22);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Padding = new System.Windows.Forms.Padding(3);
            this.tbUsuario.Size = new System.Drawing.Size(548, 215);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.Text = "Usuario";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ActiveBorderThickness = 1;
            this.btnRegistrar.ActiveCornerRadius = 20;
            this.btnRegistrar.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrar.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRegistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.BackgroundImage")));
            this.btnRegistrar.ButtonText = "Registrar Usuario";
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrar.IdleBorderThickness = 1;
            this.btnRegistrar.IdleCornerRadius = 20;
            this.btnRegistrar.IdleFillColor = System.Drawing.Color.Teal;
            this.btnRegistrar.IdleForecolor = System.Drawing.Color.White;
            this.btnRegistrar.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.Location = new System.Drawing.Point(211, 156);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(125, 51);
            this.btnRegistrar.TabIndex = 62;
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click_1);
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
            this.btnSalir.ButtonText = "¿Ya tienes cuenta?";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 20;
            this.btnSalir.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnSalir.IdleForecolor = System.Drawing.Color.Firebrick;
            this.btnSalir.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSalir.Location = new System.Drawing.Point(453, 169);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 48);
            this.btnSalir.TabIndex = 61;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // txtContrasenaConfirmar
            // 
            this.txtContrasenaConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenaConfirmar.Location = new System.Drawing.Point(253, 119);
            this.txtContrasenaConfirmar.Name = "txtContrasenaConfirmar";
            this.txtContrasenaConfirmar.Size = new System.Drawing.Size(254, 26);
            this.txtContrasenaConfirmar.TabIndex = 60;
            this.txtContrasenaConfirmar.UseSystemPasswordChar = true;
            // 
            // lblConfirmarContrasena
            // 
            this.lblConfirmarContrasena.AutoSize = true;
            this.lblConfirmarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.lblConfirmarContrasena.Location = new System.Drawing.Point(65, 122);
            this.lblConfirmarContrasena.Name = "lblConfirmarContrasena";
            this.lblConfirmarContrasena.Size = new System.Drawing.Size(165, 20);
            this.lblConfirmarContrasena.TabIndex = 59;
            this.lblConfirmarContrasena.Text = "Confirmar Contraseña";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(253, 67);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(254, 26);
            this.txtContrasena.TabIndex = 58;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassword.Location = new System.Drawing.Point(138, 69);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 20);
            this.lblPassword.TabIndex = 57;
            this.lblPassword.Text = "Contraseña";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(253, 19);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(254, 26);
            this.txtNombreUsuario.TabIndex = 56;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNombreUsuario.Location = new System.Drawing.Point(165, 22);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(65, 20);
            this.lblNombreUsuario.TabIndex = 55;
            this.lblNombreUsuario.Text = "Nombre";
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tbCorreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tbCorreo.Controls.Add(this.btnRegistrarCorreo);
            this.tbCorreo.Controls.Add(this.bunifuThinButton22);
            this.tbCorreo.Controls.Add(this.txtConfirmarPassCuenta);
            this.tbCorreo.Controls.Add(this.bunifuCustomLabel1);
            this.tbCorreo.Controls.Add(this.txtPassCuenta);
            this.tbCorreo.Controls.Add(this.bunifuCustomLabel2);
            this.tbCorreo.Controls.Add(this.txtCorreoCuenta);
            this.tbCorreo.Controls.Add(this.bunifuCustomLabel3);
            this.tbCorreo.Location = new System.Drawing.Point(4, 22);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Padding = new System.Windows.Forms.Padding(3);
            this.tbCorreo.Size = new System.Drawing.Size(548, 215);
            this.tbCorreo.TabIndex = 1;
            this.tbCorreo.Text = "Correo";
            // 
            // btnRegistrarCorreo
            // 
            this.btnRegistrarCorreo.ActiveBorderThickness = 1;
            this.btnRegistrarCorreo.ActiveCornerRadius = 20;
            this.btnRegistrarCorreo.ActiveFillColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrarCorreo.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegistrarCorreo.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnRegistrarCorreo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegistrarCorreo.BackgroundImage")));
            this.btnRegistrarCorreo.ButtonText = "Registrar Correo";
            this.btnRegistrarCorreo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCorreo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRegistrarCorreo.IdleBorderThickness = 1;
            this.btnRegistrarCorreo.IdleCornerRadius = 20;
            this.btnRegistrarCorreo.IdleFillColor = System.Drawing.Color.Teal;
            this.btnRegistrarCorreo.IdleForecolor = System.Drawing.Color.White;
            this.btnRegistrarCorreo.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnRegistrarCorreo.Location = new System.Drawing.Point(211, 156);
            this.btnRegistrarCorreo.Margin = new System.Windows.Forms.Padding(6);
            this.btnRegistrarCorreo.Name = "btnRegistrarCorreo";
            this.btnRegistrarCorreo.Size = new System.Drawing.Size(125, 51);
            this.btnRegistrarCorreo.TabIndex = 70;
            this.btnRegistrarCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegistrarCorreo.Click += new System.EventHandler(this.BtnRegistrarCorreo_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.IndianRed;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "¿Ya tienes cuenta?";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Firebrick;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.Location = new System.Drawing.Point(453, 169);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(99, 48);
            this.bunifuThinButton22.TabIndex = 69;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // txtConfirmarPassCuenta
            // 
            this.txtConfirmarPassCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmarPassCuenta.Location = new System.Drawing.Point(253, 119);
            this.txtConfirmarPassCuenta.Name = "txtConfirmarPassCuenta";
            this.txtConfirmarPassCuenta.Size = new System.Drawing.Size(254, 26);
            this.txtConfirmarPassCuenta.TabIndex = 68;
            this.txtConfirmarPassCuenta.UseSystemPasswordChar = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(65, 122);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(165, 20);
            this.bunifuCustomLabel1.TabIndex = 67;
            this.bunifuCustomLabel1.Text = "Confirmar Contraseña";
            // 
            // txtPassCuenta
            // 
            this.txtPassCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCuenta.Location = new System.Drawing.Point(253, 67);
            this.txtPassCuenta.Name = "txtPassCuenta";
            this.txtPassCuenta.Size = new System.Drawing.Size(254, 26);
            this.txtPassCuenta.TabIndex = 66;
            this.txtPassCuenta.UseSystemPasswordChar = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(80, 69);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 20);
            this.bunifuCustomLabel2.TabIndex = 65;
            this.bunifuCustomLabel2.Text = "Contraseña(Correo)";
            // 
            // txtCorreoCuenta
            // 
            this.txtCorreoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoCuenta.Location = new System.Drawing.Point(253, 19);
            this.txtCorreoCuenta.Name = "txtCorreoCuenta";
            this.txtCorreoCuenta.Size = new System.Drawing.Size(254, 26);
            this.txtCorreoCuenta.TabIndex = 64;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(97, 22);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(133, 20);
            this.bunifuCustomLabel3.TabIndex = 63;
            this.bunifuCustomLabel3.Text = "Correo electónico";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(580, 370);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTopico);
            this.Controls.Add(this.imgIngresos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgIngresos)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbUsuario.ResumeLayout(false);
            this.tbUsuario.PerformLayout();
            this.tbCorreo.ResumeLayout(false);
            this.tbCorreo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblTopico;
        private Bunifu.Framework.UI.BunifuImageButton imgIngresos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbUsuario;
        private System.Windows.Forms.TabPage tbCorreo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private System.Windows.Forms.TextBox txtContrasenaConfirmar;
        private Bunifu.Framework.UI.BunifuCustomLabel lblConfirmarContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNombreUsuario;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegistrarCorreo;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.TextBox txtConfirmarPassCuenta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtPassCuenta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtCorreoCuenta;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}