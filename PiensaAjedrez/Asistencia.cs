﻿using System;
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
    public partial class Asistencia : UserControl
    {
        public Asistencia()
        {
            InitializeComponent();
        }

        private void Asistencia_Load(object sender, EventArgs e)
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                cbEscuelas.AddItem(unaEscuela.Nombre);
            }
            if (ConexionBD.CargarEscuelas().Count > 0)
                cbEscuelas.selectedIndex = 0;
        }

        void CargarDGV(Escuela unaEscuela)
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            dgvAlumnos.Columns.Add("N°.", "N°");
            dgvAlumnos.Columns.Add("N° de ctrl.", "N° de ctrl.");
            dgvAlumnos.Columns.Add("ApellidoP", "Apellido P");
            dgvAlumnos.Columns.Add("Apellido M", "Apellido M");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");

            if (unaEscuela.CursoActivo == null)
            {
                MessageBox.Show(unaEscuela.Nombre + " no contiene ningún curso actualmente.\nAgregue uno para continuar.");
                return;
            }

            List<string> listaFechas = CargarFechas(unaEscuela.CursoActivo);
            foreach (string Fechas in listaFechas)
            {
                dgvAlumnos.Columns.Add(Fechas, Fechas);
            }
            
            if(dgvAlumnos.Columns.Count>10)
                dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            else
                dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            for (int i = 0; i < 5; i++)
            {
                dgvAlumnos.Columns[i].Frozen = true;
            }
        }

        List<string> CargarFechas(Cursos unCurso)
        {
            List<string> listaFechas = new List<string>();
            DateTime dtmFecha = unCurso.InicioCursos;
            while (dtmFecha<unCurso.FinCurso)
            {
                if (dtmFecha.DayOfWeek.ToString() ==ObtenerDia(unCurso.DiaDeClase))
                {
                    listaFechas.Add(dtmFecha.Date.ToShortDateString());
                    
                }
               dtmFecha= dtmFecha.AddDays(1);
            }
            return listaFechas;
        }

        string ObtenerDia(string strDia)
        {
            switch (strDia)
            {
                case "Lunes": return "Monday";
                case "Martes": return "Tuesday";
                case "Miercoles": return "Wednesday";
                case "Jueves": return "Thursday";
                case "Viernes": return "Friday";
                case "Sabado": return "Saturday";
                case "Domingo": return "Sunday";
                default: return "";
            }
        }

        private void cbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            if (ConexionBD.CargarEscuelas().Count > 0)
                foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                {
                    if (cbEscuelas.selectedValue == miEscuela.Nombre)
                    {
                        if (miEscuela.CursoActivo == null)
                        {
                            miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                        }
                            CargarDGV(miEscuela);
                        llenarDGV(miEscuela);
                    }

                }
        }

        void llenarDGV(Escuela unaEscuela)
        {
            dgvAlumnos.Rows.Clear();
            int intContador = 1;
            foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
            {
                
                if (unAlumno.Activo)
                {
                dgvAlumnos.Rows.Add(intContador, unAlumno.NumeroDeControl, unAlumno.Nombre, unAlumno.ApellidoPaterno, unAlumno.ApellidoMaterno);
                    RellenarCheckBox(unAlumno.NumeroDeControl);
                    RellenarAsistencia(unAlumno, unaEscuela.CursoActivo.Clave);
                    intContador++;
                }
                
            }
        }

        void RellenarCheckBox(string strNumeroDeControl)
        {
            foreach (DataGridViewRow fila in dgvAlumnos.Rows)
            {
                if (strNumeroDeControl.Equals(fila.Cells[1].Value.ToString()))
                {
                    for (int i = 5; i < dgvAlumnos.Columns.Count; i++)
                    {
                        //dgvAlumnos.Rows.Cells[i]
                    }
                }
            }
        }

        void RellenarAsistencia(Alumno miAlumno, string strCurso)
        {
            //    foreach (ClaseAsistencia unaAsistencia in ConexionBD.CargarAsistencia(miAlumno, strCurso))
            //    {
            //        if (unaAsistencia.IDCurso.Equals(strCurso))
            //            foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
            //            {
            //                if (unaAsistencia.Fecha.ToShortDateString().Equals(columna.HeaderText))
            //                {
            //                    foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
            //                    {
            //                        if (miAlumno.NumeroDeControl.Equals(Fila.Cells[1].Value.ToString()))
            //                        {

            //                        }
            //                    }
            //                }
            //            }
        //}
}
    }
}
