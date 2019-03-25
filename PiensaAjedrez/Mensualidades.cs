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
        List<Pagos> listaPagos = new List<Pagos>();

        private void Mensualidades_Load(object sender, EventArgs e)
        {
            btnAgregado.Visible = false;
            dtFechaPago.Value = DateTime.Today;
            

            dgvAlumnos.Columns.Add("No. ctrl.", "No. ctrl.");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Ene", "Enero");
            dgvAlumnos.Columns.Add("Feb", "Febrero");
            dgvAlumnos.Columns.Add("Mar", "Marzo");
            dgvAlumnos.Columns.Add("Abr", "Abril");
            dgvAlumnos.Columns.Add("May", "Mayo");
            dgvAlumnos.Columns.Add("Jun", "Junio");
            dgvAlumnos.Columns.Add("Jul", "Julio");
            dgvAlumnos.Columns.Add("Ago", "Agosto");
            dgvAlumnos.Columns.Add("Sep", "Septiembre");
            dgvAlumnos.Columns.Add("Oct", "Octubre");
            dgvAlumnos.Columns.Add("Nov", "Noviembre");
            dgvAlumnos.Columns.Add("Dic", "Diciembre");
            dgvAlumnos.Columns.Add("Inscrip.", "Inscrip");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgvAlumnos.Columns[0].Width = 80;
            dgvAlumnos.Columns[1].Width = 250;
           
            Deshabilitar();
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                cbEscuelas.AddItem(miEscuela.Nombre);
            }

            txtFiltroNombre.LineIdleColor = Color.SkyBlue;
            txtFiltroNoCtrl.LineIdleColor = Color.SkyBlue;

            cbAño.Items.Clear();
            for (int i = 2010; i <=2050 ; i++)
            {
                cbAño.Items.Add(Convert.ToString(i));
            }
            cbAño.Text = DateTime.Today.Year.ToString();
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
                {
                    c.Enabled = false;
                    c.Text = "";
                }
            }
            cbMetodoPago.Enabled = false;
            lblMesAPagar.Text = "Mes";
            txtMonto.LineIdleColor = Color.SkyBlue;
            txtNota.LineIdleColor = Color.SkyBlue;
            lblNombre.Text = "Nombre(s) Apellido P. Apellido M.";
            lblNroControl.Text = "19100000";
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
            txtMonto.LineIdleColor = Color.Teal;
            txtNota.LineIdleColor = Color.Teal;
        }

        void LlenarDGV(Escuela otraEscuela)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in otraEscuela.listaAlumno)
            {
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre);
                RellenarPagos(miAlumno);
            }

        }

        private void cbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            if(Escuelas.listaEscuela.Count>0)
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if (cbEscuelas.selectedValue == miEscuela.Nombre)
                {
                    LlenarDGV(miEscuela);
                    Deshabilitar();
                }
            }
          
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
                            ObtenerMes(int.Parse(dgvAlumnos.CurrentCell.ColumnIndex.ToString()));   
                        }
            }
        }
       
        #region Filtro
        private void txtFiltroNombre_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in miEscuela.listaAlumno)
                        if (miAlumno.Nombre.Contains(txtFiltroNombre.Text))
                        {
                            dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre);
                            RellenarPagos(miAlumno);
                        }

            }
        }

        private void chkNombre_OnChange(object sender, EventArgs e)
        {
            if (!chkNombre.Checked)
            {
                txtFiltroNombre.Enabled = false;
                txtFiltroNombre.LineIdleColor = Color.SkyBlue;
                foreach (Escuela miEscuela in Escuelas.listaEscuela)
                {
                    if (cbEscuelas.selectedValue == miEscuela.Nombre)
                    {
                        LlenarDGV(miEscuela);
                    }
                }

            }
            else
            {
                txtFiltroNombre.Enabled = true;
                txtFiltroNombre.LineIdleColor = Color.Teal;

            }
        }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (!chkCorreo.Checked)
            {
                txtFiltroNoCtrl.Enabled = false;
                txtFiltroNoCtrl.LineIdleColor = Color.SkyBlue;
                foreach (Escuela miEscuela in Escuelas.listaEscuela)
                {
                    if (cbEscuelas.selectedValue == miEscuela.Nombre)
                    {
                        LlenarDGV(miEscuela);
                    }
                }
            }
            else
            {
                txtFiltroNoCtrl.Enabled = true;
                txtFiltroNoCtrl.LineIdleColor = Color.Teal;
            }
        }

        private void txtFiltroNoCtrl_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in miEscuela.listaAlumno)
                        if (miAlumno.NumeroDeControl.Contains(txtFiltroNoCtrl.Text))
                        {
                            dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre);
                            RellenarPagos(miAlumno);
                        }

            }
        }

        private void cbAño_TextChanged(object sender, EventArgs e)
        {
            if (chkAño.Checked)
            {
                dgvAlumnos.Rows.Clear();
                foreach (Escuela miEscuela in Escuelas.listaEscuela)
                {
                    if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                        foreach (Alumno miAlumno in miEscuela.listaAlumno)
                            foreach (Pagos miPago in miAlumno.listaPagos)
                            {
                                if (miPago.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                                {
                                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Nombre);
                                    RellenarPagos(miAlumno);
                                }

                            }

                }
            }
        }  

        private void chkAño_OnChange(object sender, EventArgs e)
        {
            if (chkAño.Checked)
            {
                cbAño.Enabled = true;
                cbAño.BackColor = Color.FromArgb(59, 202, 192);
            }
            else
            {
                cbAño.Enabled = false;
                cbAño.BackColor = Color.SkyBlue;
                cbAño.Text = DateTime.Today.Year.ToString();
                foreach (Escuela miEscuela in Escuelas.listaEscuela)
                {
                    if (cbEscuelas.selectedValue == miEscuela.Nombre)
                    {
                        LlenarDGV(miEscuela);
                    }
                }
            }
        }
        #endregion
        #region Eventos
        private void txtFiltroNombre_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == "Nombre")
                txtFiltroNombre.Text = "";
        }

        private void txtFiltroNombre_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == "")
                txtFiltroNombre.Text = "Nombre";
        }

        private void txtFiltroNombre_Enter(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == "Nombre")
                txtFiltroNombre.Text = "";
        }

        private void txtFiltroNombre_Leave(object sender, EventArgs e)
        {
            if (txtFiltroNombre.Text == "")
                txtFiltroNombre.Text = "Nombre";
        }

        private void txtFiltroNoCtrl_Enter(object sender, EventArgs e)
        {
            if (txtFiltroNoCtrl.Text == "No. ctrl.")
                txtFiltroNoCtrl.Text = "";
        }

        private void txtFiltroNoCtrl_Leave(object sender, EventArgs e)
        {
            if (txtFiltroNoCtrl.Text == "")
                txtFiltroNoCtrl.Text = "No. ctrl.";
        }

        private void txtFiltroNoCtrl_MouseEnter(object sender, EventArgs e)
        {
            if (txtFiltroNoCtrl.Text == "No. ctrl.")
                txtFiltroNoCtrl.Text = "";
        }

        private void txtFiltroNoCtrl_MouseLeave(object sender, EventArgs e)
        {
            if (txtFiltroNoCtrl.Text == "")
                txtFiltroNoCtrl.Text = "No. ctrl.";
        }
        #endregion

        void ObtenerMes(int intMes)
        {
            
            switch (intMes)
            {
                case 0:
                    Deshabilitar();
                    break;
                case 1:
                    Deshabilitar();
                    break;
                case 2:
                    lblMesAPagar.Text = "Enero"; Habilitar();
                    break;
                case 3:
                    lblMesAPagar.Text = "Febrero"; Habilitar();
                    break;
                case 4:
                    lblMesAPagar.Text = "Marzo"; Habilitar();
                    break;
                case 5:
                    lblMesAPagar.Text = "Abril"; Habilitar();
                    break;
                case 6:
                    lblMesAPagar.Text = "Mayo"; Habilitar();
                    break;
                case 7:
                    lblMesAPagar.Text = "Junio"; Habilitar();
                    break;
                case 8:
                    lblMesAPagar.Text = "Julio"; Habilitar();
                    break;
                case 9:
                    lblMesAPagar.Text = "Agosto"; Habilitar();
                    break;
                case 10:
                    lblMesAPagar.Text = "Septiembre"; Habilitar();
                    break;
                case 11:
                    lblMesAPagar.Text = "Octubre"; Habilitar();
                    break;
                case 12:
                    lblMesAPagar.Text = "Noviembre"; Habilitar();
                    break;
                case 13:
                    lblMesAPagar.Text = "Diciembre"; Habilitar();
                    break;
                case 14:
                    lblMesAPagar.Text = "Inscripción"; Habilitar();
                    break;
                default:
                    Deshabilitar();
                    return;

            }
        }

        private void btnRegistroPago_Click(object sender, EventArgs e)
        {
            foreach (Escuela miEscuela in Escuelas.listaEscuela)
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in miEscuela.listaAlumno)
                        if (miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())))
                        {

                            if (DialogResult.Yes == MessageBox.Show("Confirmar pago de: "+miAlumno.Nombre+"\nNúmero de control: "+miAlumno.NumeroDeControl+"\nMes: "+lblMesAPagar.Text+"\nPor el monto de: $"+txtMonto.Text + "\nMétodo de pago: " + cbMetodoPago.selectedValue.ToString(), "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                miAlumno.listaPagos.Add(new Pagos(ObtenerClaveRecibo(), dtFechaPago.Value, double.Parse(txtMonto.Text), txtNota.Text, lblMesAPagar.Text, cbMetodoPago.selectedValue.ToString()));
                                try
                                {
                                    Correo.EnviarCorreo(Correo.CrearCorreo(miAlumno, new Pagos(ObtenerClaveRecibo(), dtFechaPago.Value, double.Parse(txtMonto.Text), txtNota.Text, lblMesAPagar.Text, cbMetodoPago.selectedValue.ToString())));
                                }
                                catch(Exception x)
                                {
                                    MessageBox.Show(x.Message);
                                }
                                listaPagos.Add(new Pagos(ObtenerClaveRecibo(), dtFechaPago.Value, double.Parse(txtMonto.Text), txtNota.Text, lblMesAPagar.Text, cbMetodoPago.selectedValue.ToString()));
                                LlenarDGV(miEscuela);
                                Deshabilitar();
                            }
                        }
            }

        }

        string ObtenerClaveRecibo()
        {
            return dtFechaPago.Value.Day.ToString()+ dtFechaPago.Value.Month.ToString()+ dtFechaPago.Value.Year.ToString() + ((int.Parse("1000")) + (listaPagos.Count)).ToString();
        }

        void RellenarPagos(Alumno miAlumno, int intCaso)
        {
            foreach (Pagos miPagos in miAlumno.listaPagos)
            {
                if(miPagos.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                {
                    if (miPagos.MesPagado.Equals(columna.HeaderText))
                    {
                        foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
                        {
                            if (miAlumno.NumeroDeControl.Equals(Fila.Cells[0].Value.ToString()))
                            {
                                 Fila.Cells[columna.Index].Value = miPagos.Monto.ToString("c");
                                    if (intCaso.Equals(1))
                                    {
                                        Fila.Cells[columna.Index].Style.BackColor = Color.LightGreen;
                                        Fila.Cells[columna.Index].Style.ForeColor = Color.Black;
                                    }
                                    else
                                    {
                                        Fila.Cells[columna.Index].Style.BackColor = Color.FromArgb(238, 250, 90);
                                        Fila.Cells[columna.Index].Style.ForeColor = Color.Black;
                                    }
                                }
                        }
                    }
                }
            }
        }
    }
}
