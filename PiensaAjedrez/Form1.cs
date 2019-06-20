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
        FormMensaje unaForma = new FormMensaje();
        bool blnAceptar;

       

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
            ReemplazarPantalla(new Reportes());           
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            if(Preguntar("Salir", "¿Desea cerrar la conexión y salir del sistema de Piensa Ajedrez?"))            
                Application.Exit();            
        }

        private void ReemplazarPantalla(UserControl unUserControl)
        {
            panTrabajo.Controls.Clear();
            panTrabajo.Controls.Add(unUserControl);
        }

        private void btnColegios_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new Escuelas());
        }

        private void btnPiensaAjedrez_Click(object sender, EventArgs e)
        {   
            if (btnRegistrar.selected)            
                ReemplazarPantalla(new RegistroAlumnos());            
            if (btnMensualidades.selected)
                ReemplazarPantalla(new Mensualidades());
            if (btnColegios.selected)
                ReemplazarPantalla(new Escuelas());
            if (btnAsistencia.selected)
                ReemplazarPantalla(new Asistencia());
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            ReemplazarPantalla(new Asistencia());
        }

        private void Form1_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            blnAceptar = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 2, new UserControl());
            blnAceptar = unaForma.Aceptar();
            return blnAceptar;
        }

    }
}
