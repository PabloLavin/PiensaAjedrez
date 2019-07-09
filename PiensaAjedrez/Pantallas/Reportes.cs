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

        private void CargarReporte(CrystalDecisions.CrystalReports.Engine.ReportClass unReporte)
        {                       
                visorReportes.ReportSource = unReporte;
                PreparandoDatos.Text = "Listo.";
        }

        private void CargarTodosIngresos_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteIngresos(FechaInicio.Value, FechaFinal.Value, cbEscuelas.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el colegio y el intervalo de fecha seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }
        
        private void CargarEgresos_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteEgresos(FechaInicio.Value, FechaFinal.Value));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el intervalo de fecha seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarAsistencias_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteAsistencias(cbEscuelas.selectedValue, FechaInicio.Value, FechaFinal.Value));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el colegio y el intervalo de fecha seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteInscripciones_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteInscripciones(cbEscuelas.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el colegio seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteMensualidades_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteMensualidades(cbEscuelas.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el colegio seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarReporteActividades_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteActividades(cbEscuelas.selectedValue, FechaInicio.Value, FechaFinal.Value));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique el colegio seleccionado. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }
    }
}
