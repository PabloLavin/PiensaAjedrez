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
            CargarListaCursos();
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
        
        private void CargarListaCursos()
        {
            /*            
            if (ConexionBD.CargarEscuelas().Count > 0)
                foreach (Cursos unCurso in ConexionBD.CargarCursos(cbEscuelas.selectedValue))
                {
                    cboCursos.AddItem(unCurso.Clave + " - " + unCurso.InicioCursos.ToShortDateString() + " - " + unCurso.FinCurso.ToShortDateString());
                }
                if (ConexionBD.CargarCursos(cbEscuelas.selectedValue).Count > 0)
                    cboCursos.selectedIndex = 0;            
           */
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
                //CargarReporte(AdministradorReportes.CargarReporteIngresos(FechaInicio.Value, FechaFinal.Value, cbEscuelas.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }
        
        private void CargarEgresos_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                CargarReporte(AdministradorReportes.CargarReporteEgresos(cboGrupoGastos.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarAsistencias_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                //CargarReporte(AdministradorReportes.CargarReporteAsistencias(cbEscuelas.selectedValue, FechaInicio.Value, FechaFinal.Value));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteInscripciones_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                //CargarReporte(AdministradorReportes.CargarReporteInscripciones(cbEscuelas.selectedValue));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
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
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarReporteActividades_Click(object sender, EventArgs e)
        {
            PreparandoDatos.Text = "Preparando datos...";
            try
            {
                //CargarReporte(AdministradorReportes.CargarReporteActividades(cbEscuelas.selectedValue, FechaInicio.Value, FechaFinal.Value));
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void cboGrupoGastos_Load(object sender, EventArgs e)
        {
            foreach (string unGrupo in ConexionBD.CargarGruposGastos())
            {
                cboGrupoGastos.AddItem(unGrupo);
            }
            if (ConexionBD.CargarGruposGastos().Count > 0)
                cboGrupoGastos.selectedIndex = 0;
        }
    }
}
