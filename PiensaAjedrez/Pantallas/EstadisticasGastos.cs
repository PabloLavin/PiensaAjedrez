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
    public partial class Cumpleaños : Form
    {
        public Cumpleaños()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cumpleaños_Load(object sender, EventArgs e)
        {
            IniciarDGV();
        }

        void IniciarDGV()
        {
            dgvCumpleaneros.Columns.Add("NumeroControl", "N° ctrl.");
            dgvCumpleaneros.Columns.Add("Apaterno", "A. Paterno");
            dgvCumpleaneros.Columns.Add("AMaterno", "A. Materno");
            dgvCumpleaneros.Columns.Add("Nombre", "Nombre");
            dgvCumpleaneros.Columns.Add("Edad", "Edad");
            dgvCumpleaneros.Columns.Add("FechaNacimiento", "Fecha Nac.");
            dgvCumpleaneros.Columns.Add("Colegio", "Colegio");
            dgvCumpleaneros.Columns.Add("CumpleHoy", "Cumple hoy");
            dgvCumpleaneros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LlenarDGV();
            dgvCumpleaneros.Sort(dgvCumpleaneros.Columns[5], ListSortDirection.Ascending);
        }

        void LlenarDGV()
        {
            dgvCumpleaneros.Rows.Clear();
            bool blnHoy = false;
            foreach (Alumno unAlumno in ConexionBD.CargarAlumnos())
            {
                if(unAlumno.FechaNacimiento.Month== DateTime.Today.Month)
                {
                    if (unAlumno.FechaNacimiento.Day == DateTime.Today.Day)
                        blnHoy = true;
                    dgvCumpleaneros.Rows.Add(unAlumno.NumeroDeControl, unAlumno.ApellidoPaterno, unAlumno.ApellidoMaterno, unAlumno.Nombre, ObtenerEdad(unAlumno), unAlumno.FechaNacimiento.ToShortDateString(), unAlumno.Escuela, (blnHoy ? "Sí" : "No"));
                    blnHoy = false;
                }
            }
        }

        int ObtenerEdad(Alumno unAlumno)
        {
            int intEdad = DateTime.Today.Year - unAlumno.FechaNacimiento.Year;
            if (DateTime.Today.Day < unAlumno.FechaNacimiento.Day)
                intEdad--;
            return intEdad;
        }
    }
}
