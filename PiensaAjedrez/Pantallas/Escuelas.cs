using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PiensaAjedrez
{
    public partial class Escuelas : UserControl
    {
        public Escuelas()
        {
            InitializeComponent();

            dgvEscuelas.Columns.Add("Nombre del colegio", "Nombre del colegio");

            dgvEscuelasDesactivadas.Columns.Add("Nombre del colegio", "Nombre del colegio");

            dgvCursos.Columns.Add("Clave", "Clave");
            dgvCursos.Columns.Add("Inicio del curso", "Inicio del curso");
            dgvCursos.Columns.Add("Fin del curso", "Fin del curso");

            dgvCursosPasados.Columns.Add("Clave", "Clave");
            dgvCursosPasados.Columns.Add("Inicio del curso", "Inicio del curso");
            dgvCursosPasados.Columns.Add("Fin del curso", "Fin del curso");

            dgvEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEscuelasDesactivadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursosPasados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCursos.Columns[0].Width = 86;
            dgvCursosPasados.Columns[0].Width = 86;

            cbDiaClase.Visible = false;
            bunifuCustomLabel3.Visible = false;
            bunifuCustomLabel4.Visible = false;
            tsDesactivarEscuela.Visible = true;

            btnAgregado.Visible = false;
            btnAgregadoCurso.Visible = false;
            btnAgregarCurso.Visible = false;
            btnAgregarActividad.Enabled = false;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarCurso.BackgroundImageLayout = ImageLayout.Stretch;
            tsDesactivarEscuela.Visible = true;
            contextMenuStrip1.Enabled = true;
            contextMenuStrip2.Enabled = false;
            tsEliminarActividad.Visible = false;
            dgvListaActividades.Columns.Add("Lista de actividades", "Lista de actividades");
            dgvListaActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnFinalizarCurso.Visible = false;
            MostrarDatos();
            dtmFinCurso.Value = DateTime.Today;
            dtmInicioCurso.Value = DateTime.Today;
            bunifuCards2.Visible = false;
            //btnActualizarGrados.Visible = false;

            InicializarAutorellenado();
           
            if (DateTime.Today.Month >= 1 && DateTime.Today.Month <= 7)
                ReiniciarGrados();
        }

        void InicializarAutorellenado()
        {
            var srcActividades = new AutoCompleteStringCollection();
           
            foreach (string actividad in ConexionBD.CargarActividades())
            {
                srcActividades.Add(actividad);
                
            }
            txtActividad.AutoCompleteCustomSource = srcActividades;
           

        }

        public static List<Escuela> listaEscuela = ConexionBD.CargarEscuelas();
        public FormMensaje unaForma = new FormMensaje();
        public bool blnAceptarEscuela;

        private void btnAgregarColegio_Click(object sender, EventArgs e)
        {
            if (txtNombreColegio.Text != "")
            {


                if (btnAgregarColegio.ButtonText == "Editar")
                {
                    try
                    {
                        ConexionBD.RenombrarEscuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString(), txtNombreColegio.Text);
                        MostrarDatos();
                        btnAgregarColegio.ButtonText = "Agregar";
                        txtNombreColegio.Text = "";
                        btnCancelar.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        unaForma.Mostrar("Error",ex.Message,1, this);
                    }
                }
                else
                {
                    try
                    {
                        ConexionBD.AgregarEscuela(txtNombreColegio.Text);
                        btnAgregado.Visible = true;
                        InitializeTimer();
                        txtNombreColegio.Text = "";
                        MostrarDatos();
                        dgvCursos.Rows.Clear();
                    }
                    catch (Exception)
                    {
                        unaForma.Mostrar("Error", "Escuela duplicada.", 1, this);
                        
                    }
                    txtNombreColegio.Focus();
                }
            }
            else
            {
                unaForma.Mostrar("Error", "Introduzca un nombre de colegio.", 1, this);
                
                return;
            }
        }

        void ReiniciarGrados()
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                ConexionBD.ActualizarGrado(unaEscuela.Nombre, false);
            }
        }

        void ActualizarGrados()
        {
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            {
                bool blnBandera = false;
                if (ConexionBD.CargarAlumnos(unaEscuela.Nombre).Count != 0)
                {
                    if (DateTime.Today.Month >=8 && !unaEscuela.GradoActualizado)
                    {
                       
                  
                        
                            if (Preguntar("Actualizar grados de alumnos", "¿Desea actualizar grados de los alumnos?"))
                            {
                                blnBandera = true;
                                foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
                                {
                                    if (unAlumno.Grado <= 7)
                                    {
                                        unAlumno.Grado++;
                                        ConexionBD.EditarAlumno(unAlumno.NumeroDeControl, unAlumno);
                                    }
                                }
                                if (blnBandera)
                                    ConexionBD.ActualizarGrado(unaEscuela.Nombre, true);
                            }
                            
                    }
                }
            }
        }

        void MostrarDatos()
        {
            dgvEscuelas.Rows.Clear();
            foreach (Escuela escuela in ConexionBD.CargarEscuelas())
                dgvEscuelas.Rows.Add(escuela.Nombre);
            dgvEscuelasDesactivadas.Rows.Clear();
            foreach (Escuela unaEscuela in ConexionBD.CargarEscuelasDesactivadas())
                dgvEscuelasDesactivadas.Rows.Add(unaEscuela.Nombre);
        }

        private int counter;
        Timer timer1 = new Timer();

        public void InitializeTimer()
        {
            counter = 0;
            timer1.Interval = 300;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(timer1_Tick);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 10)
            {
                timer1.Enabled = false;
                counter = 0;
                btnAgregado.Visible = false;
                btnAgregadoCurso.Visible = false;
            }
            else
            {
                counter += 1;
            }
        }

        private void btnAgregarCurso_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAgregarCurso.ButtonText == "Editar")
                {

                    btnFinalizarCurso.Visible = false;
                    string strUnaEscuela = dgvEscuelas.CurrentRow.Cells[0].Value.ToString();
                    ConexionBD.ActualizarDatosCurso(strUnaEscuela, dtmInicioCurso.Value, dtmFinCurso.Value, cbDiaClase.selectedValue.ToString());
                    btnAgregarCurso.ButtonText = "Agregar curso";
                    btnAgregadoCurso.Visible = true;
                    InitializeTimer();
                    dgvCursos.Rows.Clear();
                    btnCancelarCurso.Visible = false;
                    Cursos unCurso = ConexionBD.CargarCursoActivo(strUnaEscuela);
                    unCurso.listaActividades = ConexionBD.CargarActividades(unCurso.Clave);
                    foreach (string unaActivdad in unCurso.listaActividades)
                    {
                        ConexionBD.EliminarActividad(strUnaEscuela, unaActivdad);
                    }
                    for (int i = 0; i < dgvListaActividades.Rows.Count; i++)
                    {
                        ConexionBD.AgregarActividad(strUnaEscuela, dgvListaActividades.Rows[i].Cells[0].Value.ToString());
                    }
                    dgvCursos.Rows.Add(unCurso.Clave, unCurso.InicioCursos.ToLongDateString(), unCurso.FinCurso.ToLongDateString());
                    return;
                }
                contextMenuStrip1.Enabled = true;
                tsDesactivarEscuela.Visible = true;


                string strEscuela = dgvEscuelas.CurrentRow.Cells[0].Value.ToString();
                ConexionBD.AgregarCurso(strEscuela, dtmInicioCurso.Value, dtmFinCurso.Value, cbDiaClase.selectedValue.ToString());
                for (int i = 0; i < dgvListaActividades.Rows.Count; i++)
                {
                    ConexionBD.AgregarActividad(strEscuela, dgvListaActividades.Rows[i].Cells[0].Value.ToString());
                }
                dgvCursos.Rows.Clear();
                Cursos miCurso = ConexionBD.CargarCursoActivo(strEscuela);
                dgvCursos.Rows.Add(miCurso.Clave, miCurso.InicioCursos.ToLongDateString(), miCurso.FinCurso.ToLongDateString());
                btnAgregadoCurso.Visible = true;
                InitializeTimer();
            }
            catch (Exception x)
            {
                unaForma.Mostrar("Error", x.Message, 1, this);
            }
        }

        private void dgvEscuelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEscuelas.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "Seleccione una escuela de la lista.", 1, this);
                
                MostrarCursos(false);
                return;
            }
            if (btnAgregarCurso.ButtonText == "Editar")
            {
                btnAgregarCurso.ButtonText = "Agregar curso";
                btnAgregarCurso.IdleFillColor = Color.FromArgb(89, 162, 58);
                btnCancelarCurso.Visible = false;
                dgvListaActividades.Rows.Clear();
            }
            //btnActualizarGrados.Visible = true;
            dgvCursosPasados.Rows.Clear();
            MostrarCursos(true);
            btnFinalizarCurso.Visible = false;
            btnAgregarCurso.Visible = true;
            btnAgregarActividad.Enabled = true;
            btnAgregarColegio.ButtonText = "Editar";
            btnAgregarColegio.IdleFillColor = Color.FromArgb(89, 162, 58);
            btnCancelar.Visible = true;
            cbDiaClase.Visible = true;
            bunifuCustomLabel3.Visible = true;
            bunifuCustomLabel4.Visible = true;

            Escuela unaEscuela = new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString());
            unaEscuela.CursoActivo = ConexionBD.CargarCursoActivo(unaEscuela.Nombre);
            unaEscuela.listaCursos = ConexionBD.CargarCursos(unaEscuela.Nombre);
            txtNombreColegio.Text = unaEscuela.Nombre;
            dgvCursos.Rows.Clear();
            ComprobarCaducidad(unaEscuela);
            if (unaEscuela.CursoActivo != null)
                dgvCursos.Rows.Add(unaEscuela.CursoActivo.Clave, unaEscuela.CursoActivo.InicioCursos.ToLongDateString(), unaEscuela.CursoActivo.FinCurso.ToLongDateString());
            FillDgv(unaEscuela);
            txtActividad.Text = "";
            dgvListaActividades.Rows.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarCursos(false);
            txtNombreColegio.Text = "";
            bunifuCustomLabel3.Visible = false;
            bunifuCustomLabel4.Visible = false;
            btnAgregarColegio.ButtonText = "Agregar";
            btnAgregarColegio.IdleFillColor = Color.FromArgb(89, 162, 58);
            btnAgregarCurso.Visible = false;
            btnCancelar.Visible = false;
            dgvEscuelas.Focus();
            dgvCursos.Rows.Clear();
            dgvCursosPasados.Rows.Clear();
            btnCancelarCurso.Visible = false;
            btnFinalizarCurso.Visible = false;
            dgvListaActividades.Rows.Clear();

        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCursos.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "Seleccione un curso de la lista.", 2, this);
                
                return;
            }
            dtmInicioCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString());
            dtmFinCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[2].Value.ToString());
            dgvListaActividades.Rows.Clear();
            btnFinalizarCurso.Visible = false;

            cbDiaClase.Visible = true;

            contextMenuStrip1.Enabled = true;
            tsDesactivarEscuela.Visible = true;
            btnAgregarCurso.ButtonText = "Editar";
            btnCancelarCurso.Visible = true;
            btnAgregarCurso.IdleFillColor = Color.FromArgb(89, 162, 58);
            listaEscuela = ConexionBD.CargarEscuelas();
            foreach (Escuela miEscuela in listaEscuela)
            {
                miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                miEscuela.listaCursos = ConexionBD.CargarCursos(miEscuela.Nombre);
               
                if (miEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                {
                    foreach (Cursos miCursos in miEscuela.listaCursos)
                    {
                        cbDiaClase.selectedIndex = ObtenerIndex(miEscuela.CursoActivo.DiaDeClase);
                        miCursos.listaActividades = ConexionBD.CargarActividades(miCursos.Clave);

                        if (miCursos.Equals(new Cursos(dgvCursos.CurrentRow.Cells[0].Value.ToString())))
                        {
                            foreach (string actividad in miCursos.listaActividades)
                            {
                                dgvListaActividades.Rows.Add(actividad);
                            }
                            try
                            {
                                if (miEscuela.CursoActivo.Equals(miCursos))
                                {
                                    btnFinalizarCurso.Visible = true;
                                }
                            }
                            catch (Exception) { }
                        }
                    }
                }
            }
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            btnAgregarCurso.ButtonText = "Agregar curso";
            btnAgregarCurso.IdleFillColor = Color.FromArgb(89, 162, 58);
            btnCancelarCurso.Visible = false;
            dgvCursos.Focus();
            btnFinalizarCurso.Visible = false;
            dgvListaActividades.Rows.Clear();
        }

        #region SeleccionarDataGrid

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //if (DialogResult.Yes == MessageBox.Show("¿Desea eliminar el curso que comprende del " + dgvCursosPasados.CurrentRow.Cells[1].Value.ToString() + " al " + dgvCursosPasados.CurrentRow.Cells[2].Value.ToString() + " con clave: " + dgvCursosPasados.CurrentRow.Cells[0].Value.ToString() + "?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            //{
            //    foreach (Escuela miEscuela in listaEscuela)
            //        if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
            //        {
            //            miEscuela.listaCursos.Remove(new Cursos(dgvCursosPasados.CurrentRow.Cells[0].Value.ToString()));

            //            btnAgregarCurso.ButtonText = "Agregar curso";

            //            btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
            //            btnCancelarCurso.Visible = false;
            //            dgvListaActividades.Rows.Clear();
            //            dgvCursosPasados.Rows.Clear();
            //        }
            //}
        }

        #endregion

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Enabled = true;
            tsEliminarActividad.Visible = true;
            if (dgvListaActividades.Rows.Count == 5)
            {
                unaForma.Mostrar("Error", "Limite de actividades alcanzado.", 1, this);
                
                return;
            }
            if (txtActividad.Text == "")
            {
                unaForma.Mostrar("Error", "Introduzca una actividad primero.", 1, this);
               
                return;
            }


            dgvListaActividades.Rows.Add(txtActividad.Text);
            txtActividad.Text = "";
        }

        private void tsEliminarActividad_Click(object sender, EventArgs e)
        {
           
                
                if (Preguntar("Eliminar actividad", "¿Desea eliminar la actividad seleccionada?"))
                {
                    if (btnAgregarCurso.ButtonText == "Editar")
                    {
                        foreach (Escuela miEscuela in listaEscuela)
                        {
                            if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                            {
                                foreach (Cursos miCurso in miEscuela.listaCursos)
                                {
                                    if (miCurso.Equals(new Cursos(dgvCursos.CurrentRow.Cells[0].Value.ToString())))
                                    {
                                    try
                                    {
                                        string strNombreActividad = dgvListaActividades.CurrentRow.Cells[0].Value.ToString();
                                        miCurso.listaActividades.Remove(strNombreActividad);
                                        ConexionBD.EliminarActividad(miEscuela.Nombre, strNombreActividad);
                                    }
                                    catch (Exception) { }
                                        dgvListaActividades.Rows.Clear();
                                        foreach (string actividad in miCurso.listaActividades)
                                        {
                                            dgvListaActividades.Rows.Add(actividad);
                                        }
                                    }
                                }
                            }
                        }
                    }
                
                else
                {
                    try
                    {

                    dgvListaActividades.Rows.Remove(dgvListaActividades.CurrentRow);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        private void dgvListaActividades_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dgvListaActividades.CurrentRow == null)
                {
                    unaForma.Mostrar("Error", "Seleccione una actividad de la lista.",1,this);
                    
                    return;
                }
                tsEliminarActividad.Enabled = true;
                tsEliminarActividad.Visible = true;
                contextMenuStrip2.Visible = true;
                contextMenuStrip2.Enabled = true;
                dgvListaActividades.CurrentCell = dgvListaActividades.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvListaActividades.Rows[e.RowIndex].Selected = true;
                dgvListaActividades.Focus();
            }
        }

        private void dgvListaActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaActividades.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "Seleccione una actividad de la lista.", 1, this);
               
                return;
            }
            txtActividad.Text = dgvListaActividades.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnFinalizarCurso_Click_1(object sender, EventArgs e)
        {
            if (Preguntar("Finalizar curso", "¿Desea finalizar el curso con clave " + dgvCursos.CurrentRow.Cells[0].Value.ToString() + "?"))
            {
                Escuela unaEscuela = new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString());
                ConexionBD.AgregarFondos((ConexionBD.TotalInscripciones(txtNombreColegio.Text) + ConexionBD.TotalMensualidades(txtNombreColegio.Text, dgvCursos.CurrentRow.Cells[0].Value.ToString())), dgvCursos.CurrentRow.Cells[0].Value.ToString());
                ConexionBD.FinalizarCurso(unaEscuela.Nombre);
                unaEscuela.listaCursos = ConexionBD.CargarCursos(unaEscuela.Nombre);
                FillDgv(unaEscuela);
            }
            btnAgregarCurso.ButtonText = "Agregar curso";
            btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
            btnCancelarCurso.Visible = false;
            dgvCursos.Focus();
            btnFinalizarCurso.Visible = false;
            dgvListaActividades.Rows.Clear();
            dgvCursos.Rows.Clear();
        }

        void ComprobarCaducidad(Escuela miEscuela)
        {
            if (miEscuela.CursoActivo != null)
                if (miEscuela.CursoActivo.CompareTo(new Cursos(DateTime.Today, DateTime.Today)) <= 0)
                {
                    unaForma.Mostrar("Curso expirado", "El curso activo de " + miEscuela.Nombre + " expira hoy o ya expiró.", 1, this);
            
                    //    bool blnBandera = true;
                    //    do
                    //    {
                    //        if (DialogResult.Yes == MessageBox.Show("El curso activo de " + miEscuela.Nombre + " expira hoy o ya expiró\n¿Desea extender su duración?", "Fin de curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    //        {
                    //            //Agregarle 5 dias al curso que se encuentra en la lista y sea igual al activo y hacer el curso activo igual a este.                        
                    //            foreach (Cursos miCurso in miEscuela.listaCursos)
                    //            {
                    //                if (miCurso.Equals(miEscuela.CursoActivo))
                    //                {
                    //                    ConexionBD.ActualizarDatosCurso(miEscuela.Nombre, miCurso.InicioCursos, DateTime.Today.AddDays(5));
                    //                    miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                    //                }
                    //            }
                    //            MessageBox.Show("Curso extendido.");
                    //            blnBandera = false;
                    //        }
                    //        else
                    //        {
                    //            if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea terminar el curso?", "Fin de curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    //            {
                    //                //ConexionBD.FinalizarCurso(miEscuela.Nombre);
                    //                //miEscuela.CursoActivo = null;
                    //                //MessageBox.Show("Curso finalizado.");
                    //                FillDgv(miEscuela);
                    //                blnBandera = false;
                    //            }
                    //        }
                    //    } while (blnBandera);
                }
        }

        void FillDgv(Escuela miEscuela)
        {
            dgvCursosPasados.Rows.Clear();
            foreach (Cursos miCurso in miEscuela.listaCursos)
            {
                if (!miCurso.Activo)
                    dgvCursosPasados.Rows.Add(miCurso.Clave, miCurso.InicioCursos.ToLongDateString(), miCurso.FinCurso.ToLongDateString());
            }
        }

        private void dgvCursosPasados_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    dgvCursosPasados.CurrentCell = dgvCursosPasados.Rows[e.RowIndex].Cells[e.ColumnIndex];
            //    dgvCursosPasados.Rows[e.RowIndex].Selected = true;
            //    dgvCursosPasados.Focus();
            //}
        }

        private void dgvListaActividades_Leave(object sender, EventArgs e)
        {
            tsEliminarActividad.Enabled = false;
            tsEliminarActividad.Visible = false;
            contextMenuStrip2.Visible = false;
            contextMenuStrip2.Enabled = false;
        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregarColegio_Click(sender, e);
            }
        }

        private void bunifuCards2_Enter(object sender, EventArgs e)
        {
            if (dgvEscuelas.CurrentRow == null)
                MostrarCursos(false);
            else
                MostrarCursos(true);
        }

        private void MostrarCursos(bool blnEstado)
        {
            bunifuCards2.Visible = blnEstado;
            dgvCursos.Visible = blnEstado;
            dgvCursosPasados.Visible = blnEstado;
        }

        private void btnEscuela_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarGrados_Click(object sender, EventArgs e)
        {
            //foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
            //{
            //    if (unaEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
            //        if (ConexionBD.CargarAlumnos(unaEscuela.Nombre).Count != 0)
            //            if (DialogResult.Yes == MessageBox.Show("Desea actualizar los grados de los alumnos en " + unaEscuela.Nombre + "?", "Actualizar grados", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //            {
            //                foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(unaEscuela.Nombre))
            //                {
            //                    if (unAlumno.Grado <= 7)
            //                        unAlumno.Grado++;
            //                }
            //            }
            //}
        }

        private void Escuelas_Load(object sender, EventArgs e)
        {
            ActualizarGrados();
        }


           int ObtenerIndex(string strDia)
        {
            switch (strDia)
            {
                case "Lunes": return 0;
                case "Martes": return 1;
                case "Miercoles": return 2;
                case "Jueves": return 3;
                case "Viernes": return 4;
                case "Sabado": return 5;
                case "Domingo": return 6;
                default: return 0;
            }
        }

        private void dgvEscuelas_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvEscuelas.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "Seleccione una escuela de la lista.",1,this);
               
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                dgvEscuelas.CurrentCell = dgvEscuelas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvEscuelas.Rows[e.RowIndex].Selected = true;
                dgvEscuelas.Focus();
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (dgvEscuelas.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "No hay escuelas.\nAgregue una para continuar.",1,this);
               
                return;
            }
            if (Preguntar("Desactivar colegio", "¿Desea desactivar el colegio " + dgvEscuelas.CurrentRow.Cells[0].Value.ToString() + "?"))
            {
                ConexionBD.ModificarEscuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString(), false);
                txtNombreColegio.Text = "";
                btnCancelar.Visible = false;
                MostrarCursos(false);
                MostrarDatos();
                bunifuCustomLabel3.Visible = false;
                bunifuCustomLabel4.Visible = false;
            }
            else
                return;
        }

        private void dgvEscuelasDesactivadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEscuelasDesactivadas.CurrentRow == null)
            {
                unaForma.Mostrar("Error", "No hay escuelas.\nAgregue una para continuar.",1,this);
                
                return;
            }
            if (Preguntar("Activar colegio", "¿Desea activar el colegio " + dgvEscuelasDesactivadas.CurrentRow.Cells[0].Value.ToString() + "?"))
            {
                ConexionBD.ModificarEscuela(dgvEscuelasDesactivadas.CurrentRow.Cells[0].Value.ToString(), true);
                MostrarDatos();
                txtNombreColegio.Text = "";
                btnCancelar.Visible = false;
                MostrarCursos(false);
            }
        }

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            blnAceptarEscuela = false;
            unaForma.Mostrar(strEncabezado,strMensaje,2,this);
            blnAceptarEscuela= unaForma.Aceptar();
            return blnAceptarEscuela;
        }
    }
}
