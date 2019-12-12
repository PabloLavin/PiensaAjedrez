using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiensaAjedrez
{
   public partial class Form2 : Form
    {
        int intOpcion = 0;

        public Form2(int intCaso)
        {
            InitializeComponent();
            intOpcion = intCaso;
            if (intCaso == 1)
            {
                lblControlGastos.Text = "Control de Gastos | ";
            }
            else
            {
                lblControlGastos.Text = "Control de Ingresos |";
            }
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            dgvGastos.Columns.Add("Razón", "Razón");
            dgvGastos.Columns.Add("$", "$");
            dgvGastos.Columns.Add("Monto", "Monto");
            dgvGastos.Columns.Add("Nota", "Nota");
            dgvGastos.Columns.Add("Fecha", "Fecha");
            dgvGastos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvGastos.Columns[1].Width = 25;
            dgvGastos.Columns[2].Width = 65;
            dgvGastos.Columns[4].Width = 100;
            if (intOpcion == 2)
                dgvGastos.Columns[0].Visible = false;
            

            RellenarDGV();
        }

        void RellenarDGV()
        {
            dgvGastos.Rows.Clear();
            if (intOpcion == 1)
            {
                foreach (Gastos unGasto in ConexionBD.CargarGastos())
                {
                    dgvGastos.Rows.Add(unGasto.Motivo, "$", unGasto.Monto, unGasto.Nota, unGasto.FechaGasto.ToShortDateString());
                }
            }
            else
            {
                foreach (Gastos unGasto in ConexionBD.CargarIngresos())
                {
                    dgvGastos.Rows.Add(unGasto.Motivo, "$", unGasto.Monto, unGasto.Nota, unGasto.FechaGasto.ToShortDateString());
                }
            }
           
        }

        void QuitarLinea()
        {
           dgvGastos.BorderStyle = BorderStyle.None;        
        }

        private void btnVerGastos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void LblControlGastos_Click(object sender, EventArgs e)
        {

        }

        private void DgvGastos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
