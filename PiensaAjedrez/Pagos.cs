using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Pagos
    {
        private string _strNumeroRecibo;

        public string NumeroRecibo
        {
            get { return _strNumeroRecibo; }
            set { _strNumeroRecibo = value; }
        }

        private string _strNota;

        public string Nota
        {
            get { return _strNota; }
            set { _strNota = value; }
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

        private string _strMesPagado;

        public string MesPagado
        {
            get { return _strMesPagado; }
            set { _strMesPagado = value; }
        }

        public Pagos(string strRecibo, DateTime dtmFechaPago, double dblPago, string strNota, string strMes)
        {
            _strNumeroRecibo = strRecibo;
            _dtFechayHora = dtmFechaPago;
            _dblMonto = dblPago;
            _strNota = strNota;
            _strMesPagado = strMes;
        }

    }
}
