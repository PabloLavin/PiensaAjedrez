using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    class Pagos
    {
        private string _strNumeroRecibo;

        public string NumeroRecibo
        {
            get { return _strNumeroRecibo; }
            set { _strNumeroRecibo = value; }
        }

        private DateTime _dtFechayHora;

        public DateTime FechayHora

        {
            get { return _dtFechayHora; }
            set { _dtFechayHora = value; }
        }
        private double _dblMonto;

        public double Monto
        {
            get { return _dblMonto; }
            set { _dblMonto = value; }
        }


    }
}
