using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiensaAjedrez.Pantallas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void TxtUsuario_Click(object sender, EventArgs e)
        {
            IniciarTxtUsuario();

        }

        void IniciarTxtUsuario()
        {
            txtUsuario.Enabled = true;
            txtUsuario.Enabled = true;
            txtUsuario.Clear();
            txtUsuario.ForeColor = Color.Black;
            
        }

        private void TxtUsuario_MouseHover(object sender, EventArgs e)
        {
            IniciarTxtUsuario();
        }

        private void TxtUsuario_MouseEnter(object sender, EventArgs e)
        {
            IniciarTxtUsuario();
        }

        private void TxtUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            IniciarTxtUsuario();
        }

  

        private void Login_Load(object sender, EventArgs e)
        {
            
            txtPassword.Enabled = true;
            txtUsuario.ForeColor = Color.Gray;
            cbCorreos.Clear();
            foreach (string correo in ConexionBD.CargarCorreos())
            {
                cbCorreos.AddItem(correo);
                cbCorreos.selectedIndex = 0;
            }
            if(cbCorreos.selectedIndex==-1)
                IniciarCBCorreos();
            
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Enabled = true;
            txtPassword.Clear();
        }

        private void TxtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            txtPassword.Enabled = true;
            txtPassword.Clear();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Registro().ShowDialog();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (cbCorreos.selectedIndex == -1)
                IniciarCBCorreos();
            bool blnIniciarSesion = true;
            if (cbCorreos.selectedValue == "Registre un correo" || cbCorreos.selectedValue=="")
            {
                blnIniciarSesion = false;
                if (Preguntar("Advertencia","No ha elegido ninguna cuenta de correo. Tenga en cuenta que podrá registrar los pagos pero no se enviarán los correos de confirmación. ¿Desea continuar?"))
                {
                    blnIniciarSesion = true;
                }
            }
            if (blnIniciarSesion)
            {
                if (ConexionBD.IniciarSesion(txtUsuario.Text, Encrypt.EncryptString(txtPassword.Text)))
                {
                    this.Hide();
                    if(cbCorreos.selectedValue!= "Registre un correo" && cbCorreos.selectedIndex>=0)
                    {
                        string[] cuenta = ConexionBD.CargarCorreos(cbCorreos.selectedValue);
                        Correo.Usuario = cuenta[0];
                        Correo.Contrasena = Encrypt.DecryptString(cuenta[1]);
                    }
                   
                    new FormMensaje().Mostrar("Inicio de Sesión", "¡Bienvenido! Has iniciado sesón correctamente.", 5, new Mensualidades());
                    this.Close();
                }
                else
                {
                    new FormMensaje().Mostrar("Error", "El usuario y/o contraseña son incorrectas. Inténtalo de nuevo.", 1, new Mensualidades());
                    txtUsuario.Focus();
                }
            }
        }

        private void CbCorreos_Enter(object sender, EventArgs e)
        {
            if(cbCorreos.Items.Length<0||cbCorreos.selectedValue== "Registre un correo")
                cbCorreos.Clear();
        }

        void IniciarCBCorreos()
        {
            cbCorreos.Clear();
            cbCorreos.AddItem("Registre un correo");
            cbCorreos.selectedIndex = 0;
            btnIniciarSesion.Focus();
        }
        private void CbCorreos_Leave(object sender, EventArgs e)
        {
            if (cbCorreos.Items.Length <= 0)
                IniciarCBCorreos();
        }

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            FormMensaje unaForma = new FormMensaje();
            bool blnAceptarPago = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 3, new Mensualidades());
            blnAceptarPago = unaForma.Aceptar();
            return blnAceptarPago;
        }
    }
}
