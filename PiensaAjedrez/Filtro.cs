using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Filtro
    {
        public Filtro()
        {
            Nombre = false;
            Escuela = false;
            Fecha = false;
            Correo = false;
            Activos = false;
            NumeroControl = false;
        }      
        private bool _blnNombre;
        public bool Nombre
        {
            get { return _blnNombre; }
            set { _blnNombre = value; }
        }

        private bool _blnEscuela;
        public bool Escuela
        {
            get { return _blnEscuela; }
            set { _blnEscuela = value; }
        }

        private bool _blnFecha;
        public bool Fecha
        {
            get { return _blnFecha; }
            set { _blnFecha = value; }
        }

        private bool _blnCorreo;
        public bool Correo
        {
            get { return _blnCorreo; }
            set { _blnCorreo = value; }
        }

        private bool _blnActivos;
        public bool Activos
        {
            get { return _blnActivos; }
            set { _blnActivos = value; }
        }

        private bool _blnNumeroControl;
        public bool NumeroControl
        {
            get { return _blnNumeroControl; }
            set { _blnNumeroControl = value; }
        }

        private bool _blnTelefono;

        public bool Telefono
        {
            get { return _blnTelefono; }
            set { _blnTelefono = value; }
        }

        private string _strTelefono;

        public string ValorTelefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }


        private string _strNombre;
        public string ValorNombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strEscuela;
        public string ValorEscuela
        {
            get { return _strEscuela; }
            set { _strEscuela = value; }
        }

        private DateTime _dtmFecha;
        public DateTime ValorFecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
        }

        private string _strCorreo;
        public string ValorCorreo
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }
        
        private string _strNoControl;
        public string ValorNoControl
        {
            get { return _strNoControl; }
            set { _strNoControl = value; }
        }


        public override string ToString()
        {
            bool blnAnteriorExiste = false;
            string strConsulta = "";
            if (Nombre || Escuela || Fecha || Correo || Activos || NumeroControl || Telefono)
            {
                strConsulta += " WHERE ";
                if (Nombre)
                {
                    strConsulta += " Nombre LIKE '%" + ValorNombre + "%' ";
                    strConsulta += "OR ApellidoPaterno LIKE '%" + ValorNombre + "%' ";
                    strConsulta += "OR ApellidoMaterno LIKE '%" + ValorNombre + "%' ";
                    blnAnteriorExiste = true;
                }                    
                if (Escuela)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " NombreEscuela LIKE '%" + ValorEscuela + "%' ";
                    blnAnteriorExiste = true;
                }
                if (Fecha)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " MONTH(FechaNacimiento) = '" + ValorFecha.Month + "' AND YEAR(FechaNacimiento) = '"+ValorFecha.Year+"' ";
                    blnAnteriorExiste = true;
                }
                if (Correo)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " Correo LIKE '%" + ValorCorreo + "%' ";
                    blnAnteriorExiste = true;
                }
                if (Activos)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " Activo = 1 ";
                    blnAnteriorExiste = true;
                }
                if (NumeroControl)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " NumeroControl LIKE '%" + ValorNoControl + "%' ";
                    blnAnteriorExiste = true;
                }
                if (Telefono)
                {
                    if (blnAnteriorExiste)
                        strConsulta += " AND ";
                    strConsulta += " Telefono LIKE '%" + ValorTelefono + "%' ";
                    blnAnteriorExiste = true;
                }
            }
            return strConsulta;
        }

    }
}
