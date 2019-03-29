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
            SqlConnection con = new SqlConnection(@"Data Source=LA-DIVERTIDA; Initial Catalog = PIENSAJEDREZ; Server=LA-DIVERTIDA\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");            
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
                SqlCommand comando = new SqlCommand("UPDATE ESCUELA SET NombreEscuela = '"+strNuevoNombre+"' WHERE NombreEscuela = '"+strNombreOriginal+"'", con);
                comando.ExecuteNonQuery();
            }
        }
    }
}
