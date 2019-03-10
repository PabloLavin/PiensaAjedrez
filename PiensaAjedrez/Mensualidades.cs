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
            cbEscuelas.AddItem("INSTITUTO TECNOLÓGICO DE NUEVO LAREDO");
            cbEscuelas.selectedIndex = 0;
            

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
            //dgvAlumnos.Columns.Add("Act_1", "Act_1");
            //dgvAlumnos.Columns.Add("Act_2", "Act_2");
            //dgvAlumnos.Columns.Add("Act_3", "Act_3");
            //dgvAlumnos.Columns.Add("Act_4", "Act_4");
            //dgvAlumnos.Columns.Add("Act_5", "Act_5");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.Columns[0].Width = 80;
            dgvAlumnos.Columns[1].Width = 250;
            dgvAlumnos.Rows.Add("19100000", "Shawn HBK Michaels");
            dgvAlumnos.Rows.Add("19100001", "Triple H");
        }
    }
}
