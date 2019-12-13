using System;
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
    public partial class ClaveSeguridad : Form
    {
        public ClaveSeguridad()
        {
            InitializeComponent();
        }
        public bool blnOpcion=false;
        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text=="0101")
            {
                blnOpcion = true;
                this.Close();
            }
            else
            {
                new FormMensaje().Mostrar("Error", "La clave introducida es incorrecta.", 1, new Mensualidades());
                return;
            }
        }

        private void BtnDeclinar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
