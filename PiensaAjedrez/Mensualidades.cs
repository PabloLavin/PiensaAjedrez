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
    public partial class Mensualidades : UserControl
    {
        public Mensualidades()
        {
            InitializeComponent();
        }

        private void Mensualidades_Load(object sender, EventArgs e)
        {
            btnAgregado.Visible = false;
            dtFechaPago.Value = DateTime.Today;
            

            dgvAlumnos.Columns.Add("No. ctrl.", "No. ctrl.");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Ene", "Ene");
            dgvAlumnos.Columns.Add("Feb", "Feb");
            dgvAlumnos.Columns.Add("Mar", "Mar");
            dgvAlumnos.Columns.Add("Abr", "Abr");
            dgvAlumnos.Columns.Add("May", "May");
            dgvAlumnos.Columns.Add("Jun", "Jun");
            dgvAlumnos.Columns.Add("Jul", "Jul");
            dgvAlumnos.Columns.Add("Ago", "Ago");
            dgvAlumnos.Columns.Add("Sep", "Sep");
            dgvAlumnos.Columns.Add("Oct", "Oct");
            dgvAlumnos.Columns.Add("Nov", "Nov");
            dgvAlumnos.Columns.Add("Dic", "Dic");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.Columns[0].Width = 80;
            dgvAlumnos.Columns[1].Width = 250;
            Deshabilitar();
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                cbEscuelas.AddItem(miEscuela.Nombre);
            }

        }
        

        void Deshabilitar()
        {
            foreach (Control c in bunifuCards1.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuDatepicker)
                    c.Visible = false;
                if (c is Bunifu.Framework.UI.BunifuThinButton2)
                    c.Visible = false;
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    c.Enabled = false;
            }
            cbMetodoPago.Enabled = false;
        }

        void Habilitar()
        {
            foreach (Control c in bunifuCards1.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuDatepicker)
                    c.Visible = true;
                if (c is Bunifu.Framework.UI.BunifuThinButton2)
                    c.Visible = true;
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    c.Enabled = true;
            }
            cbMetodoPago.Enabled = true;
        }

        void LlenarDGV(Escuela otraEscuela)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in otraEscuela.listaAlumno)
            {
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre);
            }
        }

        private void cbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if (cbEscuelas.selectedValue == miEscuela.Nombre)
                {
                    LlenarDGV(miEscuela);
                }
            }
            Habilitar();
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if(miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in miEscuela.listaAlumno)
                        if(miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())))
                        {
                            lblNroControl.Text = miAlumno.NumeroDeControl;
                            lblNombre.Text = miAlumno.Nombre;
                        }

            }
            
          
        }
    }
}
