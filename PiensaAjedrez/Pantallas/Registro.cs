using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PiensaAjedrez.Pantallas
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().ShowDialog();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombreUsuario.Text != "" && txtContrasena.Text != "" && txtContrasenaConfirmar.Text != "")
            {
                if (txtContrasena.Text.Equals(txtContrasenaConfirmar.Text))
                {
                    ConexionBD.RegistrarUsuario(txtNombreUsuario.Text, Encrypt.EncryptString(txtContrasenaConfirmar.Text));
                    this.Hide();
                    new FormMensaje().Mostrar("Registro Completado", "¡Te has registrado correctamente!", 5, new Mensualidades());
                    new Login().ShowDialog();
                }
                else
                {
                    new FormMensaje().Mostrar("Error","Las contraseñas introducidas no coinciden. Vuelve a intentarlo.",1,new Mensualidades());
                    txtContrasenaConfirmar.Clear();
                    txtContrasena.Focus();
                }
            }
            else
                new FormMensaje().Mostrar("Error", "No deje campos vacíos.",1, new Mensualidades());
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
