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
        public static Reporte.ReporteIngresos CargarReporteIngresos(DateTime fechaInicial, DateTime fechaFinal, string NombreEscuela)
        {
            Reporte.Datasets.DatosIngresos datos = ConexionBD.ObtenerIngresosGlobales(NombreEscuela,fechaInicial, fechaFinal);            
            Reporte.ReporteIngresos nuevoReporte = new Reporte.ReporteIngresos();
            nuevoReporte.SetDataSource(datos);
            nuevoReporte.SetParameterValue("@INICIO", fechaInicial);
            nuevoReporte.SetParameterValue("@FIN", fechaFinal);
            nuevoReporte.SetParameterValue("@ESCUELA", NombreEscuela);
            return nuevoReporte;
        }
    }
}
