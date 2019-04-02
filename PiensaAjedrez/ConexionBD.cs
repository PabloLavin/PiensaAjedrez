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
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7L6CITQ7; Initial Catalog = PIENSAJEDREZ; Server=LAPTOP-7L6CITQ7\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");            
            con.Open();
            return (con);
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
                    throw new Exception("No es posible cambiarle el nombre a una escuela que ya tiene cursos registrados o ponerle el nombre de otra ya registrada.");
                }
                
            }
        }

        public static void AgregarCurso(string strNombreEscuela, DateTime FechaInicio, DateTime FechaFinal)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                string strClave = FechaInicio.Month.ToString() + FechaFinal.Month.ToString() + new Random().Next(10, 500);
                string strQuery = @"IF NOT(EXISTS(SELECT * FROM CURSO WHERE Activo = 1 AND NombreEscuela = '"+strNombreEscuela+"')) BEGIN INSERT INTO CURSO VALUES('"+strClave+"', '"+strNombreEscuela+"', '"+FechaInicio.Year + "-" +FechaInicio.Month + "-" + FechaInicio.Day+ "', '" + FechaFinal.Year + "-" + FechaFinal.Month + "-" + FechaFinal.Day + "', 1) END ELSE RAISERROR('Ya existe un curso activo para este colegio. Debe finalizarlo.', 16, 1) ";
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
                SqlCommand comando = new SqlCommand("UPDATE CURSO SET InicioCurso = '" + FechaInicio.Year + "-" + FechaInicio.Month + "-" + FechaInicio.Day+ "', FinCurso = '" + FechaFinal.Year + "-" + FechaFinal.Month + "-" + FechaFinal.Day + "' WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "'", con);
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
         
    }
}
