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

        private DateTime _dtmFechaGasto;

        public DateTime FechaGasto
        {
            get { return _dtmFechaGasto; }
            set { _dtmFechaGasto = value; }
        }

        private string _strIDCurso;

        public string IDCurso
        {
            get { return _strIDCurso; }
            set { _strIDCurso = value; }
        }


        public Gastos(string strMotivo, double dblMonto, string strNota, DateTime dtmFecha, string strCurso)
        {
            Motivo = strMotivo;
            Monto = dblMonto;
            Nota = strNota;
            FechaGasto = dtmFecha;
            IDCurso = strCurso;
        }

        public Gastos(string strMotivo, double dblMonto, string strNota)
        {
            Motivo = strMotivo;
            Monto = dblMonto;
            Nota = strNota;
        }
    }
}
