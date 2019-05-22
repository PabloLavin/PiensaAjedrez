using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Pagos:IEquatable<Pagos>
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

        private string _strMetodoPago;

        public string MetodoPago
        {
            get { return _strMetodoPago; }
            set { _strMetodoPago = value; }
        }


        private string _strMesPagado;

        public string MesPagado
        {
            get { return _strMesPagado; }
            set { _strMesPagado = value; }
        }

        private bool _blnNotificado;

        public bool Notificado
        {
            get { return _blnNotificado; }
            set { _blnNotificado = value; }
        }

        private bool _blnLiquidado;

        public bool Liquidado
        {
            get { return _blnLiquidado; }
            set { _blnLiquidado = value; }
        }

        private string _strIDCurso;

        public string IDCurso
        {
            get { return _strIDCurso; }
            set { _strIDCurso = value; }
        }

        private bool _blnBeca;

        public bool Beca
        {
            get { return _blnBeca; }
            set { _blnBeca = value; }
        }

        private double _dblMontoBeca;

        public double MontoBeca
        {
            get { return _dblMontoBeca; }
            set { _dblMontoBeca = value; }
        }

        double TotalBeca(double intPorcentaje)
        {

            return Monto * (intPorcentaje / 100);
        }


        public Pagos(string strClave)
        {
            NumeroRecibo = strClave;
        }

        public bool Equals(Pagos otroPago)
        {
            return this.NumeroRecibo.Equals(otroPago.NumeroRecibo);
        }

        public Pagos(string strRecibo, DateTime dtmFechaPago, double dblPago, string strNota, string strMes, string strMetodo, bool notificado, bool blnliquidado, string strCurso, bool blnBecado, Int16 intBeca)
        {
            _strNumeroRecibo = strRecibo;
            _dtFechayHora = dtmFechaPago;
            _dblMonto = dblPago;
            _strNota = strNota;
            _strMesPagado = strMes;
            MetodoPago = strMetodo;
            Notificado = notificado;
            Liquidado = blnliquidado;
            IDCurso = strCurso;
            Beca = blnBecado;
            MontoBeca = TotalBeca(intBeca);
        }

        public Pagos(string strRecibo, DateTime dtmFechaPago, double dblPago, string strNota, string strMes, string strMetodo, bool notificado, bool blnliquidado, string strCurso, bool blnBecado, double dblTotalBeca)
        {
            _strNumeroRecibo = strRecibo;
            _dtFechayHora = dtmFechaPago;
            _dblMonto = dblPago;
            _strNota = strNota;
            _strMesPagado = strMes;
            MetodoPago = strMetodo;
            Notificado = notificado;
            Liquidado = blnliquidado;
            IDCurso = strCurso;
            Beca = blnBecado;
            MontoBeca = dblTotalBeca;
        }

        public override string ToString()
        {
            return ("Numero de recibo: "+NumeroRecibo+"\nMonto: "+Monto.ToString("C")+"\nMétodo de pago: "+MetodoPago+"\nFecha: "+FechayHora.ToShortDateString()+"\nNota: "+Nota+(this.MontoBeca>0?"\nDescuento de la beca: "+MontoBeca.ToString("C"):""));
        }

    }
}
