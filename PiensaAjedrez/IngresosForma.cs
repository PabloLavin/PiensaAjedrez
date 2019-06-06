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
            unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
            dgvIngresos.Columns.Clear();
            dgvIngresos.Rows.Clear();
            dgvIngresos.Columns.Add("Mes","Mes");
            dgvIngresos.Columns.Add("Inscripción", "Inscripción");
            if (unaEscuela.CursoActivo.listaActividades.Count > 0)
                dgvIngresos.Columns.Add("Actividad", "Actividad");
            dgvIngresos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                if (unaEscuela.Nombre == cbEscuelas.selectedValue)
                     CargarDGV(unaEscuela);
        }
    }
}
