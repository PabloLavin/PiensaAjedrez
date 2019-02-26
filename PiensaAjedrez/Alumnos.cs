using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    class Alumnos
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private string _strEscuela;

        public string Escuela
        {
            get { return _strEscuela; }
            set { _strEscuela = value; }
        }

        private DateTime _dtFechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return _dtFechaNacimiento; }
            set { _dtFechaNacimiento = value; }
        }

        private int _intTelefono;

        public int Telefono
        {
            get { return _intTelefono; }
            set { _intTelefono = value; }
        }

        private string _strCorreo;

        public string Correo
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }



    }
}
