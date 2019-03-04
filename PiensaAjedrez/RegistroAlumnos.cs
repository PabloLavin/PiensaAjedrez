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
            btnCancelar.Visible = false;
            foreach (var ctl in txtFiltroAño.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))

                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = 4;
                }

            }
            foreach (var ctl in txtTelefono.Controls)
            {

                if (ctl.GetType() == typeof(TextBox))

                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = 10;
                }

            }
            btnAgregado.Visible = false;
            imgFiltro.Enabled = false;
            dgvAlumnos.Columns.Add("No. Ctrl", "No. Ctrl");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Escuela", "Escuela");
            dgvAlumnos.Columns.Add("Fecha de nacimiento", "Fecha de nacimiento");
            dgvAlumnos.Columns.Add("Telefono", "Teléfono");
            dgvAlumnos.Columns.Add("Correo", "Correo");
            dgvAlumnos.Columns.Add("Activo", "Activo");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAlumnos.Columns[6].Width = 99;            
            dgvAlumnos.Columns[0].Width = 80;
            dgvAlumnos.Columns[3].Width = 270;
            dgvAlumnos.Columns[4].Width = 110;
            dgvAlumnos.Columns[5].Width = 270;
            dgvAlumnos.Columns[1].Width = 250;
            dgvAlumnos.Columns[2].Width = 270;
            lblnumerocontrol.Text = "19100000";
            cbDia.SelectedIndex = 0;
            cbMes.SelectedIndex = 0;
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
                    miAlumno.Escuela = cbEscuelas.selectedValue;
                    miAlumno.FechaNacimiento = dtFechaNacimiento.Value;
                    miAlumno.Telefono = txtTelefono.Text;
                    miAlumno.Correo = txtCorreo.Text;
                if (btnAgregar.ButtonText=="Agregar")
                {
                    miAlumno.NumeroDeControl = ((int.Parse("19100000")) + (listaAlumnos.Count)).ToString();
                }
                else
                {
                    btnCancelar.Visible = false;
                    miAlumno.NumeroDeControl = lblnumerocontrol.Text;
                    listaAlumnos.Remove(miAlumno);
                }
                listaAlumnos.Add(miAlumno);
                if(btnAgregar.ButtonText=="Editar")
                    listaAlumnos.Sort();
                MostrarDatos();
                LimpiarControles();
                btnAgregado.Visible = true;
                InitializeTimer();       
                lblnumerocontrol.Text = ((int.Parse("19100000")) + (listaAlumnos.Count)).ToString();
                btnAgregar.ButtonText = "Agregar";
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
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo)?"Si":"No"));
            }
        }

        void LimpiarControles()
        {
            foreach (Control c in bnfcarAgregar.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                    c.Text = "";
            }
            txtCorreo.Text = "ejemplo@hotmail.com";
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
            {
                txtFiltonombre.Enabled = false;
                MostrarDatos();
                txtFiltonombre.Text = "Nombre";
            }
            }

        private void chkEscuela_OnChange(object sender, EventArgs e)
        {
            if (chkEscuela.Checked)
            {
                cboFiltroEscuela.Enabled = true;
                lblFiltroEscuela.Enabled = true;
            }                
            else
            {
                cboFiltroEscuela.Enabled = false;
                lblFiltroEscuela.Enabled = false;
                MostrarDatos();
                cboFiltroEscuela.Text = "";
            }
        }

        private void chkFechaNacimiento_OnChange(object sender, EventArgs e)
        {
            if (chkFechaNacimiento.Checked)
            {
                cbDia.Enabled = true;
                cbMes.Enabled = true;
                txtFiltroAño.Enabled = true;
            }
            else
            {
                cbDia.Enabled = false;
                cbMes.Enabled = false;
                txtFiltroAño.Enabled = false;
                MostrarDatos();
                txtFiltroAño.Text = "Año";
                cbDia.SelectedIndex = 0;
                cbMes.SelectedIndex = 0;
            }
        }

        private void chkTelefono_OnChange(object sender, EventArgs e)
        {
            if (chkTelefono.Checked)
                txtFiltroTelefono.Enabled = true;
            else
            {
                txtFiltroTelefono.Enabled = false;
                MostrarDatos();
                txtFiltroTelefono.Text = "Teléfono";
            }
            }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (chkCorreo.Checked)
                txtFiltroCorreo.Enabled = true;
            else
            {
                txtFiltroCorreo.Enabled = false;
                MostrarDatos();
                txtFiltroCorreo.Text = "Correo";
            }
        }
        #endregion

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Alumno alumnos in listaAlumnos)
            {
                if (alumnos.NumeroDeControl== dgvAlumnos.CurrentRow.Cells[0].Value.ToString())
                {
                    txtNombre.Text = alumnos.Nombre;
                    cbEscuelas.Text = alumnos.Escuela;
                    txtCorreo.Text = alumnos.Correo;
                    txtTelefono.Text = alumnos.Telefono;
                    dtFechaNacimiento.Value = alumnos.FechaNacimiento;
                    if (alumnos.Activo)
                    {
                        chkActivo.Checked = true;
                    }
                    else
                    {
                        chkActivo.Checked = false;
                    }
                        lblnumerocontrol.Text = alumnos.NumeroDeControl;
                        btnAgregar.ButtonText = "Editar";
                    btnAgregar.IdleFillColor = Color.Teal;
                    btnCancelar.Visible = true;
                } 
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
            btnAgregar.ButtonText = "Agregar";
            btnAgregar.IdleFillColor = Color.FromArgb(59, 202, 192);
            lblnumerocontrol.Text = ((int.Parse("19100000")) + (listaAlumnos.Count)).ToString();
            btnCancelar.Visible = false;
            dgvAlumnos.Focus();
        }


        private int counter;
        Timer timer1 = new Timer();

        public void InitializeTimer()
        {
            counter = 0;
            timer1.Interval = 300;
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            if (counter >= 10)
            {
          
                timer1.Enabled = false;
                counter = 0;
                btnAgregado.Visible = false;
            }
            else
            {

                counter += 1;

            }
        }

        private void txtFiltonombre_OnValueChanged(object sender, EventArgs e)
        {
                dgvAlumnos.Rows.Clear();
                foreach (Alumno miAlumno in listaAlumnos)
                {
                    if (miAlumno.Nombre.Contains(txtFiltonombre.Text))
                    {
                        dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));
                    }

                }
        }

        private void cboFiltroEscuela_OnItemSelected(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Escuela.Contains(cboFiltroEscuela.Text))
                {
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));
                }

            }
        }

       

        private void txtFiltroTelefono_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Telefono.Contains(txtFiltroTelefono.Text))
                {
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));
                }

            }
        }

        private void txtFiltroCorreo_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in listaAlumnos)
            {
                if (miAlumno.Correo.Contains(txtFiltroCorreo.Text))
                {
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));
                }

            }
        }
        
        private void txtFiltroAño_Enter(object sender, EventArgs e)
        {
            if (txtFiltroAño.Text=="Año")
                txtFiltroAño.Text = "";  
        }

        private void txtFiltroAño_Leave(object sender, EventArgs e)
        {
            if (txtFiltroAño.Text == "")
                txtFiltroAño.Text = "Año";
        }

        private void txtFiltroAño_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroAño.Text == "Año")
                txtFiltroAño.Text = "";
        }

        private void txtFiltroAño_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroAño.Text == "")
                txtFiltroAño.Text = "Año";
        }


        private void cbDia_TextChanged(object sender, EventArgs e)
        {
            BusquedaFiltrada();
        }

        private void cbMes_TextChanged(object sender, EventArgs e)
        {
            BusquedaFiltrada();
        }
        bool blnDia = true, blnMes=true,blnAño=true, blnDiaContains = true, blnMesContains = true, blnAñoContains = true;

        private void chkFiltroActivo_OnChange(object sender, EventArgs e)
        {
            if (!chkFiltroActivo.Checked)
            {
                MostrarDatos();
            }
            else
            {
                dgvAlumnos.Rows.Clear();
                foreach (Alumno miAlumno in listaAlumnos)
                {
                    if (miAlumno.Activo)                    
                        dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));                    
                }
            }
            
        }

        private void txtFiltroAño_OnValueChanged(object sender, EventArgs e)
        {
            BusquedaFiltrada();
        }

        #region Filtrar
        void ObtenerBooleanos()
        {
            blnDia = (cbDia.Text == "");
            blnMes = (cbMes.Text == "");
            blnAño = (txtFiltroAño.Text == "");
        }
        void ObtenerBooleanos(Alumno miAlumno)
        {
            blnDiaContains = ((miAlumno.FechaNacimiento.Day.ToString().Contains(cbDia.Text)));
            blnMesContains = ((miAlumno.FechaNacimiento.Month.ToString().Contains(cbMes.Text)));
            blnAñoContains= ((miAlumno.FechaNacimiento.Year.ToString().Contains(txtFiltroAño.Text)));

            if (blnDia && blnMes && !blnAño)
                if (blnAñoContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (!blnDia && !blnMes && !blnAño)
                if (blnDiaContains && blnMesContains && blnAñoContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (!blnDia && blnMes && !blnAño)
                if (blnDiaContains && blnAñoContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (blnDia && !blnMes && !blnAño)
                if (blnMesContains && blnAñoContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (!blnDia && !blnMes && blnAño)
                if (blnDia && blnMes)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (!blnDia && blnMes && blnAño)
                if (blnDiaContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (blnDia && !blnMes && blnAño)
                if (blnMesContains)
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToLongDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"));

            if (blnDia && blnMes && blnAño)
                MostrarDatos();

        }
        void BusquedaFiltrada()
        {
            dgvAlumnos.Rows.Clear();
            ObtenerBooleanos();
            foreach (Alumno miAlumno in listaAlumnos)
            {
                ObtenerBooleanos(miAlumno);
            }
        }
        #endregion
    }
}



