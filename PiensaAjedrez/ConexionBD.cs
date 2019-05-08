﻿using System;
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
            //SqlConnection con = new SqlConnection(@"Data Source=LAVINW8; Initial Catalog = PIENSAJEDREZ; Server=LAVINW8\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");            
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-7L6CITQ7; Initial Catalog = PIENSAJEDREZ; Server=LAPTOP-7L6CITQ7\SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");
            //SqlConnection con = new SqlConnection(@"Data Source=ANCIRALAPTOP; Initial Catalog = PIENSAJEDREZ; Server=ANCIRALAPTOP\TEW_SQLEXPRESS; Integrated Security = SSPI; Trusted_Connection=True; MultipleActiveResultSets=True");

            con.Open();
            return (con);
        }

        public static string FormatearFecha(DateTime unaFecha)
        {
            //return unaFecha.Year + "-" + unaFecha.Day + "-" + unaFecha.Month;//Formato de Pablo
            return unaFecha.Year + "-" + unaFecha.Month + "-" + unaFecha.Day;   //Formato de los WWEYES
        }

        public static void AgregarEscuela(string strEscuela)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO ESCUELA VALUES ('" + strEscuela + "', '" + 0 + "')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Escuela> CargarEscuelas()
        {
            List<Escuela> listaEscuelas = new List<Escuela>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM ESCUELA", con);
                SqlDataReader escuelas = comando.ExecuteReader();
                while (escuelas.Read())
                    listaEscuelas.Add(new Escuela(escuelas.GetString(0), (escuelas.GetInt16(1) == 1 ? true : false)));
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

        public static void ActualizarGrado(string strNombre, bool blnActualizado)
        {
            using (SqlConnection con = ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand("UPDATE ESCUELA SET GradoActualizado = '" + (blnActualizado ? 1 : 0) + "' WHERE NombreEscuela = '" + strNombre + "'", con);
                comando.ExecuteNonQuery();


            }
        }

        public static void AgregarCurso(string strNombreEscuela, DateTime FechaInicio, DateTime FechaFinal, string strDiaclase)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                string strClave = FechaInicio.Month.ToString() + FechaFinal.Month.ToString() + new Random().Next(10, 500);
                string strQuery = @"IF NOT(EXISTS(SELECT * FROM CURSO WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "')) BEGIN INSERT INTO CURSO VALUES('" + strClave + "', '" + strNombreEscuela + "', '" + FormatearFecha(FechaInicio) + "', '" + FormatearFecha(FechaFinal) + "', 1, '"+strDiaclase+"') END ELSE RAISERROR('Ya existe un curso activo para este colegio. Debe finalizarlo.', 16, 1) ";
                SqlCommand comando = new SqlCommand(strQuery, con);
                comando.ExecuteNonQuery();
            }
        }

        public static Cursos CargarCursoActivo(string strNombreEscuela)
        {
            Cursos unCurso = null;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM CURSO WHERE Activo = 1 AND NombreEscuela ='" + strNombreEscuela + "'", con);
                SqlDataReader curso = comando.ExecuteReader();
                while (curso.Read())
                {
                    unCurso = new Cursos(curso.GetDateTime(2), curso.GetDateTime(3));
                    unCurso.Clave = curso.GetString(0);
                    unCurso.Activo = true;
                    unCurso.listaActividades = CargarActividades(unCurso.Clave);
                    unCurso.DiaDeClase = curso.GetString(5);
                }
            }
            return unCurso;
        }

        public static void ActualizarDatosCurso(string strNombreEscuela, DateTime FechaInicio, DateTime FechaFinal, string strDiaClase)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("UPDATE CURSO SET InicioCurso = '" + FormatearFecha(FechaInicio) + "', FinCurso = '" + FormatearFecha(FechaFinal) + "', DiaClase = '"+strDiaClase+"' WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "'", con);
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
                string strClave = strNombreEscuela.Substring(0, 1) + strNombreActividad.Substring(0, 1) + new Random().Next(10, 500);
                SqlCommand comando = new SqlCommand("INSERT INTO ACTIVIDAD VALUES ('" + strClave + "', '" + strNombreActividad + "', (SELECT IDCurso FROM CURSO WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "'))", con);
                comando.ExecuteNonQuery();
            }
        }

        public static void EliminarActividad(string strNombreEscuela, string strNombreActividad)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("DELETE FROM ACTIVIDAD WHERE Nombre = '" + strNombreActividad + "' AND IDCurso = (SELECT IDCurso FROM CURSO WHERE Activo = 1 AND NombreEscuela = '" + strNombreEscuela + "')", con);
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
                SqlCommand comando = new SqlCommand("SELECT * FROM ACTIVIDAD WHERE IDCurso = '" + IDCurso + "'", con);
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
                SqlCommand comando = new SqlCommand("INSERT INTO ALUMNO VALUES ('" + unAlumno.NumeroDeControl + "','" + unAlumno.Nombre + "','" + unAlumno.Escuela + "', '" + FormatearFecha(unAlumno.FechaNacimiento) + "', '" + unAlumno.Telefono + "', '" + unAlumno.Correo + "', '" + (unAlumno.Activo ? "1" : "0") + "', '" + unAlumno.Tutor + "',  '" + unAlumno.ApellidoPaterno + "',  '" + unAlumno.ApellidoMaterno + "',  '" + unAlumno.Grado + "')", con);
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
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7), alumnos.GetString(8), alumnos.GetString(9), alumnos.GetInt16(10)));
            }
            return listaAlumnos;
        }

        public static void EditarAlumno(string strNroControl, Alumno unAlumno)
        {
            using (SqlConnection con = ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand("UPDATE ALUMNO SET Nombre = '" + unAlumno.Nombre + "', NombreEscuela = '" + unAlumno.Escuela + "', FechaNacimiento = '" + FormatearFecha(unAlumno.FechaNacimiento) + "', Telefono = '" + unAlumno.Telefono + "', Correo = '" + unAlumno.Correo + "', Activo = '" + (unAlumno.Activo ? "1" : "0") + "', Tutor = '" + unAlumno.Tutor + "', ApellidoPaterno = '" + unAlumno.ApellidoPaterno + "', ApellidoMaterno = '" + unAlumno.ApellidoMaterno + "', Grado = '" + unAlumno.Grado + "'  WHERE NumeroControl = '" + strNroControl + "'", con);
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
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7), alumnos.GetString(8), alumnos.GetString(9), alumnos.GetInt16(10)));
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
                SqlCommand comando = new SqlCommand("SELECT * FROM ALUMNO where NombreEscuela = '" + strNombreEscuela + "' ORDER BY APELLIDOPATERNO, APELLIDOMATERNO, NOMBRE, NUMEROCONTROL ", con);
                SqlDataReader alumnos = comando.ExecuteReader();
                while (alumnos.Read())
                    listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(1), alumnos.GetString(2), alumnos.GetDateTime(3), alumnos.GetString(4), alumnos.GetString(5), alumnos.GetInt16(6), alumnos.GetString(7), alumnos.GetString(8), alumnos.GetString(9), alumnos.GetInt16(10)));
            }
            return listaAlumnos;
        }

        public static List<Alumno> CargarAlumnosOrdenados(string strNombreEscuela)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("select DISTInct Pago.NumeroControl, PAGO.NumeroRecibo, ALUMNO.* from PAGO, ALUMNO where ALUMNO.NombreEscuela='"+strNombreEscuela+"' AND ALUMNO.NumeroControl = PAGO.NumeroControl Order by PAGO.NumeroRecibo DESC", con);
                SqlDataReader alumnos = comando.ExecuteReader();
                while (alumnos.Read())
                {
                    if(!listaAlumnos.Contains(new Alumno(alumnos.GetString(0))))
                     listaAlumnos.Add(new Alumno(alumnos.GetString(0), alumnos.GetString(3), alumnos.GetString(4), alumnos.GetDateTime(5), alumnos.GetString(6), alumnos.GetString(7), alumnos.GetInt16(8), alumnos.GetString(9), alumnos.GetString(10), alumnos.GetString(11), alumnos.GetInt16(12)));
                }
                    foreach (Alumno unAlumno in CargarAlumnos(strNombreEscuela))
                    {
                        if (!listaAlumnos.Contains(unAlumno))
                            listaAlumnos.Add(unAlumno);
                 
                    }
                
            }
            return listaAlumnos;
        }

        public static void AgregarPago(Pagos unPago, Alumno unAlumno)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO PAGO VALUES ('" + unPago.NumeroRecibo + "', '" + unAlumno.NumeroDeControl + "', '" + unPago.Monto + "', '" + unPago.MesPagado + "', '" + FormatearFecha(unPago.FechayHora) + "', '" + unPago.MetodoPago + "', '" + unPago.Nota + "', '" + (unPago.Notificado ? 1 : 0) + "', '" + (unPago.Liquidado ? 1 : 0) + "', '" + unPago.IDCurso + "')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Pagos> CargarPagosAlumno(string strNumeroControl)
        {
            List<Pagos> listaPagos = new List<Pagos>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM PAGO WHERE NumeroControl = '" + strNumeroControl + "'", con);
                SqlDataReader pagos = comando.ExecuteReader();
                while (pagos.Read())
                    listaPagos.Add(new Pagos(pagos.GetString(0), pagos.GetDateTime(4), double.Parse(Convert.ToString(pagos.GetSqlMoney(2))), pagos.GetString(6), pagos.GetString(3), pagos.GetString(5), (pagos.GetInt16(7) == 1 ? true : false), (pagos.GetInt16(8) == 1 ? true : false), pagos.GetString(9)));
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
                    listaPagos.Add(new Pagos(pagos.GetString(0), pagos.GetDateTime(4), double.Parse(Convert.ToString(pagos.GetSqlMoney(2))), pagos.GetString(6), pagos.GetString(3), pagos.GetString(5), (pagos.GetInt16(7) == 1 ? true : false), (pagos.GetInt16(8) == 1 ? true : false),pagos.GetString(9)));
            }
            return listaPagos;
        }

        public static void ConfirmarEnvioCorreo(Pagos unPago)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                int intNotificado = unPago.Notificado ? 1 : 0;
                SqlCommand comando = new SqlCommand("UPDATE PAGO SET Notificado = " + intNotificado + " WHERE NumeroRecibo = '" + unPago.NumeroRecibo + "'", con);
                comando.ExecuteNonQuery();
            }
        }
        #endregion

        public static double TotalMensualidades(string strNombreEscuela)
        {
            double dblTotalMensualidades = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM PAGO, ALUMNO, CURSO  WHERE PAGO.NumeroControl = ALUMNO.NumeroControl AND ALUMNO.NombreEscuela = CURSO.NombreEscuela  AND MesPagado != 'Inscripcion' AND CURSO.Activo = 1 AND CURSO.NombreEscuela = '" + strNombreEscuela + "' ", con);
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
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM PAGO, ALUMNO, CURSO  WHERE PAGO.NumeroControl = ALUMNO.NumeroControl AND ALUMNO.NombreEscuela = CURSO.NombreEscuela  AND MesPagado = 'Inscripcion' AND CURSO.Activo = 1 AND CURSO.NombreEscuela = '" + strNombreEscuela + "' AND PAGO.IDCurso ='"+ConexionBD.CargarCursoActivo(strNombreEscuela).Clave+"' ", con);
                SqlDataReader inscripciones = comando.ExecuteReader();
                while (inscripciones.Read())
                {
                    if (!inscripciones.IsDBNull(0))
                        dblTotalInscripciones = double.Parse(Convert.ToString(inscripciones.GetSqlMoney(0)));
                }
            }
            return dblTotalInscripciones;
        }

        public static void RegistrarGasto(string strRazon, double dblMonto, string strNota, string strNombreEscuela, DateTime dtpFecha, string strIDCurso)
        {
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("INSERT INTO GASTO VALUES ((SELECT COUNT(*) + 1 FROM GASTO), '" + strRazon + "', " + dblMonto + ", '" + strNota + "', '" + strNombreEscuela + "','" + FormatearFecha(dtpFecha) + "', '"+strIDCurso+"')", con);
                comando.ExecuteNonQuery();
            }
        }

        public static double TotalGastos()
        {
            double dblTotalMensualidades = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM GASTO", con);
                SqlDataReader gastos = comando.ExecuteReader();
                while (gastos.Read())
                {
                    if (!gastos.IsDBNull(0))
                        dblTotalMensualidades = double.Parse(Convert.ToString(gastos.GetSqlMoney(0)));
                }
            }
            return dblTotalMensualidades;
        }

        public static double TotalIngresos()
        {
            double dblTotalMensualidades = 0;
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT SUM(Monto)FROM PAGO", con);
                SqlDataReader gastos = comando.ExecuteReader();
                while (gastos.Read())
                {
                    if (!gastos.IsDBNull(0))
                        dblTotalMensualidades = double.Parse(Convert.ToString(gastos.GetSqlMoney(0)));
                }
            }
            return dblTotalMensualidades;
        }

        public static void EditarPago(Pagos unPago, bool blnLiquidado, string strNumeroControl, double dblMonto)
        {
            using (SqlConnection con = ObtenerConexion())
            {

                SqlCommand comando = new SqlCommand("UPDATE PAGO SET Monto = '" + (dblMonto + unPago.Monto) + "',  Liquidado = '" + (blnLiquidado ? 1 : 0) + "', Nota = '" + unPago.Nota + "'  WHERE NumeroControl = '" + strNumeroControl + "' AND MesPagado = '" + unPago.MesPagado + "' AND Monto = '" + dblMonto + "'", con);
                comando.ExecuteNonQuery();
            }
        }

        public static List<Gastos> CargarGastos()
        {
            List<Gastos> listaPagos = new List<Gastos>();
            using (SqlConnection con = ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand("SELECT * FROM GASTO ORDER BY FECHAHORA DESC, MONTO DESC ", con);
                SqlDataReader pagos = comando.ExecuteReader();
                while (pagos.Read())
                    listaPagos.Add(new Gastos(pagos.GetString(1), double.Parse(Convert.ToString(pagos.GetSqlMoney(2))), pagos.GetString(3), pagos.GetDateTime(5), pagos.GetString(6)));
            }
            return listaPagos;

        }
    }
}