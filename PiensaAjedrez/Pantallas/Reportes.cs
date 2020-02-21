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
        Color original;
        public Reportes()
        {
            InitializeComponent();
            dtmInicioCurso.Value = DateTime.Now.AddYears(-1);
            dtmFinCurso.Value = DateTime.Now;
            chkFecha.Checked = false;
            chkGrupo.Checked = false;
            chkTipoGasto.Checked = false;
            original = chkFecha.BackColor;
            Activar();
        }

        void Activar()
        {
            dtmInicioCurso.BackColor = chkFecha.Checked ? original : Color.Gray ;
            dtmFinCurso.BackColor = chkFecha.Checked ? original : Color.Gray;
            cboGrupoGastos.Enabled = chkGrupo.Checked;
            gpTipoGasto.Enabled = chkTipoGasto.Checked;
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
            string strMetodoPago = cbMetodoPago.selectedValue != "Cualquiera" ? cbMetodoPago.selectedValue : "";
            try
            {                
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerIngresosGlobales(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1), strMetodoPago), cbEscuelas.selectedValue, "Ingresos");                
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
                string strGrupo = chkGrupo.Checked ? cboGrupoGastos.selectedValue : "";
                string strFechaInicio = chkFecha.Checked ? ConexionBD.FormatearFecha(dtmInicioCurso.Value) : "";
                string strFechaFin = chkFecha.Checked ? ConexionBD.FormatearFecha(dtmFinCurso.Value) : "";
                string strTipo = chkTipoGasto.Checked ? gpTipoGasto.selectedValue : "";
                string strNombreReporte = strGrupo != "" ? strGrupo : strTipo;

                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerEgresos(strGrupo, strFechaInicio,strFechaFin, strTipo), strNombreReporte, "Egresos");                
            }
            catch (Exception exception)
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
            string strMetodoPago = cbMetodoPago.selectedValue != "Cualquiera" ? cbMetodoPago.selectedValue : "";
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerInscripciones(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1), strMetodoPago), cbEscuelas.selectedValue, "Inscripciones");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }            
        }

        private void CargarReporteMensualidades_Click(object sender, EventArgs e)
        {
            string strMetodoPago = cbMetodoPago.selectedValue != "Cualquiera" ? cbMetodoPago.selectedValue : "";
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerMensualidades(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1), strMetodoPago), cbEscuelas.selectedValue, "Mensualidades");
                
            }
            catch (Exception)
            {
                FormMensaje unaForma = new FormMensaje();
                unaForma.Mostrar("Error de generación de reporte", "Verifique los datos seleccionados. Si el error sigue, comuníquese con los desarrolladores.", 1, this);
            }
        }

        private void CargarReporteActividades_Click(object sender, EventArgs e)
        {
            string strMetodoPago = cbMetodoPago.selectedValue != "Cualquiera" ? cbMetodoPago.selectedValue : "";
            try
            {
                ConstructorReportes.ConstruirReporte(ConexionBD.ObtenerActividades(cboCursos.selectedValue.Substring(0, cboCursos.selectedValue.IndexOf(" ") + 1), strMetodoPago), cbEscuelas.selectedValue, "Actividades");
                
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

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkGrupo_OnChange(object sender, EventArgs e)
        {
            Activar();
        }

        private void chkFecha_OnChange(object sender, EventArgs e)
        {
            Activar();
        }

        private void chkTipoGasto_OnChange(object sender, EventArgs e)
        {
            Activar();
        }
    }
}
