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
        int intCasos;
        bool blnAceptar=false;

        private void FormMensaje_Load(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
           Cerrar(true);
        }

        private void BtnDeclinar_Click(object sender, EventArgs e)
        {
            if (intCasos == 7)
            {
                Recordatorios.dtmHoraRecordatorio = dtmHora.Value;
                Recordatorios.GuardarConfiguracion(Recordatorios.dtmHoraRecordatorio);
                Recordatorios.intCaso = 1;
            }
            else
            {
                Recordatorios.intCaso = 2;
            }
            Cerrar(false);
        }

        void Cerrar(bool blnOpcion)
        {
            this.Close();
            blnAceptar=blnOpcion;
            //return blnOpcion;
            //if (unUserControl.GetType().Equals(new Escuelas().GetType())&&intCasos==2)
            //{
            //    //= blnOpcion;
            //}
           
        }


        /*Casos
         * Caso 1: Advertencia
         * Caso 2: Pregunta Escuela
        */
        
        public void Mostrar(string strEncabezado, string strMensaje, int intCaso, UserControl otroUserControl)
        {
            unUserControl = otroUserControl;
            //unUserControl.Enabled = false;
            intCasos = intCaso;
            lblEncabezado.Text = strEncabezado;
            lblMensaje.Text = strMensaje;
            btnAceptar.Location = new Point(44, 119);
            btnDeclinar.Location = new Point(164, 119);
            this.Height = 163;
            btnAceptar.ButtonText = "Aceptar";
            btnRecordar.Visible = false;
            groupBox1.Visible = false;
            if (intCaso == 1)
            {
                btnDeclinar.Visible = false;
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Advertencia.png";
                groupBox1.Visible = true;
            }
            if (intCaso == 2)
            {
                btnDeclinar.Visible = true;
                btnAceptar.ButtonText = "Sí";
                btnDeclinar.ButtonText = "No";
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Question1.png";
               
            }
            if (intCaso == 3|| intCaso==4)
            {

                if (intCaso == 3)
                {
                btnImagen.ImageLocation= System.IO.Directory.GetCurrentDirectory() + @"\Moneys.png";
                    btnDeclinar.Visible = true;
                }
                else
                {
                    btnDeclinar.Visible = false;
                    btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Advertencia.png";

                }
                this.Height = 220;
                btnAceptar.Location=new Point(44,178);
                btnDeclinar.Location=new Point(164, 178);
            }
            if (intCaso == 5)
            {
                btnDeclinar.Visible = false;
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\check.png";

            }
            if (intCaso == 6)
            {
                btnRecordar.Visible = true;
                this.Height = 190;
                btnDeclinar.Visible = true;
                btnAceptar.ButtonText = "Sí";
                btnDeclinar.ButtonText = "No";
                btnImagen.ImageLocation = System.IO.Directory.GetCurrentDirectory() + @"\Question1.png";
            }
            this.ShowDialog();

        }

        public bool Aceptar()
        {
            return blnAceptar;
        }

        private void BtnRecordar_Click(object sender, EventArgs e)
        {
            foreach (Control unBoton in this.Controls)
            {
                if (unBoton is Bunifu.Framework.UI.BunifuThinButton2)
                    unBoton.Visible = false;
            }
            btnDeclinar.Location = new Point(btnDeclinar.Location.X-110, btnDeclinar.Location.Y);
            intCasos = 7;
            btnDeclinar.Visible = true;
            dtmHora.Visible = true;
            this.Height = 163;
            btnDeclinar.ButtonText = "Aceptar";
            lblEncabezado.Text = "Recordar mas tarde";
            lblMensaje.Text = "Seleccione una hora.";
            groupBox1.Visible = true;
        }
    }
}
