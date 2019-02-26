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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnMensualidades.selected = true;
            ReemplazarPantalla(new Mensualidades());
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cerrar_MouseEnter(object sender, EventArgs e)
        {
            Cerrar.ForeColor = Color.Red;
        }

        private void Cerrar_MouseLeave(object sender, EventArgs e)
        {
            Cerrar.ForeColor = Color.White;
        }

        private void btnMensualidades_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new Mensualidades());
            
        }
   
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new RegistroAlumnos());
           
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new UserControl());
           
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new UserControl());
           
        }

        private void ReemplazarPantalla(UserControl unUserControl)
        {
            panTrabajo.Controls.Clear();
            panTrabajo.Controls.Add(unUserControl);
        }  
    }
}
