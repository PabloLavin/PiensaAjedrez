using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Deuda
    {
        private string _strMes;

        public string Mes
        {
            get { return _strMes; }
            set { _strMes = value; }
        }

        private double _dblMonto;

        public double Monto
        {
            get { return _dblMonto; }
            set { _dblMonto = value; }
        }

        public Deuda(string strMes, double dblMonto)
        {
            Mes = strMes;
            Monto = dblMonto;
        }
    }
}
