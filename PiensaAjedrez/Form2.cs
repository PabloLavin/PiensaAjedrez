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
        string Escuela="";        
        public Form2()
        {
            InitializeComponent();
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
            

            RellenarDGV(Escuela);
        }

        void RellenarDGV(string strNombreEscuela)
        {
            dgvGastos.Rows.Clear();
            foreach (Gastos unGasto in ConexionBD.CargarGastos())
            {
                dgvGastos.Rows.Add(unGasto.Motivo,"$", unGasto.Monto, unGasto.Nota, unGasto.FechaGasto.ToShortDateString());
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
    }
}
