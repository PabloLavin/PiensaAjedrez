using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Gastos
    {
        private string _strMotivo;

        public string Motivo
        {
            get { return _strMotivo; }
            set { _strMotivo = value; }
        }

        private double _dblMonto;

        public double Monto
        {
            get { return _dblMonto; }
            set { _dblMonto = value; }
        }

        private string _strNota;

        public string Nota
        {
            get { return _strNota; }
            set { _strNota = value; }
        }


        public Gastos(string strMotivo, double dblMonto, string strNota)
        {
            Motivo = strMotivo;
            Monto = dblMonto;
            Nota = strNota;
        }
    }
}
