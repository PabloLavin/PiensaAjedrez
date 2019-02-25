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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Cerrar_MouseEnter(object sender, EventArgs e)
        {
            Cerrar.ForeColor = Color.Red;
        }

        private void Cerrar_MouseLeave(object sender, EventArgs e)
        {
            Cerrar.ForeColor = Color.Black;
        }
    }
}
