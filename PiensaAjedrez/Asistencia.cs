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
            for (int i = 0; i < 5; i++)
            {
                dgvAlumnos.Columns[i].Frozen=true;
            }
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
                    }

                }
        }
    }
}
