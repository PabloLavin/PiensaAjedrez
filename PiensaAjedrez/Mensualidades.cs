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
            txtCorreoEnvios.Text = Correo.Usuario;
            txtPassword.Text = Correo.Contrasena;
        }
        
        int intCaso = 1;

        private void Mensualidades_Load(object sender, EventArgs e)
        {
            btnAgregado.Visible = false;
            dtFechaPago.Value = DateTime.Today;
            btnAgregadoGasto.Visible = false;


            Deshabilitar();
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
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
            dtFechaPago.Value = DateTime.Now;
            bnfdtpFechaGasto.Value = DateTime.Now;
            if (ConexionBD.CargarEscuelas().Count > 0)
                cbEscuelas.selectedIndex = 0;
        }

        void CargarDGV(Escuela unaEscuela)
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            if (unaEscuela.CursoActivo == null)
            {
                MessageBox.Show(unaEscuela.Nombre + " no contiene ningún curso actualmente.\nAgregue uno para continuar.");
                return;
            }
            else
            {
                dgvAlumnos.Columns.Add("N° de ctrl.", "N° de ctrl.");
                dgvAlumnos.Columns.Add("ApellidoP", "Apellido P");
                dgvAlumnos.Columns.Add("Apellido M", "Apellido M");
                dgvAlumnos.Columns.Add("Nombre", "Nombre");
                dgvAlumnos.Columns.Add("inscripcion", "Inscripcion");

                List<string> listaMeses = CargarMeses(unaEscuela.CursoActivo);
                foreach (string mes in listaMeses)
                {
                    dgvAlumnos.Columns.Add(mes, mes);
                }
                if (dgvAlumnos.Columns.Count <= 10)
                {
                     dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvAlumnos.Columns[4].Width = 120;
                }
                else
                {
                    dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvAlumnos.Columns[0].Frozen = true;
                    dgvAlumnos.Columns[1].Frozen = true;
                    dgvAlumnos.Columns[2].Frozen = true;
                    dgvAlumnos.Columns[3].Frozen = true;
                }
                dgvAlumnos.Columns[0].Width = 110;
                dgvAlumnos.Columns[1].Width = 115;
                dgvAlumnos.Columns[2].Width = 125;
                dgvAlumnos.Columns[3].Width = 150;

            }
        }

        List<string> CargarMeses(Cursos unCurso)
        {
            List<DateTime> listaMeses = new List<DateTime>();
            List<string> meses = new List<string>();
            if (unCurso.InicioCursos.Year == unCurso.FinCurso.Year)
            {
                while (unCurso.InicioCursos.Month <= unCurso.FinCurso.Month)
                {
                    listaMeses.Add(unCurso.InicioCursos);
                    unCurso.InicioCursos = unCurso.InicioCursos.AddMonths(1);
                }
            }
            else
            {
                bool blnAño = true;
                while (unCurso.InicioCursos.Year <= unCurso.FinCurso.Year)
                {
                    if (!blnAño)
                    {
                        while (unCurso.InicioCursos.Month <= unCurso.FinCurso.Month)
                        {
                            listaMeses.Add(unCurso.InicioCursos);
                            unCurso.InicioCursos = unCurso.InicioCursos.AddMonths(1);
                        }
                        unCurso.InicioCursos = unCurso.InicioCursos.AddYears(1);
                    }
                    while (unCurso.InicioCursos.Month <= 12&&blnAño)
                    {
                        listaMeses.Add(unCurso.InicioCursos);
                        unCurso.InicioCursos = unCurso.InicioCursos.AddMonths(1);
                        if (unCurso.InicioCursos.Month == 1)
                        {
                            blnAño = false;
                        }
                    }
                }
            }
           
            foreach (DateTime mes in listaMeses)
            {
                char c = char.Parse(mes.ToString("MMMM").Substring(0, 1).ToUpper());
                string MesT = c + mes.ToString("MMMM").Substring(1);
                meses.Add(MesT);
            }
            return (meses);
        }

        void Deshabilitar()
        {
            foreach (Control c in bunifuCards1.Controls)
            {
                if (c is Bunifu.Framework.UI.BunifuThinButton2)
                    c.Visible = false;
                if (c is Bunifu.Framework.UI.BunifuMaterialTextbox)
                {
                    c.Enabled = false;
                    c.Text = "";
                }
            }
            dtFechaPago.Visible = false;
            cbMetodoPago.Enabled = false;
            lblMesAPagar.Text = "Mes";
            txtMonto.LineIdleColor = Color.SkyBlue;
            txtNota.LineIdleColor = Color.SkyBlue;
            lblNombre.Text = "Nombre(s) Apellido P. Apellido M.";
            lblNroControl.Text = "19100000";
            chkLiquidado.Enabled = false;
            chkLiquidado.Visible = false;
            lblLiquidado.Visible = false;
            chkLiquidado.Checked = false;
            /*
            if (cbEscuelas.selectedValue.Equals(""))
            { 
                cbGastos.Enabled = false;
                txtMontoAdicional.Enabled = false;
                txtMotivo.Enabled = false;
                btnRegistrarGasto.Visible = false;
            }
            */
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
            chkLiquidado.Enabled = true;
            chkLiquidado.Visible = true;
            lblLiquidado.Visible = true;
            chkLiquidado.Checked = false;
        }

        void LlenarDGV(Escuela otraEscuela)
        {
            dgvAlumnos.Columns.Clear();
            otraEscuela.CursoActivo = ConexionBD.CargarCursoActivo(otraEscuela.Nombre);
            CargarDGV(otraEscuela);
            dgvAlumnos.Rows.Clear();
            if (otraEscuela.CursoActivo.listaActividades.Count > 0)
            {
                foreach (string miActividad in otraEscuela.CursoActivo.listaActividades)
                {
                    dgvAlumnos.Columns.Add(miActividad, miActividad);
                }

            }


            foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(otraEscuela.Nombre))
            {
                if (miAlumno.Activo)
                {
                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl,miAlumno.ApellidoPaterno,miAlumno.ApellidoMaterno, miAlumno.Nombre);
                    RellenarPagos(miAlumno, otraEscuela.CursoActivo.Clave);
                }
            }

            if (otraEscuela.CursoActivo != null)
            {
            lblcantidadinscripcion.Text = ConexionBD.TotalInscripciones(otraEscuela.Nombre).ToString("c");
            lbltotalMensualidades.Text = ConexionBD.TotalMensualidades(otraEscuela.Nombre).ToString("c");
            lblIngresosCantidad.Text= (ConexionBD.TotalInscripciones(otraEscuela.Nombre) + ConexionBD.TotalMensualidades(otraEscuela.Nombre)).ToString("c");
            lblEgresos.Text = ConexionBD.TotalGastos().ToString("c");
                lblIngresos.Text = ConexionBD.TotalIngresos().ToString("c");
                lblBalance.Text = ((double.Parse(lblIngresos.Text.Substring(1))-double.Parse(lblEgresos.Text.Substring(1))).ToString("c"));
                   
            }

        }

        private void cbEscuelas_onItemSelected(object sender, EventArgs e)
        {
            if(Escuelas.listaEscuela.Count>0)
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if (cbEscuelas.selectedValue == miEscuela.Nombre)
                {
                        if (miEscuela.CursoActivo == null)
                        {
                            miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                        }

                        try
                        {
                            LlenarDGV(miEscuela);
                        }
                        catch (Exception)
                        {
                           
                        } 
                        Deshabilitar();
                        cbGastos.Enabled = true;
                        txtMontoAdicional.Enabled = true;
                        txtMotivo.Enabled = true;
                        btnRegistrarGasto.Visible = true;
                        txtMotivo.LineIdleColor = Color.Teal;
                        txtMontoAdicional.LineIdleColor = Color.Teal;
                        
                    }
                    
                }
            
          
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un alumno de la lista.");
                return;
            }
            txtMonto.Text = "";
            txtNota.Text = "";
            txtMonto.Focus();
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if(miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        if(miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())))
                        {
                            lblNroControl.Text = miAlumno.NumeroDeControl;
                            lblNombre.Text = ObtenerNombreCompleto(miAlumno);
                            
                            ObtenerMes(int.Parse(dgvAlumnos.CurrentCell.ColumnIndex.ToString()));
                            if (dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Lime)|| dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Yellow))
                            {
                                 txtMonto.Text = dgvAlumnos.CurrentCell.Value.ToString().Substring(1);
                                foreach (Pagos pagos in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                                {
                                    if (pagos.Monto.ToString("c").Equals(dgvAlumnos.CurrentCell.Value.ToString()) && pagos.MesPagado.Equals(dgvAlumnos.CurrentCell.OwningColumn.HeaderText)&&pagos.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                                    {
                                        txtNota.Text = pagos.Nota;
                                        chkLiquidado.Checked = pagos.Liquidado?false:true;
                                        if (chkLiquidado.Checked)
                                            txtMonto.Text = "";
                                        else
                                        {
                                            btnRegistroPago.Visible = false;
                                        }
                                    }
                                    
                                }
                            }
                        }
            }
        }
       
        #region Filtro
        private void txtFiltroNombre_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            if(cbEscuelas.selectedIndex!=-1)
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                    if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    {
                        miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);

                        foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                            if (ObtenerNombreCompleto(miAlumno).ToLower().Contains(txtFiltroNombre.Text)|| ObtenerNombreCompleto(miAlumno).Contains(txtFiltroNombre.Text)|| ObtenerNombreCompleto(miAlumno).ToUpper().Contains(txtFiltroNombre.Text))
                            {
                                if (miAlumno.Activo)
                                {
                                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                                RellenarPagos(miAlumno, miEscuela.CursoActivo.Clave);
                                }
                            }
                    }
            }
        }

        private void chkNombre_OnChange(object sender, EventArgs e)
        {
            if (!chkNombre.Checked)
            {
                txtFiltroNombre.Enabled = false;
                txtFiltroNombre.LineIdleColor = Color.SkyBlue;
                txtFiltroNombre.Text = "Nombre";
                foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                {
                    if(cbEscuelas.selectedIndex!=-1)
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
                txtFiltroNombre.Text = "";

            }
        }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (!chkCorreo.Checked)
            {
                txtFiltroNoCtrl.Enabled = false;
                txtFiltroNoCtrl.LineIdleColor = Color.SkyBlue;
                txtFiltroNoCtrl.Text = "No. ctrl";
                foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                {
                    if (cbEscuelas.selectedIndex != -1)
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
                txtFiltroNoCtrl.Text = "";
            }
        }

        private void txtFiltroNoCtrl_OnValueChanged(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if (cbEscuelas.selectedIndex != -1)
                    if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    {
                        miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);

                        foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        {

                            if (miAlumno.NumeroDeControl.Contains(txtFiltroNoCtrl.Text))
                            {
                                if (miAlumno.Activo)
                                {
                                    dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                                    RellenarPagos(miAlumno, miEscuela.CursoActivo.Clave);
                                }
                            }
                        }
                    }
            }
        }

        private void cbAño_TextChanged(object sender, EventArgs e)
        {
            if (chkAño.Checked)
            {
                dgvAlumnos.Rows.Clear();
                foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                {
                    if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    {
                        miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);

                        foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        {
                            if (miAlumno.Activo)
                                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                            foreach (Pagos miPago in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                            {
                                if (miPago.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                                {

                                    RellenarPagos(miAlumno, miEscuela.CursoActivo.Clave);
                                }

                            }
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
                foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                {
                    if (cbEscuelas.selectedIndex != -1)
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
            lblMesAPagar.Text = dgvAlumnos.Columns[intMes].HeaderText;
            if (dgvAlumnos.Columns[intMes].HeaderText == "N° de ctrl." || dgvAlumnos.Columns[intMes].HeaderText == "Nombre" || dgvAlumnos.Columns[intMes].HeaderText == "Apellido P" || dgvAlumnos.Columns[intMes].HeaderText == "Apellido M")
            {
                Deshabilitar();
            }
            else if (dgvAlumnos.Columns[intMes].HeaderText == "Inscripcion")
            {
                Habilitar();
                intCaso = 0;
            }
            else
            {
                Habilitar();
                intCaso = 1;
            }
            
        }
        

        private void btnRegistroPago_Click(object sender, EventArgs e)
        {

            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        if (miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())))
                        {

                            if (DialogResult.Yes == MessageBox.Show("Confirmar pago de: " + ObtenerNombreCompleto(miAlumno) + "\nNúmero de control: " + miAlumno.NumeroDeControl + "\nAsunto: " + lblMesAPagar.Text + "\nPor el monto de: $" + txtMonto.Text + "\nMétodo de pago: " + cbMetodoPago.selectedValue.ToString()+"\nNota: "+txtNota.Text, "Confirmar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                                Correo.Usuario = txtCorreoEnvios.Text;
                                Correo.Contrasena = txtPassword.Text;
                                Pagos unPago = new Pagos(ObtenerClaveRecibo(dtFechaPago.Value), dtFechaPago.Value, double.Parse(txtMonto.Text), txtNota.Text, lblMesAPagar.Text, cbMetodoPago.selectedValue.ToString(),false, (chkLiquidado.Checked?false:true), ConexionBD.CargarCursoActivo(miEscuela.Nombre).Clave);
                                if (!unPago.Liquidado)
                                {
                                    if (dgvAlumnos.CurrentCell.Value==null)
                                    {
                                        ConexionBD.AgregarPago(unPago, miAlumno);

                                    }
                                    else
                                    {
                                        ConexionBD.EditarPago(unPago, false, miAlumno.NumeroDeControl, double.Parse(dgvAlumnos.CurrentCell.Value.ToString().Substring(1)));
                                    }                                    
                                }
                                else
                                {
                                    if (dgvAlumnos.CurrentCell.Value==null)
                                    {
                                        unPago.Liquidado = true;
                                        ConexionBD.AgregarPago(unPago, miAlumno);
                                            EnviarCorreo(miAlumno, unPago);
                                    }
                                    else
                                    {

                                        Pagos unPagoAuxiliar = new Pagos(unPago.NumeroRecibo,unPago.FechayHora, unPago.Monto, unPago.Nota, unPago.MesPagado, unPago.MetodoPago, unPago.Notificado, unPago.Liquidado, miEscuela.CursoActivo.Clave);                                        
                                        unPagoAuxiliar.Monto += double.Parse(dgvAlumnos.CurrentCell.Value.ToString().Substring(1));
                                        ConexionBD.EditarPago(unPago, true, miAlumno.NumeroDeControl, double.Parse(dgvAlumnos.CurrentCell.Value.ToString().Substring(1)));
                                    }
                                        
                                }                                
                                miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre); 
                                if(miEscuela.CursoActivo!=null)
                                if (lblMesAPagar.Text.Equals("Inscripcion"))
                                    miEscuela.CursoActivo.TotalInscripcion += double.Parse(txtMonto.Text);
                                else
                                    miEscuela.CursoActivo.TotalMensualidad += double.Parse(txtMonto.Text);

                                miEscuela.CursoActivo.TotalIngresos += double.Parse(txtMonto.Text);
                                LlenarDGV(miEscuela);
                                Deshabilitar();
                            }
                        }
            }
        }

        
        string ObtenerClaveRecibo(DateTime unaFecha)
        {
           return unaFecha.Day.ToString()+unaFecha.Month.ToString()+ unaFecha.Year.ToString() + ((int.Parse("1000")) + (ConexionBD.CargarPagos().Count)).ToString();
        }

        string ObtenerNombreCompleto(Alumno unAlumno)
        {
            return (unAlumno.ApellidoPaterno+" "+unAlumno.ApellidoMaterno+" "+unAlumno.Nombre);
        }

        void RellenarPagos(Alumno miAlumno, string strCurso)
        {
            foreach (Pagos miPagos in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
            {
                if (miPagos.IDCurso.Equals(strCurso))
                    foreach (DataGridViewColumn columna in dgvAlumnos.Columns)
                    {
                        if (miPagos.MesPagado.Equals(columna.HeaderText))
                        {
                            foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
                            {
                                if (miAlumno.NumeroDeControl.Equals(Fila.Cells[0].Value.ToString()))
                                {
                                    Fila.Cells[columna.Index].Value = miPagos.Monto.ToString("c");
                                    Fila.Cells[columna.Index].Style.ForeColor = Color.Black;                                    
                                    if (miPagos.Notificado)
                                        Fila.Cells[columna.Index].Style.BackColor = Color.Lime;
                                    else
                                        Fila.Cells[columna.Index].Style.BackColor = Color.Yellow;
                                }
                            }
                        }
                    }
            }
        }

        void EnviarCorreo(Alumno miAlumno,Pagos miPago)
        {
            try
            {
                Correo.Usuario = txtCorreoEnvios.Text;
                Correo.Contrasena = txtPassword.Text;
                Correo.EnviarCorreo(Correo.CrearCorreo(miAlumno, miPago, intCaso));
                miPago.Notificado = true;
                ConexionBD.ConfirmarEnvioCorreo(miPago);
                  
               
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al intentar enviar un correo.\nCompruebe sus credenciales y la conexión a internet.\nSi el error persiste, intente más tarde.", "Error de conexión", MessageBoxButtons.OK,MessageBoxIcon.Error);
                foreach (Pagos pagos in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                {
                    if (pagos.Equals(miPago))
                    {
                        pagos.Notificado = false;
                        ConexionBD.ConfirmarEnvioCorreo(pagos);
                    }
                }
            }
            LlenarDGV(new Escuela(cbEscuelas.selectedValue));

        }

        private void btnRegistrarGasto_Click(object sender, EventArgs e)
        {
            /*try
            {*/
            if (cbGastos.selectedIndex != -1)
            {
                try
                {
                    if (DialogResult.Yes == MessageBox.Show("Confirmar gasto:\nRazón: " + cbGastos.selectedValue.ToString() + "\nMonto: " + double.Parse(txtMontoAdicional.Text).ToString("c") + "\nEscuela: " + cbEscuelas.selectedValue.ToString() + "\nFecha: " + bnfdtpFechaGasto.Value + "\nNota: " + txtMotivo.Text, "Confirmar gasto", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        ConexionBD.RegistrarGasto(cbGastos.selectedValue.ToString(), double.Parse(txtMontoAdicional.Text), txtMotivo.Text, cbEscuelas.selectedValue.ToString(), bnfdtpFechaGasto.Value, ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue.ToString()).Clave);
                        MessageBox.Show("Gasto registrado con éxito.", "Registro de gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { MessageBox.Show("Introduzca solo valores numéricos."); return; }
                txtMontoAdicional.Text = "";
                txtMotivo.Text = "";
                LlenarDGV(new Escuela(cbEscuelas.selectedValue));
            }
            else
            {
                MessageBox.Show("Seleccione un asunto de gasto.");
                return;
            }
               
            /*}
            catch (Exception)
            {
                MessageBox.Show("Error al registrar gasto", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/          
        }

        private void dgvAlumnos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bool blnReenviar = false;
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un alumno de la lista.");
                return;
            }
            if(dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Yellow)||dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Lime))
                if (DialogResult.Yes == MessageBox.Show("¿Intentar de nuevo?", "Enviar correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    blnReenviar = true;
                }
          
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        if (miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString())))
                        {
                            lblNroControl.Text = miAlumno.NumeroDeControl;
                            lblNombre.Text = ObtenerNombreCompleto(miAlumno);
                            ObtenerMes(int.Parse(dgvAlumnos.CurrentCell.ColumnIndex.ToString()));
                            
                                foreach (Pagos miPago in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                                {
                                    if(dgvAlumnos.CurrentCell.Value!=null)
                                    if (miPago.Monto.ToString("c").Equals(dgvAlumnos.CurrentCell.Value.ToString()) && miPago.MesPagado.Equals(dgvAlumnos.CurrentCell.OwningColumn.HeaderText) && miPago.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                                    {
                                        txtNota.Text = miPago.Nota;
                                        chkLiquidado.Checked = miPago.Liquidado ? false : true;
                                        if (chkLiquidado.Checked)
                                            txtMonto.Text = "";
                                        if (blnReenviar)
                                        {
                                            EnviarCorreo(miAlumno, miPago);
                                            LlenarDGV(miEscuela);
                                            Deshabilitar();
                                        }
                                    }

                                }
                            
                        }
            }

        }

        private void btnVerGastos_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
