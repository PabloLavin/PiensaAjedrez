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

        bool blnAceptar;

        void CargarDGV(Escuela unaEscuela)
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            dgvAlumnos.Columns.Add("N°.", "N°");
            dgvAlumnos.Columns.Add("N° de ctrl.", "N° de ctrl.");
            dgvAlumnos.Columns.Add("ApellidoP", "Apellido P");
            dgvAlumnos.Columns.Add("Apellido M", "Apellido M");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvAlumnos.ColumnHeadersHeight = 50;

            dgvAlumnos.CellPainting += new DataGridViewCellPaintingEventHandler(DgvAlumnos_CellPainting);
            if (unaEscuela.CursoActivo == null)
            {
              unaForma.Mostrar("Error",unaEscuela.Nombre + " no contiene ningún curso actualmente.\nAgregue uno para continuar.",1,this);
                return;
            }

            List<string> listaFechas = CargarFechas(unaEscuela.CursoActivo);

            foreach (string Fechas in listaFechas)
            {

                dgvAlumnos.Columns.Add(Fechas, Fechas);

            }


            //if (dgvAlumnos.Columns.Count > 10)
                dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //else
            //    dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            

            for (int i = 5; i < dgvAlumnos.Columns.Count; i++)
            {
                dgvAlumnos.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            }
            for (int i = 0; i < 5; i++)
            {
                dgvAlumnos.Columns[i].Frozen = true;
            }
        }

        List<string> CargarFechas(Cursos unCurso)
        {
            List<string> listaFechas = new List<string>();
            if (unCurso != null)
            {


                DateTime dtmFecha = unCurso.InicioCursos;
                while (dtmFecha < unCurso.FinCurso)
                {
                    if (dtmFecha.DayOfWeek.ToString() == ObtenerDia(unCurso.DiaDeClase))
                    {
                        listaFechas.Add(dtmFecha.Date.ToShortDateString());

                    }
                    dtmFecha = dtmFecha.AddDays(1);
                }
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
                        cbFechas.Clear();
                        CargarCBFechas(miEscuela.CursoActivo);
                        if (CargarFechas(miEscuela.CursoActivo).Count > 0)
                            cbFechas.selectedIndex = 0;

                    }

                }
        }

        void CargarCBFechas(Cursos unCurso)
        {
            List<string> listaFechas = CargarFechas(unCurso);
            foreach (string fecha in listaFechas)
            {
                cbFechas.AddItem(fecha);
            }
        }

        void llenarDGV(Escuela unaEscuela)
        {
            if (unaEscuela.CursoActivo != null)
            {
                dgvAlumnos.Rows.Clear();
                int intContador = 1;
                foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
                {

                    if (unAlumno.Activo)
                    {
                        dgvAlumnos.Rows.Add(intContador, unAlumno.NumeroDeControl, unAlumno.ApellidoPaterno, unAlumno.ApellidoMaterno, unAlumno.Nombre);
                        RellenarAsistencia(unAlumno, unaEscuela.CursoActivo.Clave);
                        intContador++;
                    }

                }
            }
        }



        void RellenarAsistencia(Alumno miAlumno, string strCurso)
        {
            foreach (ClaseAsistencia unaAsistencia in ConexionBD.CargarAsistencia(miAlumno, strCurso))
            {
                if (unaAsistencia.IDCurso.Equals(strCurso))
                    foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                    {
                        if (unaAsistencia.Fecha.ToShortDateString().Equals(columna.HeaderText))
                        {
                            foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
                            {
                                if (miAlumno.NumeroDeControl.Equals(Fila.Cells[1].Value.ToString()))
                                {
                                    dgvAlumnos.Rows[Fila.Index].Cells[columna.Index].Value = 1;
                                }
                            }
                        }

                    }
            }
            foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
            {
                foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
                {
                    if (miAlumno.NumeroDeControl.Equals(Fila.Cells[1].Value.ToString()))
                    {
                        if (dgvAlumnos.Rows[Fila.Index].Cells[columna.Index].Value == null)
                            dgvAlumnos.Rows[Fila.Index].Cells[columna.Index].Value = 0;
                    }
                }
            }
        }


        private void dgvAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex == -1)
            //{
            //    return;
            //}
            //if (e.ColumnIndex >= 5)
            //{
            //    string strFecha = "";
            //    foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            //    {
            //        if (cbEscuelas.selectedValue == unaEscuela.Nombre)
            //        {
            //            unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
            //            foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
            //            {
            //                if (miAlumno.NumeroDeControl == dgvAlumnos.CurrentRow.Cells[1].Value.ToString())
            //                {
            //                    foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
            //                    {
            //                        if (columna.Index == dgvAlumnos.CurrentCell.ColumnIndex)
            //                        {
            //                            strFecha = columna.HeaderText;
            //                        }
            //                    }
            //                    ClaseAsistencia unaAsistencia = new ClaseAsistencia(unaEscuela.CursoActivo.Clave, DateTime.Parse(strFecha));
            //                    if (Convert.ToBoolean(dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue) == true)
            //                    {
            //                        dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            //                        ConexionBD.AgregarAsistencia(unaAsistencia, miAlumno.NumeroDeControl, unaEscuela.Nombre, false);
            //                    }

            //                    else
            //                    {
            //                        dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            //                        ConexionBD.AgregarAsistencia(unaAsistencia, miAlumno.NumeroDeControl, unaEscuela.Nombre, true);
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}

        }


        ClaseAsistencia CapturarAsistencias()
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                if (cbEscuelas.selectedValue == unaEscuela.Nombre)
                {
                    return new ClaseAsistencia(ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave, DateTime.Parse(cbFechas.selectedValue));
                }
            }

            return new ClaseAsistencia();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (cbFechas.selectedIndex == -1)
            {
                unaForma.Mostrar("Error","No hay fecha seleccionada.\nSeleccione una para continuar",1,this);
                return;
            }
            if (Preguntar("Asistencia Alumnos", "¿Desea marcar a todos los alumnos del colegio " + cbEscuelas.selectedValue + " en la fecha " + cbFechas.selectedValue + "?"))
                foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                {
                    foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                    {
                        if (columna.HeaderText == cbFechas.selectedValue)
                        {
                            dgvAlumnos.Rows[fila.Index].Cells[columna.Index].Value = 1;
                            ConexionBD.AgregarAsistencia(CapturarAsistencias(), fila.Cells[1].Value.ToString(), cbEscuelas.selectedValue, true);
                        }
                    }
                }
        }

        private void BtnDesmarcar_Click(object sender, EventArgs e)
        {
            if (cbFechas.selectedIndex == -1)
            {
                unaForma.Mostrar("Error","No hay fecha seleccionada.\nSeleccione una para continuar",1,this);
                return;
            }
            if (Preguntar("Asistencia Alumnos", "¿Desea retirar la marca de todos los alumnos del colegio " + cbEscuelas.selectedValue + " en la fecha " + cbFechas.selectedValue + "?"))
                foreach (DataGridViewRow fila in dgvAlumnos.Rows)
                {
                    foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                    {
                        if (columna.HeaderText == cbFechas.selectedValue)
                        {
                            dgvAlumnos.Rows[fila.Index].Cells[columna.Index].Value = 0;
                            ConexionBD.AgregarAsistencia(CapturarAsistencias(), fila.Cells[1].Value.ToString(), cbEscuelas.selectedValue, false);

                        }
                    }
                }
        }

        private void ChkNombre_OnChange(object sender, EventArgs e)
        {
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) == null)
                return;
            if (chkNombre.Checked)
            {
                txtFiltroNombre.Enabled = true;
                txtFiltroNombre.Text = "";
            }
            else
            {
                txtFiltroNombre.Enabled = false;
                txtFiltroNombre.Text = "Nombre";
                foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                {
                    if (unaEscuela.Nombre == cbEscuelas.selectedValue)
                    {
                        unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
                        llenarDGV(unaEscuela);
                    }
                }
            }
        }

        private void ChkCorreo_OnChange(object sender, EventArgs e)
        {
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) == null)
                return;
            if (chkCorreo.Checked)
            {
                txtFiltroNoCtrl.Enabled = true;
                txtFiltroNoCtrl.Text = "";
            }
            else
            {
                txtFiltroNoCtrl.Enabled = false;
                txtFiltroNoCtrl.Text = "Número de Control";
                foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                {
                    if (unaEscuela.Nombre == cbEscuelas.selectedValue)
                    {
                        unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
                        llenarDGV(unaEscuela);
                    }
                }
            }
        }

        private void Filtrar()
        {
            Filtro unFiltro = new Filtro();

            unFiltro.NumeroControl = chkCorreo.Checked;

            unFiltro.Escuela = true;

            unFiltro.Nombre = chkNombre.Checked;


            if (cbEscuelas.selectedIndex >= 0)
                unFiltro.ValorEscuela = cbEscuelas.selectedValue;

            unFiltro.ValorFecha = DateTime.Now;



            unFiltro.ValorNombre = txtFiltroNombre.Text;
            unFiltro.ValorNoControl = txtFiltroNoCtrl.Text;
            int intContador = 0;
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in ConexionBD.CargarAlumnosFiltrados(unFiltro))
            {
                if (miAlumno.Activo && miAlumno.Escuela == cbEscuelas.selectedValue)
                {
                    intContador++;
                    dgvAlumnos.Rows.Add(intContador, miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                    RellenarAsistencia(miAlumno, ConexionBD.CargarCursoActivo(miAlumno.Escuela).Clave);
                }
            }

        }

        private void TxtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltroNoCtrl_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void DgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1&&e.ColumnIndex>=5)
            {
                //if (DialogResult.Yes == MessageBox.Show("¿Desea cerrar la asistencia al colegio " + cbEscuelas.selectedValue + " en la fecha " + cbFechas.selectedValue + "?", "Asistencia Alumnos", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                //{
                //    dgvAlumnos.Columns[e.ColumnIndex].Visible = false;
                    
                    return;
                //}
                }


            
            if (e.ColumnIndex >= 5)
            {
                string strFecha = "";
                foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                {
                    if (cbEscuelas.selectedValue == unaEscuela.Nombre)
                    {
                        unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
                        foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
                        {
                            if (miAlumno.NumeroDeControl == dgvAlumnos.CurrentRow.Cells[1].Value.ToString())
                            {
                                foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                                {
                                    if (columna.Index == dgvAlumnos.CurrentCell.ColumnIndex)
                                    {
                                        strFecha = columna.HeaderText;
                                    }
                                }
                                ClaseAsistencia unaAsistencia = new ClaseAsistencia(unaEscuela.CursoActivo.Clave, DateTime.Parse(strFecha));
                                if ((int)dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == 0)
                                {
                                    dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 1;
                                    ConexionBD.AgregarAsistencia(unaAsistencia, miAlumno.NumeroDeControl, unaEscuela.Nombre, true);
                                }

                                else
                                {
                                    dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                                    ConexionBD.AgregarAsistencia(unaAsistencia, miAlumno.NumeroDeControl, unaEscuela.Nombre, false);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void DgvAlumnos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (e.RowIndex == -1 && e.ColumnIndex >= 5)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvAlumnos.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), e.CellStyle.Font);
                if (this.dgvAlumnos.ColumnHeadersHeight < titleSize.Width)
                {
                    this.dgvAlumnos.ColumnHeadersHeight = titleSize.Width;
                }

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);


                e.Graphics.DrawString(e.Value.ToString(), new Font("Century Gothic", 12.0f), Brushes.White, new PointF(rect.Y - (dgvAlumnos.ColumnHeadersHeight - titleSize.Width), rect.X ));
                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            }
           
        }

        FormMensaje unaForma = new FormMensaje();

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            blnAceptar = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 2, this);
            blnAceptar = unaForma.Aceptar();
            return blnAceptar;
        }
    }
}
