using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerializacionLibreria;
using iTextSharp.text.pdf;
using System.IO;
using PiensaAjedrez.Pantallas;
using iTextSharp.text;
using System.Diagnostics;

namespace PiensaAjedrez
{
    public partial class Mensualidades : UserControl
    {
        public Mensualidades()
        {
            InitializeComponent();
            VisibilidadControles(false);
            btnListasActualizadas.Visible = true;

        }

        int intCaso = 1;
        public bool blnAceptarPago;

        private void Mensualidades_Load(object sender, EventArgs e)
        {
            //Recordatorios.unEvento += MetodoGestor;
            btnAgregado.Visible = false;
            dtFechaPago.Value = DateTime.Today;
            btnAgregadoGasto.Visible = false;


            Deshabilitar();
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                cbEscuelas.AddItem(miEscuela.Nombre);
            }



            cbAño.Items.Clear();
            for (int i = 2010; i <= 2050; i++)
            {
                cbAño.Items.Add(Convert.ToString(i));
            }
            cbAño.Text = DateTime.Today.Year.ToString();
            dtFechaPago.Value = DateTime.Now;
            bnfdtpFechaGasto.Value = DateTime.Now;
            if (ConexionBD.CargarEscuelas().Count > 0)
            {
                cbEscuelas.selectedIndex = 0;
              
            }
         
               

            Recordatorios.CargarConfiguracion();
            //MessageBox.Show(Recordatorios.dtmHoraRecordatorio.ToShortTimeString());
            NotificarRetardos(Recordatorios.intCaso);

            InicializarDGVEstadisticas();

        }

        void InicializarDGVEstadisticas()
        {
            dgvEstadisticas.Rows.Clear();
            dgvEstadisticas.Columns.Clear();
            DgvEstadisticasEscuela.Rows.Clear();
            DgvEstadisticasEscuela.Columns.Clear();
            dgvAlumnosParticular.Rows.Clear();
            dgvAlumnosParticular.Columns.Clear();

            dgvEstadisticas.Columns.Add("labels", "");
            dgvEstadisticas.Columns.Add("datos", "");

            dgvAlumnosParticular.Columns.Add("labels", "");
            dgvAlumnosParticular.Columns.Add("datos", "");

            DgvEstadisticasEscuela.Columns.Add("labels", "");
            DgvEstadisticasEscuela.Columns.Add("datos", "");


            dgvEstadisticas.Rows.Add("Ingresos", ConexionBD.TotalIngresos().ToString("c"));
            dgvEstadisticas.Rows.Add("Egresos", ConexionBD.TotalGastos().ToString("c"));
            dgvEstadisticas.Rows.Add("Balance Total", (ConexionBD.TotalIngresos()-ConexionBD.TotalGastos()).ToString("c"));
            dgvEstadisticas.Rows.Add("Total Alumnos", Convert.ToString(ConexionBD.CantidadAlumnos()));
            dgvEstadisticas.Rows.Add("Alumnos Activos", Convert.ToString(ConexionBD.CantidadAlumnosActivos()));

            DgvEstadisticasEscuela.Rows.Add("Inscripciones","$0.00");
            DgvEstadisticasEscuela.Rows.Add("Mensualidades", "$0.00");
            DgvEstadisticasEscuela.Rows.Add("Total Ingresos", "$0.00");
            dgvAlumnosParticular.Rows.Add("Total Alumnos", "0");
            dgvAlumnosParticular.Rows.Add("Alumnos Activos", "0");

            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) != null)
            {
                 DgvEstadisticasEscuela.Rows.Clear();
                dgvAlumnosParticular.Rows.Clear();
                 DgvEstadisticasEscuela.Rows.Add("Inscripciones", ConexionBD.TotalInscripciones(cbEscuelas.selectedValue).ToString("c"));
                 DgvEstadisticasEscuela.Rows.Add("Mensualidades", ConexionBD.TotalMensualidades(cbEscuelas.selectedValue,ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave).ToString("c"));
                 DgvEstadisticasEscuela.Rows.Add("Total Ingresos", (ConexionBD.TotalInscripciones(cbEscuelas.selectedValue)+ ConexionBD.TotalMensualidades(cbEscuelas.selectedValue, ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave)).ToString("c"));
                dgvAlumnosParticular.Rows.Add("Total Alumnos", Convert.ToString(ConexionBD.CantidadAlumnos(cbEscuelas.selectedValue)));
                dgvAlumnosParticular.Rows.Add("Alumnos Activos", Convert.ToString(ConexionBD.CantidadAlumnosActivos(cbEscuelas.selectedValue)));
            }

            dgvEstadisticas.Rows[0].Cells[0].Style.BackColor = Color.DarkGreen;
            dgvEstadisticas.Rows[1].Cells[0].Style.BackColor = Color.Maroon;
            dgvEstadisticas.Rows[0].Cells[1].Style.BackColor = Color.ForestGreen;
            dgvEstadisticas.Rows[1].Cells[1].Style.BackColor = Color.FromArgb(224, 139, 139);
            dgvEstadisticas.Rows[0].Cells[0].Style.ForeColor = Color.White;
            dgvEstadisticas.Rows[1].Cells[0].Style.ForeColor = Color.White;
            dgvEstadisticas.Rows[0].Cells[1].Style.ForeColor = Color.White;
            dgvEstadisticas.Rows[1].Cells[1].Style.ForeColor = Color.White;
            dgvEstadisticas.Rows[4].Cells[1].Selected = true;
            dgvAlumnosParticular.Columns[1].Width = 65;
        }

        void CargarDatosEscuela(string strNombreEscuela)
        {
      
            //lblAlumnosTotal.Text = Convert.ToString(ConexionBD.CantidadAlumnos());
            //lblAlumnosActivos.Text = Convert.ToString(ConexionBD.CantidadAlumnosActivos());
            //lblEscuelaAlumnos.Text = Convert.ToString(ConexionBD.CantidadAlumnos(strNombreEscuela));
            //lblEscuelaActivos.Text = Convert.ToString(ConexionBD.CantidadAlumnosActivos(strNombreEscuela));
        }

        FormMensaje unaForma = new FormMensaje();

        void CargarDGV(Escuela unaEscuela)
        {
            dgvAlumnos.Columns.Clear();
            dgvAlumnos.Rows.Clear();
            if (unaEscuela.CursoActivo == null)
            {
                unaForma.Mostrar("Error",unaEscuela.Nombre + " no contiene ningún curso actualmente.\nAgregue uno para continuar.",1,this);
                return;
            }
            else
            {                
                dgvAlumnos.Columns.Add("N°", "N°");                
                dgvAlumnos.Columns.Add("N° de ctrl.", "N° Control");                
                dgvAlumnos.Columns.Add("ApellidoP", "Apellido P");
                dgvAlumnos.Columns.Add("Apellido M", "Apellido M");
                dgvAlumnos.Columns.Add("Nombre", "Nombre");
                dgvAlumnos.Columns.Add("Inscripcion", "Inscripcion");
                dgvAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvAlumnos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                List<string> listaMeses = CargarMeses(unaEscuela.CursoActivo);
                foreach (string mes in listaMeses)
                {
                    dgvAlumnos.Columns.Add(mes, mes.Substring(0, 3));
                }
                if (dgvAlumnos.Columns.Count <= 8)
                {
                     dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    //dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvAlumnos.Columns[5].Width = 120;
                }
                else
                {
                    dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    //dgvAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvAlumnos.Columns[0].Width = 30;
                    dgvAlumnos.Columns[0].Frozen = true;
                    dgvAlumnos.Columns[1].Frozen = true;
                    dgvAlumnos.Columns[2].Frozen = true;
                    dgvAlumnos.Columns[3].Frozen = true;
                    dgvAlumnos.Columns[4].Frozen = true;
                }
                dgvAlumnos.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dgvAlumnos.Columns[1].Width = 110;
                dgvAlumnos.Columns[2].Width = 115;
                dgvAlumnos.Columns[3].Width = 125;
                dgvAlumnos.Columns[4].Width = 150;
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
                    if (unCurso.InicioCursos.Month == 12)
                        break;
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
                string MesT = (c + mes.ToString("MMMM").Substring(1));
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
                if (c is TextBox)
                {
                    c.Enabled = false;
                    c.Text = "";
                }
            }
            dtFechaPago.Visible = false;
            cbMetodoPago.Enabled = false;
            lblMesAPagar.Text = "Mes";
            //txtMonto.LineIdleColor = Color.SkyBlue;
            
            lblNombre.Text = "Nombre(s) Apellido P. Apellido M.";
            lblNroControl.Text = "19100000";
            chkLiquidado.Enabled = false;
            chkLiquidado.Visible = false;
            chkBeca.Visible = false;
            txtBeca.Visible = false;
            lblBeca.Visible = false;
            lblLiquidado.Visible = false;
            chkLiquidado.Checked = false;
            VisibilidadControles(false);
           
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
                if (c is TextBox)
                    c.Enabled = true;
            }
            
            cbMetodoPago.Enabled = true;
            //txtMonto.LineIdleColor = Color.Teal;
            
            chkLiquidado.Enabled = true;
            chkLiquidado.Visible = true;
           
            lblLiquidado.Visible = true;
            chkLiquidado.Checked = false;
            VisibilidadControles(false);
            chkBeca.Visible = true;
            //txtBeca.Visible = true;
            lblBeca.Visible = true;

        }


        void RellenarDGV(Escuela otraEscuela)
        {
            try
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
                int numero = 1;

                foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(otraEscuela.Nombre))
                {
                    if (miAlumno.Activo)
                    {
                        dgvAlumnos.Rows.Add(numero, miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                        RellenarPagos(miAlumno, otraEscuela.CursoActivo.Clave);
                        numero++;
                    }
                }

            }
            catch (Exception)
            {

            }

        }

        void LlenarDGV(Escuela otraEscuela)
        {
            if (chkNombre.Checked|| chkCorreo.Checked || chkAño.Checked)
            {
                try
                {
                    Filtrar();
                }
                catch (Exception)
                {
                    RellenarDGV(otraEscuela);
                }
                
            }
            else
                RellenarDGV(otraEscuela);
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
                            //new FormMensaje().Mostrar("Error", "Ocurrió un error. Comprueba los cursos activos.", 1, this);
                           
                        }

                        try
                        {
                            
                            InicializarDGVEstadisticas();
                            CargarDatosEscuela(cbEscuelas.selectedValue);
                        }
                        catch (Exception)
                        {
                            
                            DgvEstadisticasEscuela.Rows[1].Cells[1].Value = "$0.00";
                            DgvEstadisticasEscuela.Rows[2].Cells[1].Value = "$0.00";
                            DgvEstadisticasEscuela.Rows[0].Cells[1].Value = "$0.00";
                        }
                        Deshabilitar();
                        cbGastos.Enabled = true;
                        txtMontoAdicional.Enabled = true;
                        txtMotivo.Enabled = true;
                        btnRegistrarGasto.Visible = true;

                        
                    }
                    
                }
            
          
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvAlumnos.CurrentRow == null)
            {
                unaForma.Mostrar("Error","Seleccione un alumno de la lista.",1,this);
                return;
            }
            txtMonto.Text = "";
            txtNota.Text = "";
            txtMonto.Focus();
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if(miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        if(miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[1].Value.ToString())))
                        {
                            lblNroControl.Text = miAlumno.NumeroDeControl;
                            lblNombre.Text = ObtenerNombreCompleto(miAlumno);
                            
                            ObtenerMes(int.Parse(dgvAlumnos.CurrentCell.ColumnIndex.ToString()));
                            if (dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Lime)|| dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Yellow))
                            {
                                 txtMonto.Text = dgvAlumnos.CurrentCell.Value.ToString().Substring(1);
                                foreach (Pagos pagos in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                                {
                                    if (pagos.Monto.ToString("c").Equals(dgvAlumnos.CurrentCell.Value.ToString()) && pagos.MesPagado.Equals(dgvAlumnos.CurrentCell.OwningColumn.Name)&&pagos.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
                                    {
                                        txtNota.Text = pagos.Nota;
                                        chkLiquidado.Checked = pagos.Liquidado?false:true;
                                        if (chkLiquidado.Checked)
                                            txtMonto.Text = "";
                                        else
                                        {
                                            btnRegistroPago.Visible = false;
                                            VisibilidadControles(true);
                                            MostrarPago(pagos, miAlumno.NumeroDeControl);
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
           
        }

        private void chkNombre_OnChange(object sender, EventArgs e)
        {
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) == null)
                return;
            if (!chkNombre.Checked)
            {
                txtFiltroNombre.Enabled = false;
              
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
                
                txtFiltroNombre.Text = "";

            }
        }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) == null)
                return;
            if (!chkCorreo.Checked)
            {
                txtFiltroNoCtrl.Enabled = false;
               
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
                txtFiltroNoCtrl.Text = "";
            }
        }

        private void txtFiltroNoCtrl_OnValueChanged(object sender, EventArgs e)
        {
           
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
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) == null)
                return;
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
            lblMesAPagar.Text = dgvAlumnos.Columns[intMes].Name;
            if (dgvAlumnos.Columns[intMes].Name == "N° de ctrl." || dgvAlumnos.Columns[intMes].Name == "Nombre" || dgvAlumnos.Columns[intMes].Name == "Apellido P" || dgvAlumnos.Columns[intMes].Name == "Apellido M" || dgvAlumnos.Columns[intMes].Name == "N°")
            {
                Deshabilitar();
            }
            else if (dgvAlumnos.Columns[intMes].Name == "Inscripcion")
            {
                Habilitar();
                intCaso = 0;
            }
            else if (EsActividad(dgvAlumnos.Columns[intMes].Name))
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

        bool EsActividad(string strMes)
        {
            switch (strMes)
            {
                case "Enero":                    
                case "Febrero":                    
                case "Marzo":                    
                case "Abril":                    
                case "Mayo":                    
                case "Junio":                    
                case "Julio":                    
                case "Agosto":
                case "Septiembre":
                case "Octubre":                    
                case "Noviembre":                    
                case "Diciembre":
                    return false;
                default:
                    return true;
            }
        }

        private void btnRegistroPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMonto.Text != "" || double.Parse(txtMonto.Text) > 0)
                    foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
                    {
                        if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                            foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                                if (miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[1].Value.ToString())))
                                {

                                    if (Preguntar("Confirmación", "Confirmar pago de: " + ObtenerNombreCompleto(miAlumno) + "\nNúmero de control: " + miAlumno.NumeroDeControl + "\nAsunto: " + lblMesAPagar.Text + "\nPor el monto de: $" + txtMonto.Text + "\nMétodo de pago: " + cbMetodoPago.selectedValue.ToString() + "\nNota: " + txtNota.Text))
                                    {
                                        miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                                        
                                        Pagos unPago = new Pagos(ObtenerClaveRecibo(dtFechaPago.Value), dtFechaPago.Value, double.Parse(txtMonto.Text), txtNota.Text, lblMesAPagar.Text, cbMetodoPago.selectedValue.ToString(), false, (chkLiquidado.Checked ? false : true), ConexionBD.CargarCursoActivo(miEscuela.Nombre).Clave, (chkBeca.Checked ? true : false), (chkBeca.Checked ? ObtenerBeca(double.Parse(txtMonto.Text), double.Parse(txtBeca.Text)) : 0),(chkBeca.Checked? Int16.Parse(txtBeca.Text):(Int16)0));
                                        if (!unPago.Liquidado)
                                        {
                                            if (dgvAlumnos.CurrentCell.Value == null)
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
                                            if (dgvAlumnos.CurrentCell.Value == null)
                                            {
                                                miAlumno.PorcentajeBeca = (txtBeca.Text != "") ? Int16.Parse(txtBeca.Text) : (short)0;
                                                unPago.Liquidado = true;
                                                ConexionBD.AgregarPago(unPago, miAlumno);
                                                EnviarCorreo(miAlumno, unPago);
                                            }
                                            else
                                            {

                                                Pagos unPagoAuxiliar = new Pagos(unPago.NumeroRecibo, unPago.FechayHora, unPago.Monto, unPago.Nota, unPago.MesPagado, unPago.MetodoPago, unPago.Notificado, unPago.Liquidado, miEscuela.CursoActivo.Clave, (chkBeca.Checked ? true : false), (chkBeca.Checked ? ObtenerBeca(double.Parse(txtMonto.Text), double.Parse(txtBeca.Text)) : 0), (chkBeca.Checked ? Int16.Parse(txtBeca.Text) : (Int16)0));
                                                unPagoAuxiliar.Monto += double.Parse(dgvAlumnos.CurrentCell.Value.ToString().Substring(1));
                                                ConexionBD.EditarPago(unPago, true, miAlumno.NumeroDeControl, double.Parse(dgvAlumnos.CurrentCell.Value.ToString().Substring(1)));
                                            }

                                        }
                                        miEscuela.CursoActivo = ConexionBD.CargarCursoActivo(miEscuela.Nombre);
                                        if (miEscuela.CursoActivo != null)
                                            if (lblMesAPagar.Text.Equals("Inscripcion"))
                                                miEscuela.CursoActivo.TotalInscripcion += double.Parse(txtMonto.Text);
                                            else
                                                miEscuela.CursoActivo.TotalMensualidad += double.Parse(txtMonto.Text);

                                        miEscuela.CursoActivo.TotalIngresos += double.Parse(txtMonto.Text);
                                        InicializarDGVEstadisticas();
                                        LlenarDGV(miEscuela);
                                        Deshabilitar();
                                    }
                                }
                    }
            }
            catch (Exception)
            {

                unaForma.Mostrar("Error", "Introduzca únicamente valores válidos", 1,this);
            }
        }

        
        string ObtenerClaveRecibo(DateTime unaFecha)
        {
           return unaFecha.Day.ToString()+unaFecha.Month.ToString()+ unaFecha.Year.ToString() + ((int.Parse("1000")) + (ConexionBD.CargarPagos().Count)+new Random().Next(500)).ToString();
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
                        if (miPagos.MesPagado.Equals(columna.Name))
                        {
                            foreach (DataGridViewRow Fila in dgvAlumnos.Rows)
                            {
                                if (miAlumno.NumeroDeControl.Equals(Fila.Cells[1].Value.ToString()))
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
                
                Correo.EnviarCorreo(Correo.CrearCorreo(miAlumno, miPago, intCaso));
                miPago.Notificado = true;
                ConexionBD.ConfirmarEnvioCorreo(miPago);
            }
            catch (Exception)
            {
                unaForma.Mostrar("Error de conexión","Ocurrió un error al intentar enviar un correo.\nCompruebe sus credenciales y la conexión a internet.\nSi el error persiste, intente más tarde.",4,this);
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
                    if (Preguntar("Confirmar gasto", "Confirmar gasto:\nRazón: " + cbGastos.selectedValue.ToString() + "\nMonto: " + double.Parse(txtMontoAdicional.Text).ToString("c") +"\nFecha: " + bnfdtpFechaGasto.Value + "\nNota: " + txtMotivo.Text))
                    {
                        ConexionBD.RegistrarGasto(cbGastos.selectedValue.ToString(), double.Parse(txtMontoAdicional.Text), txtMotivo.Text, bnfdtpFechaGasto.Value);
                        unaForma.Mostrar("Registro de gasto", "Gasto registrado con éxito.",5,this);
                    }
                }
                catch (Exception) { unaForma.Mostrar("Error","Introduzca solo valores numéricos.",1,this); return; }
                txtMontoAdicional.Text = "";
                txtMotivo.Text = "";
                LlenarDGV(new Escuela(cbEscuelas.selectedValue));
                InicializarDGVEstadisticas();
            }
            else
            {
                unaForma.Mostrar("Error","Seleccione un asunto de gasto.",1,this);
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
                unaForma.Mostrar("Error","Seleccione un alumno de la lista.",1,this);
                return;
            }
            if(dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Yellow)||dgvAlumnos.CurrentCell.Style.BackColor.Equals(Color.Lime))
                if (Preguntar("Enviar correo", "¿Intentar de nuevo?"))
                {
                    blnReenviar = true;
                }
          
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                if (miEscuela.Equals(new Escuela(cbEscuelas.selectedValue)))
                    foreach (Alumno miAlumno in ConexionBD.CargarAlumnos(miEscuela.Nombre))
                        if (miAlumno.Equals(new Alumno(dgvAlumnos.CurrentRow.Cells[1].Value.ToString())))
                        {
                            lblNroControl.Text = miAlumno.NumeroDeControl;
                            lblNombre.Text = ObtenerNombreCompleto(miAlumno);
                            ObtenerMes(int.Parse(dgvAlumnos.CurrentCell.ColumnIndex.ToString()));
                            
                                foreach (Pagos miPago in ConexionBD.CargarPagosAlumno(miAlumno.NumeroDeControl))
                                {
                                    if(dgvAlumnos.CurrentCell.Value!=null)
                                    if (miPago.Monto.ToString("c").Equals(dgvAlumnos.CurrentCell.Value.ToString()) && miPago.MesPagado.Equals(dgvAlumnos.CurrentCell.OwningColumn.Name) && miPago.FechayHora.Year.Equals(int.Parse(cbAño.Text)))
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
                                        VisibilidadControles(true);
                                        MostrarPago(miPago, miAlumno.NumeroDeControl);
                                    }

                                }
                            
                        }
            }

        }

        void VisibilidadControles(bool blnEsconder)
        {
            foreach (Control control in gbEsconder.Controls)
            {
                if (control is Label)
                    control.Visible = blnEsconder;
            }
            gbEsconder.Visible = blnEsconder;
            txtBeca.Visible = false;
            lblBeca.Visible = false;
            chkBeca.Visible = false;
        }

        private void btnVerGastos_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void LblInformacion_Click(object sender, EventArgs e)
        {
        }

        private void TxtFiltroNombre_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltroNoCtrl_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        void MostrarPago(Pagos unPago, string strControl)
        {
            lblInfo1.Text = unPago.NumeroRecibo;
            lblInfo2.Text = strControl;
            lblInfo3.Text = unPago.Monto.ToString("C");
            lblInfo4.Text = unPago.MetodoPago;
            lblInfo5.Text = unPago.FechayHora.ToShortDateString();
            lblInfo6.Text = unPago.Nota;
            lblInfo7.Text = unPago.MontoBeca.ToString("C");
        }

        private void Filtrar()
        {
            if (ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue) != null)
            {
                Filtro unFiltro = new Filtro();
                unFiltro.NumeroControl = chkCorreo.Checked;
                unFiltro.Escuela = true;
                unFiltro.Nombre = chkNombre.Checked;

                if (cbEscuelas.selectedIndex >= 0)
                    unFiltro.ValorEscuela = cbEscuelas.selectedValue;

                unFiltro.ValorFecha = DateTime.Now;
                unFiltro.ValorNombre = txtFiltroNombre.Text;
                unFiltro.ValorNoControl = txtFiltroNoCtrl.Text;
                int intContador = 0;
                dgvAlumnos.Rows.Clear();
                foreach (Alumno miAlumno in ConexionBD.CargarAlumnosFiltrados(unFiltro))
                {
                    if (miAlumno.Activo && miAlumno.Escuela == cbEscuelas.selectedValue)
                    {
                        intContador++;
                        dgvAlumnos.Rows.Add(intContador, miAlumno.NumeroDeControl, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre);
                        RellenarPagos(miAlumno, ConexionBD.CargarCursoActivo(miAlumno.Escuela).Clave);
                    }
                }
            }
        }

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            blnAceptarPago = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 3, this);
            blnAceptarPago = unaForma.Aceptar();
            return blnAceptarPago;
        }

       
        double ObtenerBeca(double dblMonto, double dblPorcentaje)
        {
            return (dblMonto * (dblPorcentaje / 100));
        }

        private void ChkBeca_OnChange(object sender, EventArgs e)
        {
            if (chkBeca.Checked)
            {
                txtBeca.Visible = true;
                cbMetodoPago.selectedIndex = 2;
            }
            else
            {
                txtBeca.Visible = false;
                cbMetodoPago.selectedIndex = 0;
            }
        }

        private void BtnVerIngresos_Click(object sender, EventArgs e)
        {
            new IngresosForma().ShowDialog();
        }

        #region Retardos
       public bool PreguntarRetardo(string strEncabezado, string strMensaje)
        {
            blnAceptarPago = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 6, this);
            blnAceptarPago = unaForma.Aceptar();
            return blnAceptarPago;
        }

       public void NotificarRetardos(int intCaso)
        {
            if (intCaso == 0)
                if (DateTime.Today.Day == 10|| DateTime.Today.Day == 20||EsUltimoDia() || DateTime.Today.Day == 26)
                {
                    if (PreguntarRetardo("Retardos en pago", "¿Desea enviar un correo a todos los deudores?"))
                    {
                        int i = 0;
                        foreach (Escuela unaEscuela in ConexionBD.CargarEscuelas())
                        {
                            cbEscuelas.selectedIndex = i;
                            ConexionBD.BorrarDeudas(ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave);

                            foreach (Alumno alumno in ObtenerAlumnosDeudores(cbEscuelas.selectedValue))
                            {
                                AñadirDeuda(alumno);
                                
                            }
                            i++;
                        }
                            try
                            {
                               
                                EnviarCorreos();
                            }
                            catch (Exception)
                            {
                                unaForma.Mostrar("Error de conexión", "Ocurrió un error al intentar enviar un correo.\nCompruebe sus credenciales y la conexión a internet.\nSi el error persiste, intente más tarde.", 4, this);
                            }

                    }
                    else if (Recordatorios.intCaso == 1)
                        NotificarRetardos(1);
                    else if(Recordatorios.intCaso==2)
                        return;
                }
            if (intCaso == 1)
            {
                if (DateTime.Today.Day == 10 || DateTime.Today.Day == 20 || EsUltimoDia() || DateTime.Today.Day == 26)
                    if (DateTime.Now.TimeOfDay.Hours>=Recordatorios.dtmHoraRecordatorio.TimeOfDay.Hours && DateTime.Now.TimeOfDay.Minutes >= Recordatorios.dtmHoraRecordatorio.TimeOfDay.Minutes)
                    {
                        NotificarRetardos(0);
                    }
            }
        }

        bool EsUltimoDia()
        {
            if(DateTime.Now.Month==1|| DateTime.Now.Month == 3|| DateTime.Now.Month == 5 || DateTime.Now.Month == 7 || DateTime.Now.Month == 8 || DateTime.Now.Month == 10|| DateTime.Now.Month == 12)
            {
                if (DateTime.Now.Day == 31)
                    return true;
                else
                    return false;
            }
            if (DateTime.Now.Month == 4 || DateTime.Now.Month == 6 || DateTime.Now.Month == 9 || DateTime.Now.Month == 11 )
            {
                if (DateTime.Now.Day == 30)
                    return true;
                else
                    return false;
            }
            if (DateTime.Now.Month == 2)
                if (DateTime.Now.Day == 28)
                    return true;
                else
                    return false;
            return false;
        }
        #endregion

        #region ADEUDO
        void AñadirDeuda(Alumno unAlumno)
        {
            foreach (string unMes in ObtenerMesesDeuda(unAlumno))
            {
                ConexionBD.AgregarDeudor(unAlumno.NumeroDeControl, unMes, ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave);
            }
        }

        List<string> ObtenerMesesDelCurso()
        {
            List<string> listaMeses = new List<string>();
            //foreach (DataGridViewColumn encabezado in dgvAlumnos.Columns)
            for (int i = 6; i < dgvAlumnos.Columns.Count; i++)
            {
                listaMeses.Add(dgvAlumnos.Columns[i].Name);
                if (DateTime.Now.ToString("MMMM") == dgvAlumnos.Columns[i].Name.ToLower())
                    break;
            }
            return listaMeses;
        }

        List<string> ObtenerMesesDeuda(Alumno unAlumno)
        {
            List<string> listaMeses = new List<string>();
            if(ConexionBD.CargarPagosAlumnoCurso(unAlumno, ConexionBD.CargarCursoActivo(unAlumno.Escuela).Clave).Count > 0)
            {
            foreach (Pagos unPago in ConexionBD.CargarPagosAlumnoCurso(unAlumno, ConexionBD.CargarCursoActivo(unAlumno.Escuela).Clave))
            {
                foreach (string mes in ObtenerMesesDelCurso())
                {
                    if (mes!=unPago.MesPagado /*&& !ObtenerMesesDelCurso().Contains(unPago.MesPagado)*/)
                        listaMeses.Add(mes);
                }
            }
            }
            else
            {
                foreach (string unMes in ObtenerMesesDelCurso())
                {
                    listaMeses.Add(unMes);
                }
            }
            return listaMeses;
        }

        List<Alumno> ObtenerAlumnosDeudores(string strNombreEscuela)
        {
            List<Alumno> listaAlumnos = new List<Alumno>();
           
                foreach (Alumno unAlumno in ConexionBD.CargarAlumnos(strNombreEscuela))
                {
                    if (ObtenerMesesDeuda(unAlumno).Count > 0)
                        listaAlumnos.Add(unAlumno);
                }
            
            return listaAlumnos;
        }
        #endregion

        void EnviarCorreos()
        {
            foreach (Escuela escuela in ConexionBD.CargarEscuelas())
            {
            foreach (Alumno unAlumno in ConexionBD.CargarDeudores(ConexionBD.CargarCursoActivo(escuela.Nombre).Clave))
                Correo.EnviarCorreo(Correo.CrearRecordatorio(unAlumno));            
            }
        }

        private void BtnArchivar_Click(object sender, EventArgs e)
        {
            new ArchivarForma().ShowDialog();
            LlenarDGV(new Escuela(cbEscuelas.selectedValue));
        }

        private void Mensualidades_Enter(object sender, EventArgs e)
        {
            LlenarDGV(new Escuela(cbEscuelas.selectedValue));
        }

        private void btnListasActualizadas_Click(object sender, EventArgs e)
        {
            PdfPTable pdfTable = new PdfPTable(dgvAlumnos.ColumnCount);
            List<float> aFloat = new List<float>();
            foreach (DataGridViewColumn column in dgvAlumnos.Columns)
            {
                aFloat.Add(column.Width);
            }
            pdfTable.SetWidths(aFloat.ToArray());
            pdfTable.DefaultCell.Padding = 3;            
            pdfTable.WidthPercentage = 100;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            
            foreach (DataGridViewColumn column in dgvAlumnos.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }
            int maxWidth = 0;
            
            foreach (DataGridViewRow row in dgvAlumnos.Rows)
            {
                
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.Value != null)
                    {
                        if (cell.Size.Width >= maxWidth)
                            maxWidth = cell.Size.Width;
                        pdfTable.AddCell(cell.Value.ToString());                                                
                    }
                    else
                        pdfTable.AddCell("");
                }                        
            }            
            
            string folderPath = Directory.GetCurrentDirectory();
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + @"\ListaActualizada.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(new iTextSharp.text.Rectangle(0, 0, (int) PageSize.A4.Height, (int) PageSize.A4.Width), 10f, 10f, 20f, 10f);                                
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                double dblTotalIngresos = ConexionBD.TotalInscripciones(cbEscuelas.selectedValue) + ConexionBD.TotalMensualidades(cbEscuelas.selectedValue, ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue).Clave);
                Cursos unCurso = ConexionBD.CargarCursoActivo(cbEscuelas.selectedValue);
                iTextSharp.text.Image pic = iTextSharp.text.Image.GetInstance("PiensaAjedrezLogo2.png");
                pic.Alignment = Element.ALIGN_CENTER;
                pic.ScalePercent(45);
                pdfDoc.Add(pic);
                pdfDoc.Add(new Paragraph(" "));
                Paragraph prHeader = new Paragraph("Lista de pago actualizada     " + cbEscuelas.selectedValue + "     " + unCurso.InicioCursos.ToShortDateString() + " - " + unCurso.FinCurso.ToShortDateString() +"     " + DateTime.Now.ToShortDateString());
                prHeader.Alignment = Element.ALIGN_CENTER;
                pdfDoc.Add(prHeader);
                pdfDoc.Add(new Paragraph(" "));
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            Process.Start(folderPath+ @"\ListaActualizada.pdf");
        }
    }
}
