using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiensaAjedrez
{
    public partial class FormMensaje : Form
    {
        public FormMensaje()
        {
            InitializeComponent();   
        }

        UserControl unUserControl;

        private void FormMensaje_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            this.Hide();
            unUserControl.Enabled = true;
            
        }

        private void BtnDeclinar_Click(object sender, EventArgs e)
        {
            this.Hide();
            unUserControl.Enabled = true;
        }


        /*Casos
         * Caso 1: Advertencia
         * Caso 2: Pregunta
        */
        
        public void Mostrar(string strEncabezado, string strMensaje, int intCaso, UserControl otroUserControl)
        {
            this.Show();
            unUserControl = otroUserControl;
            unUserControl.Enabled = false;
            lblEncabezado.Text = strEncabezado;
            lblMensaje.Text = strMensaje;
            if (intCaso==1)
            {
                btnDeclinar.Visible = false;
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Advertencia.png";
            }
            if (intCaso == 2)
            {
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Question.png";
            }
            
        }
      
    }
}
