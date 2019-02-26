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
            
            miAlumno.Nombre = txtNombre.Text;
            miAlumno.Escuela = txtEscuela.Text;
            miAlumno.FechaNacimiento = dtFechaNacimiento.Value;
            miAlumno.Telefono = int.Parse(txtTelefono.Text);
            miAlumno.Correo = txtCorreo.Text;
            listaAlumnos.Add(miAlumno);
            MostrarDatos();
            LimpiarControles();
            MessageBox.Show("Alumno añadido con éxito.");
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
    }
}
