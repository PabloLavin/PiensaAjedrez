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
    public partial class Reportes : UserControl
    {
        public Reportes()
        {
            InitializeComponent();
        }
      
        private void cbEscuelas_Load(object sender, EventArgs e)
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                cbEscuelas.AddItem(unaEscuela.Nombre);
            }
            if (ConexionBD.CargarEscuelas().Count > 0)
                cbEscuelas.selectedIndex = 0;
        }

        private void FechaInicio_Load(object sender, EventArgs e)
        {
            FechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
        }

        private void FechaFinal_Load(object sender, EventArgs e)
        {
            FechaFinal.Value = DateTime.Now.AddDays(1);
        }

        private void CargarTodosIngresos_Click(object sender, EventArgs e)
        {
            visorReportes.ReportSource = AdministradorReportes.CargarReporteIngresos(FechaInicio.Value, FechaFinal.Value, cbEscuelas.selectedValue);
        }
        
        private void CargarEgresos_Click(object sender, EventArgs e)
        {
            visorReportes.ReportSource = AdministradorReportes.CargarReporteEgresos(FechaInicio.Value, FechaFinal.Value);
        }

        private void CargarAsistencias_Click(object sender, EventArgs e)
        {
            visorReportes.ReportSource = AdministradorReportes.CargarReporteAsistencias(cbEscuelas.selectedValue,FechaInicio.Value, FechaFinal.Value);
        }
    }
}
