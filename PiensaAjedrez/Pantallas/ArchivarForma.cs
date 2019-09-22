﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PiensaAjedrez.Pantallas
{
    public partial class ArchivarForma : Form
    {
        public ArchivarForma()
        {
            InitializeComponent();
        }

        private void ArchivarForma_Load(object sender, EventArgs e)
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

            RellenarDGV();
        }

        void RellenarDGV()
        {
            dgvGastos.Rows.Clear();
            foreach (Gastos unGasto in ConexionBD.CargarGastos())
            {
                dgvGastos.Rows.Add(unGasto.Motivo, "$", unGasto.Monto, unGasto.Nota, unGasto.FechaGasto.ToShortDateString());
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnArchivar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" || txtNombre.Text != null)
            {
                try
                {
                    List<Gastos> listaGastos = new List<Gastos>();
                    foreach (DataGridViewRow Fila in dgvGastos.Rows)
                    {
                        if (Fila.Selected)
                            listaGastos.Add(new Gastos(Fila.Cells[0].Value.ToString(), double.Parse(Fila.Cells[2].Value.ToString()), Fila.Cells[3].Value.ToString(), DateTime.Parse(Fila.Cells[4].Value.ToString())));
                    }
                    ConexionBD.ArchivarGastos(txtNombre.Text,listaGastos);
                    new FormMensaje().Mostrar("Archivado correctamente", "¡Se archivó con éxito!", 5, new Mensualidades());
                    txtNombre.Clear();
                    RellenarDGV();
                }
                catch (Exception)
                {
                    new FormMensaje().Mostrar("Error", "No se pudo archivar", 1, new Mensualidades());
                }
               
            }
            else
                new FormMensaje().Mostrar("Error", "No deje el nombre vacío", 1, new Mensualidades());
        }
    }
}
