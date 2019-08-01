using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PiensaAjedrez
{
    public abstract class AdministradorReportes
    {
        public static Reporte.ReporteIngresos CargarReporteIngresos(string strCurso, string strDatosCurso)
        {
            Reporte.Datasets.DatosIngresos datos = ConexionBD.ObtenerIngresosGlobales(strCurso);            
            Reporte.ReporteIngresos nuevoReporte = new Reporte.ReporteIngresos();
            nuevoReporte.SetDataSource(datos);
            CrystalDecisions.CrystalReports.Engine.TextObject txtNombreDatos;
            txtNombreDatos = nuevoReporte.ReportDefinition.ReportObjects["Datos"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtNombreDatos.Text = strDatosCurso;
            nuevoReporte.SetParameterValue("@Curso", strCurso);            
            return nuevoReporte;
        }

        public static Reporte.ReporteEgresos CargarReporteEgresos(string strGrupo)
        {
            Reporte.Datasets.DatosEgresos datos = ConexionBD.ObtenerEgresos(strGrupo);
            Reporte.ReporteEgresos nuevoReporte = new Reporte.ReporteEgresos();
            nuevoReporte.SetDataSource(datos);
            nuevoReporte.SetParameterValue("@GRUPO", strGrupo);            
            return nuevoReporte;
        }

        public static Reporte.ReporteAsistencias CargarReporteAsistencias(string strCurso, string strDatosCurso)
        {
            Reporte.Datasets.DatosAsistencias datos = ConexionBD.ObtenerAsistencias(strCurso);
            Reporte.ReporteAsistencias nuevoReporte = new Reporte.ReporteAsistencias();
            nuevoReporte.SetDataSource(datos);

            CrystalDecisions.CrystalReports.Engine.TextObject txtNombreDatos;
            txtNombreDatos = nuevoReporte.ReportDefinition.ReportObjects["Datos"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtNombreDatos.Text = strDatosCurso;
            nuevoReporte.SetParameterValue("@CURSO", strCurso);            
            return nuevoReporte;
        }
        public static Reporte.ReporteInscripcion CargarReporteInscripciones(string strCurso, string strDatosCurso)
        {
            Reporte.Datasets.DatosInscripcion datos = ConexionBD.ObtenerInscripciones(strCurso);
            Reporte.ReporteInscripcion nuevoReporte = new Reporte.ReporteInscripcion();
            nuevoReporte.SetDataSource(datos);
            CrystalDecisions.CrystalReports.Engine.TextObject txtNombreDatos;
            txtNombreDatos = nuevoReporte.ReportDefinition.ReportObjects["Datos"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtNombreDatos.Text = strDatosCurso;
            nuevoReporte.SetParameterValue("@Curso", strCurso);
            return nuevoReporte;
        }

        public static Reporte.ReporteMensualidades CargarReporteMensualidades(string strCurso, string strDatosCurso)
        {
            Reporte.Datasets.DatosMensualidades datos = ConexionBD.ObtenerMensualidades(strCurso);
            Reporte.ReporteMensualidades nuevoReporte = new Reporte.ReporteMensualidades();
            nuevoReporte.SetDataSource(datos);
            CrystalDecisions.CrystalReports.Engine.TextObject txtNombreDatos;
            txtNombreDatos = nuevoReporte.ReportDefinition.ReportObjects["Datos"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtNombreDatos.Text = strDatosCurso;
            nuevoReporte.SetParameterValue("@CURSO", strCurso);
            return nuevoReporte;
        }

        public static Reporte.ReporteActividades CargarReporteActividades(string strCurso, string strDatosCurso)
        {
            Reporte.Datasets.DatosActividades datos = ConexionBD.ObtenerActividades(strCurso);
            Reporte.ReporteActividades nuevoReporte = new Reporte.ReporteActividades();
            nuevoReporte.SetDataSource(datos);
            CrystalDecisions.CrystalReports.Engine.TextObject txtNombreDatos;
            txtNombreDatos = nuevoReporte.ReportDefinition.ReportObjects["Datos"] as CrystalDecisions.CrystalReports.Engine.TextObject;
            txtNombreDatos.Text = strDatosCurso;
            nuevoReporte.SetParameterValue("@CURSO", strCurso);
            return nuevoReporte;
        }
    }
}
