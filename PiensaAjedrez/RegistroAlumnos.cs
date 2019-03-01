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
        List<Alumno> listaAlumnos = new List<Alumno>();
        public RegistroAlumnos()
        {
            InitializeComponent();
            txtNombre.Focus();
            imgFiltro.Enabled = false;
            dgvAlumnos.Columns.Add("No. Ctrl", "No. Ctrl");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Escuela", "Escuela");
            dgvAlumnos.Columns.Add("Fecha de nacimiento", "Fecha de nacimiento");
            dgvAlumnos.Columns.Add("Telefono", "Teléfono");
            dgvAlumnos.Columns.Add("Correo", "Correo");
            dgvAlumnos.Columns.Add("Activo", "Activo");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.Columns[6].Width = dgvAlumnos.Columns[6].GetPreferredWidth(DataGridViewAutoSizeColumnMode.Fill, true);
            lblnumerocontrol.Text = "19100000";

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
            try
            {
                if (chkActivo.Checked)
                    miAlumno.Activo = true;
                else
                    miAlumno.Activo = false;
                miAlumno.Nombre = txtNombre.Text;
                miAlumno.Escuela = txtEscuela.Text;
                miAlumno.FechaNacimiento = dtFechaNacimiento.Value;
                miAlumno.Telefono = txtTelefono.Text;
                miAlumno.Correo = txtCorreo.Text;
                miAlumno.NumeroDeControl = ((int.Parse("19100000")) + (listaAlumnos.Count)).ToString();
                listaAlumnos.Add(miAlumno);
                MostrarDatos();
                LimpiarControles();
                MessageBox.Show("Alumno añadido con éxito.");
                lblnumerocontrol.Text = ((int.Parse(miAlumno.NumeroDeControl)) + 1).ToString();

            }
            catch (IndexOutOfRangeException c)
            {
                MessageBox.Show("Sólo se permiten 10 dígitos en el número de teléfono.");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        void MostrarDatos()
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in listaAlumnos)
            {
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToShortDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo)?"Si":"No"));
            }
        }

        void LimpiarControles()
        {
            foreach (Control c in bunifuCards1.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    c.Text = "";
            }
        }
       
        #region Eventos 
        private void txtCorreo_MouseEnter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo@hotmail.com")
            {

                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void txtCorreo_MouseLeave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {

                txtCorreo.Text = "ejemplo@hotmail.com";
                txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            }

        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "ejemplo@hotmail.com")
            {

                txtCorreo.Text = "";
                txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (txtCorreo.Text == "")
            {
                txtCorreo.Text = "ejemplo@hotmail.com";
                txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            }
        }

        private void txtFiltonombre_Enter(object sender, EventArgs e)
        {
            if (txtFiltonombre.Text == "Nombre")
                txtFiltonombre.Text = "";
        }

        private void txtFiltonombre_Leave(object sender, EventArgs e)
        {
            if (txtFiltonombre.Text == "")
                txtFiltonombre.Text = "Nombre";
        }

        private void txtFiltonombre_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltonombre.Text == "Nombre")
                txtFiltonombre.Text = "";
        }

        private void txtFiltonombre_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltonombre.Text == "")
                txtFiltonombre.Text = "Nombre";
        }

        private void txtFiltoescuela_Enter(object sender, EventArgs e)
        {
            if (txtFiltoescuela.Text == "Escuela")
                txtFiltoescuela.Text = "";
        }

        private void txtFiltoescuela_Leave(object sender, EventArgs e)
        {
            if (txtFiltoescuela.Text == "")
                txtFiltoescuela.Text = "Escuela";
        }

        private void txtFiltoescuela_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltoescuela.Text == "Escuela")
                txtFiltoescuela.Text = "";
        }

        private void txtFiltoescuela_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltoescuela.Text == "")
                txtFiltoescuela.Text = "Escuela";
        }

        private void txtFiltroFechaNacimiento_Enter(object sender, EventArgs e)
        {
            if (txtFiltroFechaNacimiento.Text == "dd/mm/aa")
                txtFiltroFechaNacimiento.Text = "";
        }

        private void txtFiltroFechaNacimiento_Leave(object sender, EventArgs e)
        {
            if (txtFiltroFechaNacimiento.Text == "")
                txtFiltroFechaNacimiento.Text = "dd/mm/aa";
        }

        private void txtFiltroFechaNacimiento_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroFechaNacimiento.Text == "dd/mm/aa")
                txtFiltroFechaNacimiento.Text = "";
        }

        private void txtFiltroFechaNacimiento_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroFechaNacimiento.Text == "")
                txtFiltroFechaNacimiento.Text = "dd/mm/aa";
        }

        private void txtFiltroTelefono_Enter(object sender, EventArgs e)
        {
            if (txtFiltroTelefono.Text == "Telefono")
                txtFiltroTelefono.Text = "";
        }

        private void txtFiltroTelefono_Leave(object sender, EventArgs e)
        {
            if (txtFiltroTelefono.Text == "")
                txtFiltroTelefono.Text = "Telefono";
        }

        private void txtFiltroTelefono_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroTelefono.Text == "Telefono")
                txtFiltroTelefono.Text = "";
        }

        private void txtFiltroTelefono_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroTelefono.Text == "")
                txtFiltroTelefono.Text = "Telefono";
        }

        private void txtFiltroCorreo_Enter(object sender, EventArgs e)
        {
            if (txtFiltroCorreo.Text == "Correo")
                txtFiltroCorreo.Text = "";
        }

        private void txtFiltroCorreo_Leave(object sender, EventArgs e)
        {
            if (txtFiltroCorreo.Text == "")
                txtFiltroCorreo.Text = "Correo";
        }

        private void txtFiltroCorreo_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroCorreo.Text == "Correo")
                txtFiltroCorreo.Text = "";
        }

        private void txtFiltroCorreo_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroCorreo.Text == "")
                txtFiltroCorreo.Text = "Correo";
        }
        
        private void chkNombre_OnChange(object sender, EventArgs e)
        {
            if (chkNombre.Checked)
                txtFiltonombre.Enabled = true;
            else
                txtFiltonombre.Enabled = false;    
        }

        private void chkEscuela_OnChange(object sender, EventArgs e)
        {
            if (chkEscuela.Checked)
                txtFiltoescuela.Enabled = true;
            else
                txtFiltoescuela.Enabled = false;
        }

        private void chkFechaNacimiento_OnChange(object sender, EventArgs e)
        {
            if (chkFechaNacimiento.Checked)
                txtFiltroFechaNacimiento.Enabled = true;
            else
                txtFiltroFechaNacimiento.Enabled = false;
        }

        private void chkTelefono_OnChange(object sender, EventArgs e)
        {
            if (chkTelefono.Checked)
                txtFiltroTelefono.Enabled = true;
            else
                txtFiltroTelefono.Enabled = false;
        }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (chkCorreo.Checked)
                txtFiltroCorreo.Enabled = true;
            else
                txtFiltroCorreo.Enabled = false;
        }
        #endregion

    }
}


