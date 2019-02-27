using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiensaAjedrez
{
    public partial class RegistroAlumnos : UserControl
    {
        List<Alumnos> listaAlumnos = new List<Alumnos>();
        public RegistroAlumnos()
        {
            InitializeComponent();
            txtNombre.Focus();
            imgFiltro.Enabled = false;
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Escuela", "Escuela");
            dgvAlumnos.Columns.Add("Fecha de nacimiento", "Fecha de nacimiento");
            dgvAlumnos.Columns.Add("Telefono", "Teléfono");
            dgvAlumnos.Columns.Add("Correo", "Correo");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumnos miAlumno = new Alumnos();
            try
            {

                miAlumno.Nombre = txtNombre.Text;
                miAlumno.Escuela = txtEscuela.Text;
                miAlumno.FechaNacimiento = dtFechaNacimiento.Value;
                miAlumno.Telefono = Int64.Parse(txtTelefono.Text.Substring(1, 3) + txtTelefono.Text.Substring(6, 3) + txtTelefono.Text.Substring(12, 4));
                miAlumno.Correo = txtCorreo.Text;
                listaAlumnos.Add(miAlumno);
                MostrarDatos();
                LimpiarControles();
                MessageBox.Show("Alumno añadido con éxito.");

            }
            catch (IndexOutOfRangeException c)
            {
                MessageBox.Show("Sólo se permiten 10 dígitos en el número de teléfono.");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        void MostrarDatos()
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumnos miAlumno in listaAlumnos)
            {
                dgvAlumnos.Rows.Add(miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToShortDateString(), miAlumno.Telefono, miAlumno.Correo);
            }
        }

        void LimpiarControles()
        {
            foreach (Control c in bunifuCards1.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    c.Text = "";
            }
        }

        private void txtCorreo_Click(object sender, EventArgs e)
        {

        }

        private void txtCorreo_Click_1(object sender, EventArgs e)
        {
        }

        private void txtCorreo_MouseEnter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo@hotmail.com")
            {

                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void txtCorreo_MouseClick(object sender, MouseEventArgs e)
        {


        }

        private void txtCorreo_MouseLeave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {

                txtCorreo.Text = "ejemplo@hotmail.com";
                txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            }

        }

        private void txtTelefono_OnValueChanged(object sender, EventArgs e)
        {
            //if(txtTelefono.Text.Length==10&&txtTelefono.Text.Contains("("))
            //{
                
            //}

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            //if (txtTelefono.Text.Length == 10)
            //{
            //    txtTelefono.Text = "(" + txtTelefono.Text.Substring(0, 3) + ") "+txtTelefono.Text.Substring(3,3)+" - "+txtTelefono.Text.Substring(6,4);
                

            //}
        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo@hotmail.com")
            {

                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {if (txtCorreo.Text == "")
            {txtCorreo.Text = "ejemplo@hotmail.com";
                txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            }
        }
    }
}

