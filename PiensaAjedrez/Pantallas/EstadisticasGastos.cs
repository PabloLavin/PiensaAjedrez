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
            lblCumple.Text += " de " + DateTime.Today.ToString("MMMM");
        }

        void IniciarDGV()
        {
            dgvCumpleaneros.Columns.Add("NumeroControl", "N° ctrl.");
            dgvCumpleaneros.Columns.Add("Apaterno", "A. Paterno");
            dgvCumpleaneros.Columns.Add("AMaterno", "A. Materno");
            dgvCumpleaneros.Columns.Add("Nombre", "Nombre");
            dgvCumpleaneros.Columns.Add("Edad", "Edad");
            dgvCumpleaneros.Columns.Add("CumpleHoy", "Cumple hoy");
            dgvCumpleaneros.Columns.Add("FechaNacimiento", "Fecha Nac.");
            dgvCumpleaneros.Columns.Add("Colegio", "Colegio");
            dgvCumpleaneros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LlenarDGV();
            dgvCumpleaneros.Sort(dgvCumpleaneros.Columns[6], ListSortDirection.Ascending);
            dgvCumpleaneros.SelectionMode = DataGridViewSelectionMode.CellSelect;
            if(dgvCumpleaneros.Rows.Count!=0)
            dgvCumpleaneros.Rows[0].Cells[0].Selected = true;
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
                    dgvCumpleaneros.Rows.Add(unAlumno.NumeroDeControl, unAlumno.ApellidoPaterno, unAlumno.ApellidoMaterno, unAlumno.Nombre, ObtenerEdad(unAlumno), (blnHoy ? "Sí" : "No"), unAlumno.FechaNacimiento.ToShortDateString(), unAlumno.Escuela);
                    blnHoy = false;
                }
            }
            if(dgvCumpleaneros.Rows.Count!=0)
            for (int i = 0; i < dgvCumpleaneros.Rows.Count; i++)
            {
                if (dgvCumpleaneros.Rows[i].Cells[5].Value.ToString() == "Sí")
                    dgvCumpleaneros.Rows[i].Cells[5].Style.BackColor = Color.ForestGreen;
                else
                    dgvCumpleaneros.Rows[i].Cells[5].Style.BackColor = Color.IndianRed;
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
