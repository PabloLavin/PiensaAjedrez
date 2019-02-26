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
    public partial class RegistroAlumnos : UserControl
    {
        public RegistroAlumnos()
        {
            InitializeComponent();
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Escuela", "Escuela");
            dgvAlumnos.Columns.Add("Fecha de nacimiento", "Fecha de nacimiento");
            dgvAlumnos.Columns.Add("Telefono", "Teléfono");
            dgvAlumnos.Columns.Add("Correo", "Correo");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
