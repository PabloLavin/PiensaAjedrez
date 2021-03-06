﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PiensaAjedrez.Pantallas;

namespace PiensaAjedrez
{
    public partial class RegistroAlumnos : UserControl
    {

        public static List<Alumno> listaAlumnos = ConexionBD.CargarAlumnos();
        public FormMensaje unaForma = new FormMensaje();
        public bool blnAceptar;

        string strClave = "0101";
        
        public RegistroAlumnos()
        {
            
            InitializeComponent();

            lblCumple.Text += DateTime.Today.ToString("MMMM");
            txtNombre.Focus();
            btnCancelar.Visible = false;
            txtFiltroAño.MaxLength = 4;
            txtTelefono.MaxLength = 10;
            btnAgregado.Visible = false;
            imgFiltro.Enabled = false;
            dgvAlumnos.Columns.Add("No. Ctrl", "N° de ctrl");
            dgvAlumnos.Columns.Add("Grado", "Grado");
            dgvAlumnos.Columns.Add("Apellido P.", "Apellido P");
            dgvAlumnos.Columns.Add("Apellido M.", "Apellido M");
            dgvAlumnos.Columns.Add("Nombre", "Nombre");
            dgvAlumnos.Columns.Add("Escuela", "Escuela");
            dgvAlumnos.Columns.Add("Fec. nac.", "Fec. nac.");
            dgvAlumnos.Columns.Add("Telefono", "Teléfono");
            dgvAlumnos.Columns.Add("Correo", "Correo");
            dgvAlumnos.Columns.Add("Activo", "Activo");
            dgvAlumnos.Columns.Add("Tutor", "Padre o Tutor");
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvAlumnos.Columns[6].Width = 92;
           
            dgvAlumnos.Columns[0].Width = 74;   //NumeroControl
            dgvAlumnos.Columns[3].Width = 90;  //Materno
            dgvAlumnos.Columns[4].Width = 110;  //Nombre
            dgvAlumnos.Columns[5].Width = 190;  //Escuela
            dgvAlumnos.Columns[1].Width = 54;   //Grado
            dgvAlumnos.Columns[2].Width = 94;  //Paterno
            dgvAlumnos.Columns[7].Width = 92;
            dgvAlumnos.Columns[9].Width = 50;

            int intControlAlumno = 0;
            do
            {
                lblnumerocontrol.Text= ((int.Parse(DateTime.Today.Year.ToString().Substring(2))) + (int.Parse("100000") + (ConexionBD.CargarAlumnos().Count + intControlAlumno)).ToString());
                intControlAlumno++;
            } while (ConexionBD.CargarAlumnos().Contains(new Alumno(lblnumerocontrol.Text)));
            //lblnumerocontrol.Text = ((int.Parse(DateTime.Today.Year.ToString().Substring(2)))+( int.Parse("100000") + (ConexionBD.CargarAlumnos().Count)).ToString());
            cbDia.SelectedIndex = 0;
            cbMes.SelectedIndex = 0;
            btnCancelar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            contextMenuStrip1.Enabled = false;
            tsEliminarAlumno.Visible = false;
            dgvAlumnos.MultiSelect = false;
            foreach (Escuela miEscuela in ConexionBD.CargarEscuelas())
            {
                cbEscuelas.AddItem(miEscuela.Nombre);
                cboFiltroEscuela.AddItem(miEscuela.Nombre);
            }
            if (ConexionBD.CargarEscuelas().Count > 0)
                cbEscuelas.selectedIndex = 0;
            MostrarDatos();

            InicializarAutorellenado();
        }
        
        void InicializarAutorellenado()
        {
            var srcNombre = new AutoCompleteStringCollection();
            var srcApellidoP = new AutoCompleteStringCollection();
            var srcApellidoM = new AutoCompleteStringCollection();
            foreach (Alumno unAlumno in ConexionBD.CargarAlumnos())
            {
                srcNombre.Add(unAlumno.Nombre);
                srcApellidoP.Add(unAlumno.ApellidoPaterno);
                srcApellidoM.Add(unAlumno.ApellidoMaterno);
            }
            txtNombre.AutoCompleteCustomSource = srcNombre;
            txtApellidoP.AutoCompleteCustomSource = srcApellidoP;
            txtApellidoM.AutoCompleteCustomSource = srcApellidoM;

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
                if (txtNombre.Text == "")
                {
                   unaForma.Mostrar("Advertencia", "No ha introducido ningún nombre.", 1, this);
                    return;
                }

                    miAlumno.Nombre = txtNombre.Text;
                    miAlumno.Escuela = cbEscuelas.selectedValue;
                    miAlumno.FechaNacimiento = dtFechaNacimiento.Value;
                    miAlumno.Telefono = txtTelefono.Text;
                    miAlumno.Correo = txtCorreo.Text;
                    miAlumno.Tutor = txtTutor.Text;
                miAlumno.ApellidoPaterno = txtApellidoP.Text;
                miAlumno.ApellidoMaterno = txtApellidoM.Text;
                //if (chkBecado.Checked)
                //    miAlumno.PorcentajeBeca = Int16.Parse(txtPorcentajeBeca.Text);
                //else
                //    miAlumno.PorcentajeBeca = 0;
                if (txtGrado.Text != "")
                    miAlumno.Grado = int.Parse(txtGrado.Text);
                else
                    miAlumno.Grado = 0;
                if (btnAgregar.ButtonText=="Agregar")
                {
                    int intControlAlumno = 0;
                    do
                    {
                        miAlumno.NumeroDeControl = ((int.Parse(DateTime.Today.Year.ToString().Substring(2))) + (int.Parse("100000") + (ConexionBD.CargarAlumnos().Count+intControlAlumno)).ToString());
                        intControlAlumno++;
                    } while (ConexionBD.CargarAlumnos().Contains(miAlumno));
                }
                else
                {
                    btnCancelar.Visible = false;
                    miAlumno.NumeroDeControl = lblnumerocontrol.Text;
                    ConexionBD.EditarAlumno(miAlumno.NumeroDeControl, miAlumno);
                    listaAlumnos.Sort();
                    btnAgregar.ButtonText = "Agregar";
                    btnAgregar.IdleFillColor = Color.FromArgb(59, 202, 192);
                    LimpiarControles();
                    MostrarDatos();
                    unaForma.Mostrar("Éxito", "Alumno editado correctamente", 5, this);
                    return;
                }
                ConexionBD.AgregarAlumno(miAlumno); 
                MostrarDatos();
                LimpiarControles();
                //lblBecado.Visible = false;
                //chkBecado.Checked = false;
                InitializeTimer();
                int intControl = 0;

                do
                {
                    lblnumerocontrol.Text = ((int.Parse(DateTime.Today.Year.ToString().Substring(2))) + (int.Parse("100000") + (ConexionBD.CargarAlumnos().Count + intControl)).ToString());
                    miAlumno.NumeroDeControl = lblnumerocontrol.Text;
                    intControl++;
                } while (ConexionBD.CargarAlumnos().Contains(miAlumno));
                btnAgregar.ButtonText = "Agregar";
                contextMenuStrip1.Enabled = true;
                tsEliminarAlumno.Visible = true;
                unaForma.Mostrar("Éxito", "Alumno añadido correctamente", 5, this);
            }
            catch (Exception)
            {
                unaForma.Mostrar("Error al agregar un alumno", "Compruebe que los datos ingresados sean correctos.", 1, this);
            }
        }

        void MostrarDatos()
        {
            if(chkNombre.Checked || chkEscuela.Checked || chkFechaNacimiento.Checked || chkCorreo.Checked || chkFiltroActivo.Checked)
            {   
                try
                {
                    Filtrar();
                }
                catch (Exception)
                {
                    Recargar();
                }
            }    
            else            
                Recargar();                   
        }

        void Recargar()
        {
            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in ConexionBD.CargarAlumnos())
            {
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Grado, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToShortDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"), miAlumno.Tutor);
            }
        }

        void LimpiarControles()
        {
            foreach (Control c in bnfcarAgregar.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
            txtCorreo.Text = "";
        }
       
        #region Eventos 
        private void txtCorreo_MouseEnter(object sender, EventArgs e)
        {
            //if (txtCorreo.Text == "ejemplo@hotmail.com")
            //{

            //    txtCorreo.Text = "";
            //    txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            //}
        }

        private void txtCorreo_MouseLeave(object sender, EventArgs e)
        {
            //if (txtCorreo.Text == "")
            //{

            //    txtCorreo.Text = "ejemplo@hotmail.com";
            //    txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            //}

        }

        private void txtCorreo_Enter(object sender, EventArgs e)
        {
            //if (txtCorreo.Text == "ejemplo@hotmail.com")
            //{

            //    txtCorreo.Text = "";
            //    txtCorreo.ForeColor = Color.FromArgb(25, 25, 25);
            //}
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            //if (txtCorreo.Text == "")
            //{
            //    txtCorreo.Text = "ejemplo@hotmail.com";
            //    txtCorreo.ForeColor = Color.FromArgb(129, 129, 129);
            //}
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
            {
                txtFiltonombre.Enabled = true;                
                
                txtFiltonombre.Text = "";
            }
            else
            {
                txtFiltonombre.Enabled = false;                
                txtFiltonombre.Text = "Nombre";
                
            }
            Filtrar();

        }

        private void chkEscuela_OnChange(object sender, EventArgs e)
        {
            if (chkEscuela.Checked)
            {
                cboFiltroEscuela.Enabled = true;
                lblFiltroEscuela.Enabled = true;                
                cboFiltroEscuela.NomalColor = Color.FromArgb(59, 202, 192);
            }                
            else
            {
                cboFiltroEscuela.Enabled = false;
                lblFiltroEscuela.Enabled = false;                
                cboFiltroEscuela.ResetText();
            }
            Filtrar();
        }

        private void chkFechaNacimiento_OnChange(object sender, EventArgs e)
        {
            if (chkFechaNacimiento.Checked)
            {
                cbDia.Enabled = true;
                cbMes.Enabled = true;
                txtFiltroAño.Enabled = true;
                txtFiltroAño.Text = "";
                            
            }
            else
            {
                cbDia.Enabled = false;
                cbMes.Enabled = false;
                txtFiltroAño.Enabled = false;                
                txtFiltroAño.Text = "Año";
                cbDia.SelectedIndex = 0;
                cbMes.SelectedIndex = 0;
                          
            }
            Filtrar();
        }

        private void chkTelefono_OnChange(object sender, EventArgs e)
        {
            if (chkTelefono.Checked)
            {
                txtFiltroTelefono.Enabled = true;
                txtFiltroTelefono.Text = "";
               
            }
            else
            {
                txtFiltroTelefono.Enabled = false;                
                txtFiltroTelefono.Text = "Teléfono";
               
            }
            Filtrar();
        }

        private void chkCorreo_OnChange(object sender, EventArgs e)
        {
            if (chkCorreo.Checked)
            {
                txtFiltroCorreo.Enabled = true;
                
                txtFiltroCorreo.Text = "";
            }
            else
            {
                txtFiltroCorreo.Enabled = false;                
                txtFiltroCorreo.Text = "Correo";
               
            }
            Filtrar();
        }
        #endregion

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            contextMenuStrip1.Enabled = true;
            tsEliminarAlumno.Visible = true;
            foreach (Alumno alumnos in ConexionBD.CargarAlumnos())
            {
                if (alumnos.NumeroDeControl == dgvAlumnos.CurrentRow.Cells[0].Value.ToString())
                {
                    txtNombre.Text = alumnos.Nombre;
                    cbEscuelas.Text = alumnos.Escuela;
                    txtCorreo.Text = alumnos.Correo;
                    txtTelefono.Text = alumnos.Telefono;
                    dtFechaNacimiento.Value = alumnos.FechaNacimiento;
                    txtTutor.Text = alumnos.Tutor;
                    txtApellidoP.Text = alumnos.ApellidoPaterno;
                    txtApellidoM.Text = alumnos.ApellidoMaterno;
                    txtGrado.Text = Convert.ToString(alumnos.Grado);
                    cbEscuelas.selectedIndex = ObtenerIndex(alumnos.Escuela);
                    if (alumnos.Activo)
                    {
                        chkActivo.Checked = true;
                    }
                    else
                    {
                        chkActivo.Checked = false;
                    }
                    //if (alumnos.PorcentajeBeca > 0)
                    //{
                    //    chkBecado.Checked = true;
                    //    lblPorcentaje.Visible = true;
                    //    lblPorcientoSimbolo.Visible = true;
                    //    txtPorcentajeBeca.Visible = true;
                    //    txtPorcentajeBeca.Text = alumnos.PorcentajeBeca.ToString();
                    //}
                    //else
                    //{
                    //    chkBecado.Checked = false;
                    //    lblPorcentaje.Visible = false;
                    //    txtPorcentajeBeca.Visible = false;
                    //    txtPorcentajeBeca.Text = "";
                    //    lblPorcientoSimbolo.Visible = false;
                    //}
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
            }
            else
            {

                counter += 1;

            }
        }

        private void txtFiltonombre_OnValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void cboFiltroEscuela_OnItemSelected(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtFiltroTelefono_OnValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtFiltroCorreo_OnValueChanged(object sender, EventArgs e)
        {
            Filtrar();
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
            Filtrar();
        }

        private void cbMes_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        

        private void cancelarTT_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
            btnAgregar.ButtonText = "Agregar";
            btnAgregar.IdleFillColor = Color.FromArgb(59, 202, 192);
            int intControlAlumno = 0;
            do
            {
                lblnumerocontrol.Text = ((int.Parse(DateTime.Today.Year.ToString().Substring(2))) + (int.Parse("100000") + (ConexionBD.CargarAlumnos().Count + intControlAlumno)).ToString());
                intControlAlumno++;
            } while (ConexionBD.CargarAlumnos().Contains(new Alumno(lblnumerocontrol.Text)));
            //lblnumerocontrol.Text = ((int.Parse(DateTime.Today.Year.ToString().Substring(2))) + (int.Parse("100000") + (ConexionBD.CargarAlumnos().Count)).ToString());
            btnCancelar.Visible = false;
            dgvAlumnos.Focus();
        }
            
        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            LimpiarControles();
        }

       

        private void dgvAlumnos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvAlumnos.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un alumno de la lista.");
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Enabled = true;
                contextMenuStrip1.Visible = true;
                tsEliminarAlumno.Visible = true;
              

                var pos = ((DataGridView)sender).GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                pos.X += e.X;
                pos.Y += e.Y;
                contextMenuStrip1.Show((DataGridView)sender, pos);
                if(e.RowIndex!= -1)
                {
                dgvAlumnos.CurrentCell = dgvAlumnos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                dgvAlumnos.Rows[e.RowIndex].Selected = true;
                dgvAlumnos.Focus();

                }
            }
        }

        ClaveSeguridad pantalla;
        bool Preguntar()
        {
            pantalla = new ClaveSeguridad();
            pantalla.ShowDialog();
            return pantalla.blnOpcion;
        }

        private void tsEliminarAlumno_Click(object sender, EventArgs e)
        {
            if (Preguntar())
            {
                if (Preguntar("Eliminar alumno", "¿Desea eliminar al alumno " + dgvAlumnos.CurrentRow.Cells[0].Value.ToString() + "?"))
                {
                    try
                    {
                        ConexionBD.EliminarAlumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString());
                        //foreach (Escuela miEscuela in Escuelas.listaEscuela)
                        //    if (miEscuela.Equals(new Escuela(dgvAlumnos.CurrentRow.Cells[2].Value.ToString())))
                        //        miEscuela.listaAlumno.Remove(new Alumno(dgvAlumnos.CurrentRow.Cells[0].Value.ToString()));
                        unaForma.Mostrar("Eliminado con éxito", "Se ha eliminado al alumno " + dgvAlumnos.CurrentRow.Cells[0].Value.ToString() + " con éxito.", 5, this);
                    }
                    catch (Exception)
                    {
                        unaForma.Mostrar("Error al eliminar un alumno", "Probablemente este alumno realizó un pago y por ende no puede ser eliminado.", 1, this);
                    }
                }
                MostrarDatos();
                LimpiarControles();
                if (btnAgregar.ButtonText == "Editar")
                {
                    btnAgregar.ButtonText = "Agregar";
                    btnCancelar.Visible = false;
                }

            }
            else
            {
                new FormMensaje().Mostrar("Permiso insuficiente.", "Necesita la clave para continuar la operación.", 1, this);
                return;
            }
        }

        bool Preguntar(string strEncabezado, string strMensaje)
        {
            blnAceptar = false;
            unaForma.Mostrar(strEncabezado, strMensaje, 3, this);
            blnAceptar = unaForma.Aceptar();
            return blnAceptar;
        }


        private void chkFiltroActivo_OnChange(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void txtFiltroAño_OnValueChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        #region Filtrar        
        private void Filtrar()
        {
            Filtro unFiltro = new Filtro();
            unFiltro.Activos = chkFiltroActivo.Checked; 
            unFiltro.Correo = chkCorreo.Checked;
            unFiltro.Telefono = chkTelefono.Checked;
            unFiltro.Escuela = chkEscuela.Checked;
            unFiltro.Fecha = chkFechaNacimiento.Checked;
            unFiltro.Nombre = chkNombre.Checked;
            unFiltro.ValorCorreo = txtFiltroCorreo.Text;            
            if (cboFiltroEscuela.selectedIndex >= 0)            
                unFiltro.ValorEscuela = cboFiltroEscuela.selectedValue;
            try
            {
                unFiltro.ValorFecha = new DateTime(int.Parse(txtFiltroAño.Text), int.Parse(cbMes.Text), int.Parse(cbDia.Text));
            }
            catch (Exception)
            {
                unFiltro.ValorFecha = DateTime.Now;   
            }

            unFiltro.ValorTelefono = txtFiltroTelefono.Text;
            unFiltro.ValorNombre = txtFiltonombre.Text;

            dgvAlumnos.Rows.Clear();
            foreach (Alumno miAlumno in ConexionBD.CargarAlumnosFiltrados(unFiltro))
            {
                dgvAlumnos.Rows.Add(miAlumno.NumeroDeControl, miAlumno.Grado, miAlumno.ApellidoPaterno, miAlumno.ApellidoMaterno, miAlumno.Nombre, miAlumno.Escuela, miAlumno.FechaNacimiento.ToShortDateString(), miAlumno.Telefono, miAlumno.Correo, ((miAlumno.Activo) ? "Si" : "No"), miAlumno.Tutor);
            }

        }
        #endregion

        int ObtenerIndex(string strEscuela)
        {
            Escuela[] arreglo = new Escuela[Escuelas.listaEscuela.Count];
            Escuelas.listaEscuela.CopyTo(arreglo);
            for (int i = 0; i < arreglo.Length; i++)
            {
                if (strEscuela.Equals(arreglo[i].Nombre))
                    return i;
            }
            return -1;
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filtrar();
        }
        #region EventosTeclas
        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnAgregar_Click(sender, e);
            }
        }

        private void CheckSpace(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                chkActivo_Click(sender, e);
            }
        }

        private void chkActivo_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void chkActivo_OnChange(object sender, EventArgs e)
        {
        }

        private void txtCorreo_MouseHover(object sender, EventArgs e)
        {
            //if (txtCorreo.Text == "ejemplo@hotmail.com")
            //    txtCorreo.Text = "";
            //else
            //    txtCorreo.Text ="ejemplo@hotmail.com";
        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtFiltonombre_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltroAño_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltroTelefono_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void TxtFiltroCorreo_TextChanged(object sender, EventArgs e)
        {
            Filtrar();
        }

        private void ChkBecado_OnChange(object sender, EventArgs e)
        {

        }

        private void BtnCumple_Click(object sender, EventArgs e)
        {
            new Cumpleaños().ShowDialog();
        }

        //private void ChkBecado_OnChange(object sender, EventArgs e)
        //{
        //    if (chkBecado.Checked)
        //    {
        //        lblPorcentaje.Visible = true;
        //        txtPorcentajeBeca.Visible = true;
        //    }
        //    else
        //    {
        //        lblPorcentaje.Visible = false;
        //        txtPorcentajeBeca.Visible = false;
        //    }

        //}
    }
}



