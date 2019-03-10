﻿using System;
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
            dgvEscuelas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnAgregado.Visible = false;
            btnAgregadoCurso.Visible = false;
            btnAgregarCurso.Visible = false;
            btnAgregarActividad.Enabled = false;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancelarCurso.BackgroundImageLayout = ImageLayout.Stretch;
            tsEliminarCurso.Visible = false;
            contextMenuStrip1.Enabled = false;
            dgvListaActividades.Columns.Add("Lista de actividades", "Lista de actividades");
            dgvListaActividades.Rows.Add("Entrenamiento");
            dgvListaActividades.Rows.Add("Concurso");
            dgvListaActividades.Rows.Add("Partida amistosa");
            dgvListaActividades.Rows.Add("Blitz");
            dgvListaActividades.Rows.Add("Torneo");
            dgvListaActividades.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

         List<Escuela> listaEscuela = new List<Escuela>();

        private void btnAgregarColegio_Click(object sender, EventArgs e)
        {
            if (btnAgregarColegio.ButtonText == "Editar")
                foreach (Escuela otraEscuela in listaEscuela)
                {
                    if (otraEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
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
                    foreach (Escuela miEscuela in listaEscuela)
                    {
                        if (miEscuela.Nombre== dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                            foreach (Cursos miCursos in miEscuela.listaCursos)
                            {
                                if (miCursos.Equals(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString()))))
                                {
                                    miCursos.InicioCursos = dtmInicioCurso.Value;
                                    miCursos.FinCurso = dtmFinCurso.Value;
                                    btnAgregarCurso.ButtonText = "Agregar curso";
                                    btnAgregadoCurso.Visible = true;
                                    InitializeTimer();
                                    dgvCursos.Rows.Clear();
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
                dgvCursos.Rows.Clear();
                    foreach (Escuela miEscuela in listaEscuela)
                    {
                        if (miEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                        {
                            miEscuela.listaCursos.Add(new Cursos(dtmInicioCurso.Value, dtmFinCurso.Value));
                            foreach (Cursos miCursos in miEscuela.listaCursos)
                                 dgvCursos.Rows.Add(miCursos.InicioCursos.ToLongDateString(), miCursos.FinCurso.ToLongDateString());   
                        }
                    }
                    btnAgregadoCurso.Visible = true;
                    InitializeTimer();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void dgvEscuelas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAgregarCurso.Visible = true;
            btnAgregarActividad.Enabled = true;
            btnAgregarColegio.ButtonText = "Editar";
            btnAgregarColegio.IdleFillColor = Color.Teal;
            btnCancelar.Visible = true;
            foreach (Escuela miEscuela in listaEscuela)
            {
                if (miEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                {
                    txtNombreColegio.Text = miEscuela.Nombre;
                    dgvCursos.Rows.Clear();
                    foreach (Cursos miCurso in miEscuela.listaCursos)
                        dgvCursos.Rows.Add(miCurso.InicioCursos.ToLongDateString(), miCurso.FinCurso.ToLongDateString());
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
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtmInicioCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString());
            dtmFinCurso.Value = DateTime.Parse(dgvCursos.CurrentRow.Cells[1].Value.ToString());
            btnAgregarCurso.ButtonText = "Editar";
            btnCancelarCurso.Visible = true;
            btnAgregarCurso.IdleFillColor = Color.Teal;
        }

        private void btnCancelarCurso_Click(object sender, EventArgs e)
        {           
            btnAgregarCurso.ButtonText = "Agregar";
            btnAgregarCurso.IdleFillColor = Color.FromArgb(59, 202, 192);            
            btnCancelarCurso.Visible = false;
            dgvCursos.Focus();
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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("¿Desea eliminar el curso que comprende del " + dgvCursos.CurrentRow.Cells[0].Value.ToString() +" al "+ dgvCursos.CurrentRow.Cells[1].Value.ToString()+ "?", "Eliminar curso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                foreach (Escuela miEscuela in listaEscuela)
                    if (miEscuela.Nombre == dgvEscuelas.CurrentRow.Cells[0].Value.ToString())
                    {
                        miEscuela.listaCursos.Remove(new Cursos(DateTime.Parse(dgvCursos.CurrentRow.Cells[0].Value.ToString()), DateTime.Parse(dgvCursos.CurrentRow.Cells[01].Value.ToString())));
                        dgvCursos.Rows.Clear();
                        foreach (Cursos curso in miEscuela.listaCursos)
                             dgvCursos.Rows.Add(curso.InicioCursos.ToLongDateString(), curso.FinCurso.ToLongDateString());                      
                    }
            }

            if (btnAgregarColegio.ButtonText == "Editar")
            {
                btnAgregarColegio.ButtonText = "Agregar";
                btnCancelar.Visible = false;
            }
        }

        private void bunifuCards2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtmInicioCurso_onValueChanged(object sender, EventArgs e)
        {

        }

        private void lblInicioCurso_Click(object sender, EventArgs e)
        {

        }

        private void lblFinCurso_Click(object sender, EventArgs e)
        {

        }

        private void dtmFinCurso_onValueChanged(object sender, EventArgs e)
        {

        }

       
    }
}
