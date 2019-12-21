using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiensaAjedrez.Reporte;

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
            cbEscuelas.Clear();
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                cbEscuelas.AddItem(unaEscuela.Nombre);
            }
            if (ConexionBD.CargarEscuelas().Count > 0)
                cbEscuelas.selectedIndex = 0;
            CargarListaCursos();
        }
        
        private void CargarListaCursos()
        {
            cboCursos.Clear();            
            if (ConexionBD.CargarEscuelas().Count > 0)
                foreach (Cursos unCurso in ConexionBD.CargarCursos(cbEscuelas.selectedValue))
                {
                    cboCursos.AddItem(unCurso.Clave + " - " + unCurso.InicioCursos.ToShortDateString() + " - " + unCurso.FinCurso.ToShortDateString());
                }
            if (ConexionBD.CargarCursos(cbEscuelas.selectedValue).Count > 0)
                cboCursos.selectedIndex = 0;

        }

        /*
        private void CargarReporte(CrystalDecisions.CrystalReports.Engine.ReportClass unReporte)
        {                       
                visorReportes.ReportSource = unReporte;
                PreparandoDatos.Text = "Listo.";
        }
        */
        private void CargarTodosIngresos_Click(object sender, EventArgs e)
        {            
            try
            {                
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerIngresosGlobales(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1)), cbEscuelas.selectedValue, "Ingresos");                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }
        
        private void CargarEgresos_Click(object sender, EventArgs e) 
        {   
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerEgresos(cboGrupoGastos.selectedValue), cboGrupoGastos.selectedValue, "Egresos");                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarAsistencias_Click(object sender, EventArgs e)
        {   
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerAsistencias(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1)), cbEscuelas.selectedValue, "Asistencias");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteInscripciones_Click(object sender, EventArgs e)
        {   
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerInscripciones(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1)), cbEscuelas.selectedValue, "Inscripciones");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteMensualidades_Click(object sender, EventArgs e)
        {            
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerMensualidades(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1)), cbEscuelas.selectedValue, "Mensualidades");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarReporteActividades_Click(object sender, EventArgs e)
        {            
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerActividades(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1)), cbEscuelas.selectedValue, "Actividades");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void cboGrupoGastos_Load(object sender, EventArgs e)
        {
            cboGrupoGastos.Clear();
            foreach (string unGrupo in ConexionBD.CargarGruposGastos())
            {
                cboGrupoGastos.AddItem(unGrupo);
            }
            if (ConexionBD.CargarGruposGastos().Count > 0)
                cboGrupoGastos.selectedIndex = 0;
        }

        private void cbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            CargarListaCursos();
        }
    }
}
