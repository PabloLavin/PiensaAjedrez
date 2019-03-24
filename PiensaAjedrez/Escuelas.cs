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

            dgvCursos.Columns.Add("Inicio del curso", "Inicio del curso");
            dgvCursos.Columns.Add("Fin del curso", "Fin del curso");

            dgvCursosPasados.Columns.Add("Inicio del curso", "Inicio del curso");
            dgvCursosPasados.Columns.Add("Fin del curso", "Fin del curso");

            dgvEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursosPasados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            btnAgregado.Visible = false;
            btnAgregadoCurso.Visible = false;
            btnAgregarCurso.Visible = false;
            btnAgregarActividad.Enabled = false;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarCurso.BackgroundImageLayout = ImageLayout.Stretch;
            tsEliminarCurso.Visible = false;
            contextMenuStrip1.Enabled = false;
            contextMenuStrip2.Enabled = false;
            tsEliminarActividad.Visible = false;
            dgvListaActividades.Columns.Add("Lista de actividades", "Lista de actividades");
            dgvListaActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnFinalizarCurso.Visible = false;
            MostrarDatos();
            dtmFinCurso.Value = DateTime.Today;
            dtmInicioCurso.Value = DateTime.Today;

        }

        public static List<Escuela> listaEscuela = new List<Escuela>();

        private void btnAgregarColegio_Click(object sender, EventArgs e)
        {
            if (btnAgregarColegio.ButtonText == "Editar")
                foreach (Escuela otraEscuela in listaEscuela)
                {
                    if (otraEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                    {
                        otraEscuela.Nombre = txtNombreColegio.Text;
                        MostrarDatos();
                        btnAgregarColegio.ButtonText = "Agregar";
                        txtNombreColegio.Text = "";
                        btnCancelar.Visible = false;
                        return;
                    }
                }

            if (!listaEscuela.Contains(new Escuela(txtNombreColegio.Text)))
            {
                listaEscuela.Add(new Escuela(txtNombreColegio.Text));
                btnAgregado.Visible = true;
                InitializeTimer();
                txtNombreColegio.Text = "";
                MostrarDatos();
                dgvCursos.Rows.Clear();

            }
            else
                MessageBox.Show("Escuela duplicada.");
            txtNombreColegio.Focus();
        }

        void MostrarDatos()
        {
            dgvEscuelas.Rows.Clear();
            foreach (Escuela escuela in listaEscuela)
            {
                dgvEscuelas.Rows.Add(escuela.Nombre);
            }
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
                    foreach (Escuela miEscuela in listaEscuela)
                    {
                        if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                            foreach (Cursos miCursos in miEscuela.listaCursos)
                            {
                                if (miCursos.Equals(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()))))
                                {
                                    bool blnActivo = false;
                                    if (miEscuela.CursoActivo.Equals(miCursos))
                                    {
                                        blnActivo = true;
                                    }
                                    miCursos.InicioCursos = dtmInicioCurso.Value;
                                    miCursos.FinCurso = dtmFinCurso.Value;
                                    miCursos.listaActividades.Clear();
                                    for (int i = 0; i < dgvListaActividades.Rows.Count; i++)
                                    {
                                        miCursos.listaActividades.Add(dgvListaActividades.Rows[i].Cells[0].Value.ToString());
                                    }
                                    if (blnActivo)
                                        miEscuela.CursoActivo = miCursos;
                                    
                                    btnAgregarCurso.ButtonText = "Agregar curso";
                                    btnAgregadoCurso.Visible = true;
                                    InitializeTimer();
                                    dgvCursos.Rows.Clear();
                                    dgvListaActividades.Rows.Clear();
                                    btnCancelarCurso.Visible = false;
                                    foreach (Cursos curso in miEscuela.listaCursos)
                                        dgvCursos.Rows.Add(curso.InicioCursos.ToLongDateString(), curso.FinCurso.ToLongDateString());
                                    return;
                                }

                            }
                    }
                }
                contextMenuStrip1.Enabled = true;
                tsEliminarCurso.Visible = true;

                
                foreach (Escuela miEscuela in listaEscuela)
                {
                    if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                    {
                        if (miEscuela.CursoActivo == null)
                        {
                            dgvCursos.Rows.Clear();
                            List<string> lstActividades = new List<string>();
                            for (int i = 0; i < dgvListaActividades.Rows.Count; i++)
                            {
                                lstActividades.Add(dgvListaActividades.Rows[i].Cells[0].Value.ToString());
                            }
                            Cursos miCurso = new Cursos(dtmInicioCurso.Value, dtmFinCurso.Value, lstActividades);
                            miCurso.Activo = true;
                            miEscuela.listaCursos.Add(miCurso);
                            miEscuela.CursoActivo = miCurso;
                            dgvCursos.Rows.Add(miEscuela.CursoActivo.InicioCursos.ToLongDateString(), miEscuela.CursoActivo.FinCurso.ToLongDateString());

                            btnAgregadoCurso.Visible = true;
                            InitializeTimer();
                            dgvListaActividades.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ya hay un curso activo.");
                            return;
                        }

                    }
                }


            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvEscuelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btnAgregarCurso.ButtonText == "Editar")
            {
                btnAgregarCurso.ButtonText = "Agregar curso";
                btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
                btnCancelarCurso.Visible = false;
                dgvListaActividades.Rows.Clear();

            }
            dgvCursosPasados.Rows.Clear();
            btnFinalizarCurso.Visible = false;
            btnAgregarCurso.Visible = true;
            btnAgregarActividad.Enabled = true;
            btnAgregarColegio.ButtonText = "Editar";
            btnAgregarColegio.IdleFillColor = Color.Teal;
            btnCancelar.Visible = true;

            foreach (Escuela miEscuela in listaEscuela)
            {
                if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                {
                    txtNombreColegio.Text = miEscuela.Nombre;
                    dgvCursos.Rows.Clear();
                   
                        if (miEscuela.listaCursos.Count > 0)
                            ComprobarCaducidad(miEscuela);
                   
                    FillDgv(miEscuela);
                    if(miEscuela.CursoActivo!=null)
                        dgvCursos.Rows.Add(miEscuela.CursoActivo.InicioCursos.ToLongDateString(), miEscuela.CursoActivo.FinCurso.ToLongDateString());
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreColegio.Text = "";
            btnAgregarColegio.ButtonText = "Agregar";
            btnAgregarColegio.IdleFillColor = Color.FromArgb(59, 202, 192);
            btnAgregarCurso.Visible = false;
            btnCancelar.Visible = false;
            dgvEscuelas.Focus();
            dgvCursos.Rows.Clear();
            dgvCursosPasados.Rows.Clear();
            btnCancelarCurso.Visible = false;
            btnFinalizarCurso.Visible = false;
            
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtmInicioCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());
            dtmFinCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString());
            dgvListaActividades.Rows.Clear();
            btnFinalizarCurso.Visible = false;

            
            btnAgregarCurso.ButtonText = "Editar";
            btnCancelarCurso.Visible = true;
            btnAgregarCurso.IdleFillColor = Color.Teal;
            foreach (Escuela miEscuela in listaEscuela)
            {
                if (miEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                    foreach (Cursos miCursos in miEscuela.listaCursos)
                    {
                       new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()));
                       
                        if (miCursos.Equals(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()))))
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
                            catch (Exception x) { }
                        }

                    }
            }
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {
            btnAgregarCurso.ButtonText = "Agregar curso";
            btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
            btnCancelarCurso.Visible = false;
            dgvCursos.Focus();
            btnFinalizarCurso.Visible = false;
            dgvListaActividades.Rows.Clear();
        }

        private void dgvCursos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvCursos.CurrentCell = dgvCursos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvCursos.Rows[e.RowIndex].Selected = true;
                dgvCursos.Focus();
            }
        }

        #region SeleccionarDataGrid
       
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea eliminar el curso que comprende del " + dgvCursos.CurrentRow.Cells[0].Value.ToString() + " al " + dgvCursos.CurrentRow.Cells[1].Value.ToString() + "?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                foreach (Escuela miEscuela in listaEscuela)
                    if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                    {
                        miEscuela.listaCursos.Remove(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString())));

                        btnAgregarCurso.ButtonText = "Agregar curso";

                        if (miEscuela.CursoActivo.Equals(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()))))
                            miEscuela.CursoActivo = null;

                        btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
                        btnCancelarCurso.Visible = false;
                        dgvListaActividades.Rows.Clear();
                        dgvCursos.Rows.Clear();
                    }
            }
        }

        #endregion

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Enabled = true;
            tsEliminarActividad.Visible = true;
            if (dgvListaActividades.Rows.Count == 5)
            {
                MessageBox.Show("Limite de actividades alcanzado.");
                return;
            }


            dgvListaActividades.Rows.Add(txtActividad.Text);
            txtActividad.Text = "";
        }

        private void tsEliminarActividad_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea eliminar la actividad seleccionada?", "Eliminar actividad", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                if (btnAgregarCurso.ButtonText == "Editar")
                {
                    foreach (Escuela miEscuela in listaEscuela)
                    {
                        if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                        {
                            foreach (Cursos miCurso in miEscuela.listaCursos)
                            {
                                if (miCurso.Equals(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()))))
                                {
                                    miCurso.listaActividades.Remove(dgvListaActividades.CurrentRow.Cells[0].Value.ToString());
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
                    dgvListaActividades.Rows.Remove(dgvListaActividades.CurrentRow);
                }
            }
        }

        private void dgvListaActividades_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvListaActividades.CurrentCell = dgvListaActividades.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvListaActividades.Rows[e.RowIndex].Selected = true;
                dgvListaActividades.Focus();
            }
        }

        private void dgvListaActividades_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtActividad.Text = dgvListaActividades.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnFinalizarCurso_Click_1(object sender, EventArgs e)
        {
                if (DialogResult.Yes == MessageBox.Show("¿Desea finalizar el curso que comprende del " + dgvCursos.CurrentRow.Cells[0].Value.ToString() + " al " + dgvCursos.CurrentRow.Cells[1].Value.ToString() + "?", "Finalizar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                {
                    foreach (Escuela miEscuela in listaEscuela)
                    {
                        if (miEscuela.Equals(new Escuela(dgvEscuelas.CurrentRow.Cells[0].Value.ToString())))
                        {
                            foreach (Cursos miCurso in miEscuela.listaCursos)
                            {
                                if (miCurso.Equals(miEscuela.CursoActivo) && miCurso.Activo)
                                {
                                  miCurso.Activo = false;
                                  miEscuela.CursoActivo = null;
                                  FillDgv(miEscuela);
                                }
                            }

                        }
                    }
                    btnAgregarCurso.ButtonText = "Agregar curso";
                    btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);
                    btnCancelarCurso.Visible = false;
                    dgvCursos.Focus();
                    btnFinalizarCurso.Visible = false;
                    dgvListaActividades.Rows.Clear();
                    dgvCursos.Rows.Clear();
                }
        }

        void ComprobarCaducidad(Escuela miEscuela)
        {
            if (miEscuela.CursoActivo.CompareTo(new Cursos(DateTime.Today, DateTime.Today)) <= 0)
            {
                bool blnBandera = true;
                do
                {
                    if (DialogResult.Yes == MessageBox.Show("El curso activo de " + miEscuela.Nombre + " expira hoy o ya expiró\n¿Desea extender su duración?", "Fin de curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                    {
                        //Agregarle 5 dias al curso que se encuentra en la lista y sea igual al activo y hacer el curso activo igual a este.

                        foreach (Cursos miCurso in miEscuela.listaCursos)
                        {
                            if (miCurso.Equals(miEscuela.CursoActivo))
                            {
                                miCurso.FinCurso = DateTime.Today.AddDays(5);
                                miEscuela.CursoActivo = miCurso;
                            }
                        }
                        MessageBox.Show("Curso extendido.");
                        blnBandera = false;
                    }
                    else
                    {
                        if (DialogResult.Yes == MessageBox.Show("¿Seguro que desea terminar el curso?", "Fin de curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
                        {
                            miEscuela.CursoActivo = null;
                            MessageBox.Show("Curso finalizado.");
                            blnBandera = false;
                        }
                    }
                } while (blnBandera);
            }    
}

        void FillDgv(Escuela miEscuela)
        {
            dgvCursosPasados.Rows.Clear();
            foreach (Cursos miCurso in miEscuela.listaCursos)
            {
                if(!miCurso.Activo)
                 dgvCursosPasados.Rows.Add(miCurso.InicioCursos.ToLongDateString(),miCurso.FinCurso.ToLongDateString());
            }
        }

        
    }
}
