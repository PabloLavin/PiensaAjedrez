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
    public partial class IngresosForma : Form
    {
        public IngresosForma()
        {
            InitializeComponent();
        }

        private void IngresosForma_Load(object sender, EventArgs e)
        {
            CargarCB();
            cbEscuelas.selectedIndex = 0;
        }

        void CargarCB()
        {
            cbEscuelas.Clear();
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                cbEscuelas.AddItem(unaEscuela.Nombre);
        }

        void CargarDGV(Escuela unaEscuela)
        {
            try
            {
                unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
                dgvIngresos.Columns.Clear();
                dgvIngresos.Rows.Clear();
                dgvIngresos.Columns.Add("Alumno", "Alumno");
                dgvIngresos.Columns.Add("Razon", "Razon");
                dgvIngresos.Columns.Add("Monto", "Monto");
                dgvIngresos.Columns.Add("Fecha", "Fecha");
                dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                RellenarDGV(unaEscuela);
                
            }
            catch (Exception)
            {
                new FormMensaje().Mostrar("Error", "Ocurrió un error, revise que la escuela tenga un curso actualmente.",1,new Mensualidades());
            }
           

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void RellenarDGV(Escuela unaEscuela)
        {
            foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
            {
            foreach (Pagos unPago in ConexionBD.CargarPagosAlumno(unAlumno.NumeroDeControl))
            {
                    dgvIngresos.Rows.Add(unAlumno.NumeroDeControl, unPago.MesPagado, unPago.Monto.ToString("C"), unPago.FechayHora.ToShortDateString());
            }
            }
        }

        private void CbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                if (unaEscuela.Nombre == cbEscuelas.selectedValue)
                     CargarDGV(unaEscuela);
        }
    }
}
