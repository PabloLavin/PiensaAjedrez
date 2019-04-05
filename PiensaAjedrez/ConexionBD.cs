using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PiensaAjedrez
{
    public abstract class ConexionBD
    {
        public static SqlConnection ObtenerConexion()
        {
            //SqlConnection con = new SqlConnection(@"Data Source=LA-DIVERTIDA; Initial Catalog = PIENSAJEDREZ; Server=LA-DIVERTIDA\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7L6CITQ7; Initial Catalog = PIENSAJEDREZ; Server=LAPTOP-7L6CITQ7\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");
            con.Open();
            return (con);
        }

        public static string FormatearFecha(DateTime unaFecha)
        {
            //return unaFecha.Year + "-" + unaFecha.Day + "-" + unaFecha.Month;//Formato de Pablo
            return unaFecha.Year + "-" + unaFecha.Month + "-" + unaFecha.Day; //Formato de los WWEYES
        }

        public static void AgregarEscuela(string strEscuela)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ESCUELA VALUES ('"+strEscuela+"')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Escuela> CargarEscuelas()
        {
            List<Escuela> listaEscuelas = new List<Escuela>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT NombreEscuela FROM ESCUELA", con);
                SqlDataReader escuelas = comando.ExecuteReader();
                while (escuelas.Read())
                    listaEscuelas.Add(new Escuela(escuelas.GetString(0)));
            }
            return listaEscuelas;
        }

        public static void RenombrarEscuela(string strNombreOriginal, string strNuevoNombre)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                try
                {
                    SqlCommand comando = new SqlCommand("UPDATE ESCUELA SET NombreEscuela = '" + strNuevoNombre + "' WHERE NombreEscuela = '" + strNombreOriginal + "'", con);
                    comando.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw new Exception("No es posible cambiarle el nombre a una escuela que:\n1. Ya tiene alumnos registrados.\n 2.Ya tiene cursos registrados. \n3.Está por asignarle el nombre de otra escuela existente.");
                }
                
            }
        }

        public static void AgregarCurso(string strNombreEscuela, DateTime FechaInicio, DateTime FechaFinal)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                string strClave = FechaInicio.Month.ToString() + FechaFinal.Month.ToString() + new Random().Next(10, 500);
                string strQuery = @"IF NOT(EXISTS(SELECT * FROM CURSO WHERE Activo = 1 AND NombreEscuela = '"+strNombreEscuela+"')) BEGIN INSERT INTO CURSO VALUES('"+strClave+"', '"+strNombreEscuela+"', '"+FormatearFecha(FechaInicio)+ "', '" + FormatearFecha(FechaFinal) + "', 1) END ELSE RAISERROR('Ya existe un curso activo para este colegio. Debe finalizarlo.', 16, 1) ";
                SqlCommand comando = new SqlCommand(strQuery, con);
                comando.ExecuteNonQuery();
            }
        }

        public static Cursos CargarCursoActivo(string strNombreEscuela)
        {
            Cursos unCurso = null;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CURSO WHERE Activo = 1 AND NombreEscuela ='"+strNombreEscuela+"'", con);
                SqlDataReader curso = comando.ExecuteReader();
                while (curso.Read())
                {
                    unCurso = new Cursos(curso.GetDateTime(2), curso.GetDateTime(3));
                    unCurso.Clave = curso.GetString(0);                    
                    unCurso.Activo = true;
                }                    
            }
            return unCurso;
        }

        public static void ActualizarDatosCurso(string strNombreEscuela, DateTime FechaInicio, DateTime FechaFinal)
        {
            using (SqlConnection con = ObtenerConexion())
            {                
                SqlCommand comando = new SqlCommand("UPDATE CURSO SET InicioCurso = '" + FormatearFecha(FechaInicio)+ "', FinCurso = '" + FormatearFecha(FechaFinal) + "' WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "'", con);
                comando.ExecuteNonQuery();
            }
        }

        public static void FinalizarCurso(string strNombreEscuela)
        {
            using (SqlConnection con = ObtenerConexion())
            {                
                SqlCommand comando = new SqlCommand("UPDATE CURSO SET Activo = 0 WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "'", con);
                comando.ExecuteNonQuery();
            }
        }

        public static void AgregarActividad(string strNombreEscuela, string strNombreActividad)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                string strClave = strNombreEscuela.Substring(0,1) + strNombreActividad.Substring(0,1) + new Random().Next(10, 500);
                SqlCommand comando = new SqlCommand("INSERT INTO ACTIVIDAD VALUES ('"+strClave+"', '"+strNombreActividad+"', (SELECT IDCurso FROM CURSO WHERE Activo = 1 AND NombreEscuela = '"+strNombreEscuela+"'))", con);
                comando.ExecuteNonQuery();
            }
        }

        public static void EliminarActividad(string strNombreEscuela, string strNombreActividad)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("DELETE FROM ACTIVIDAD WHERE Nombre = '"+strNombreActividad+"' AND IDCurso = (SELECT IDCurso FROM CURSO WHERE Activo = 1 AND NombreEscuela = '"+strNombreEscuela+"')", con);
                comando.ExecuteNonQuery();
            }
        }


        public static List<Cursos> CargarCursos(string strNombreEscuela)
        {
            List<Cursos> listaCursos = new List<Cursos>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CURSO WHERE NombreEscuela ='" + strNombreEscuela + "'", con);
                SqlDataReader curso = comando.ExecuteReader();
                while (curso.Read())
                {
                    Cursos unCurso = new Cursos(curso.GetDateTime(2), curso.GetDateTime(3));
                    unCurso.Clave = curso.GetString(0);                    
                    unCurso.Activo = curso.GetInt16(4) == 1;
                    listaCursos.Add(unCurso);
                }
            }
            return listaCursos;
        }

        public static List<string> CargarActividades(string IDCurso)
        {
            List<string> Actividades = new List<string>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ACTIVIDAD WHERE IDCurso = '" + IDCurso+"'", con);
                SqlDataReader actividad = comando.ExecuteReader();
                while (actividad.Read())                
                    Actividades.Add(actividad.GetString(1));                
            }
            return Actividades;
        }

        #region Alumnos
        public static void AgregarAlumno(Alumno unAlumno)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ALUMNO VALUES ('" + unAlumno.NumeroDeControl + "','" + unAlumno.Nombre + "','" + unAlumno.Escuela + "', '" + FormatearFecha(unAlumno.FechaNacimiento)+ "', '" + unAlumno.Telefono + "', '" + unAlumno.Correo + "', '" + (unAlumno.Activo ? "1" : "0") + "', '" + unAlumno.Tutor + "')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Alumno> CargarAlumnos()
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ALUMNO", con);
                SqlDataReader alumnos = comando.ExecuteReader();
                while (alumnos.Read())
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7)));
            }
            return listaAlumnos;
        }

        public static void EditarAlumno(string strNroControl, Alumno unAlumno)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                
                    SqlCommand comando = new SqlCommand("UPDATE ALUMNO SET Nombre = '" + unAlumno.Nombre + "', NombreEscuela = '" + unAlumno.Escuela+ "', FechaNacimiento = '" + FormatearFecha(unAlumno.FechaNacimiento)+ "', Telefono = '" + unAlumno.Telefono + "', Correo = '" + unAlumno.Correo + "', Activo = '" + (unAlumno.Activo?"1":"0") + "', Tutor = '" + unAlumno.Tutor + "'  WHERE NumeroControl = '" + strNroControl + "'", con);
                    comando.ExecuteNonQuery();
            }
        }
        
        public static List<Alumno> CargarAlumnosFiltrados(Filtro unFiltro) //Pendiente de agregar filtros
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ALUMNO " + unFiltro.ToString(), con);
                SqlDataReader alumnos = comando.ExecuteReader();
                while (alumnos.Read())
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7)));
            }
            return listaAlumnos;
        }
        #endregion

        #region RegistroPago
        public static List<Alumno> CargarAlumnos(string strNombreEscuela)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ALUMNO where NombreEscuela = '"+strNombreEscuela+"'", con);
                SqlDataReader alumnos = comando.ExecuteReader();
                while (alumnos.Read())
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7)));
            }
            return listaAlumnos;
        }

        public static void AgregarPago(Pagos unPago, Alumno unAlumno)
        {            
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PAGO VALUES ('"+unPago.NumeroRecibo+ "', '" + unAlumno.NumeroDeControl + "', '" + unPago.Monto + "', '" + unPago.MesPagado + "', '" + FormatearFecha(unPago.FechayHora) + "', '" + unPago.MetodoPago + "', '" + unPago.Nota + "', '" + (unPago.Notificado?1:0) + "')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Pagos> CargarPagosAlumno(string strNumeroControl)
        {
            List<Pagos> listaPagos = new List<Pagos>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PAGO WHERE NumeroControl = '"+strNumeroControl+"'", con);
                SqlDataReader pagos = comando.ExecuteReader();
                while (pagos.Read())
                    listaPagos.Add(new Pagos(pagos.GetString(0), pagos.GetDateTime(4),double.Parse(Convert.ToString(pagos.GetSqlMoney(2))), pagos.GetString(6), pagos.GetString(3), pagos.GetString(5), (pagos.GetInt32(7)==1?true:false)));
            }
            return listaPagos;
        }

        public static List<Pagos> CargarPagos()
        {
            List<Pagos> listaPagos = new List<Pagos>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PAGO ", con);
                SqlDataReader pagos = comando.ExecuteReader();
                while (pagos.Read())
                    listaPagos.Add(new Pagos(pagos.GetString(0), pagos.GetDateTime(4), double.Parse(Convert.ToString(pagos.GetSqlMoney(2))), pagos.GetString(6), pagos.GetString(3), pagos.GetString(5), (pagos.GetInt32(7) == 1 ? true : false)));
            }
            return listaPagos;
        }

        public static void ConfirmarEnvioCorreo(Pagos unPago)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                int intNotificado = unPago.Notificado ? 1 : 0;
                SqlCommand comando = new SqlCommand("UPDATE PAGO SET Notificado = "+intNotificado+" WHERE NumeroRecibo = '"+unPago.NumeroRecibo+"'", con);
                comando.ExecuteNonQuery();
            }
        }
        #endregion

        public static double TotalMensualidades(string strNombreEscuela)
        {
            double dblTotalMensualidades = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM PAGO, ALUMNO, CURSO  WHERE PAGO.NumeroControl = ALUMNO.NumeroControl AND ALUMNO.NombreEscuela = CURSO.NombreEscuela  AND MesPagado != 'Inscripcion' AND CURSO.Activo = 1 AND CURSO.NombreEscuela = '"+strNombreEscuela+"' ", con);
                SqlDataReader mensualidades = comando.ExecuteReader();
                while (mensualidades.Read())
                {
                    if (!mensualidades.IsDBNull(0))                    
                        dblTotalMensualidades = double.Parse(Convert.ToString(mensualidades.GetSqlMoney(0)));                    
                }   
            }
            return dblTotalMensualidades;
        }

        public static double TotalInscripciones(string strNombreEscuela)
        {
            double dblTotalInscripciones = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM PAGO, ALUMNO, CURSO  WHERE PAGO.NumeroControl = ALUMNO.NumeroControl AND ALUMNO.NombreEscuela = CURSO.NombreEscuela  AND MesPagado = 'Inscripcion' AND CURSO.Activo = 1 AND CURSO.NombreEscuela = '" + strNombreEscuela + "' ", con);
                SqlDataReader inscripciones = comando.ExecuteReader();
                while (inscripciones.Read())
                {
                    if (!inscripciones.IsDBNull(0))
                        dblTotalInscripciones = double.Parse(Convert.ToString(inscripciones.GetSqlMoney(0)));
                }
            }
            return dblTotalInscripciones;
        }


    }
}
