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
            set { _dtFechaNacimiento = value;
                if (_dtFechaNacimiento > DateTime.Parse("01/01/2011")|| _dtFechaNacimiento < DateTime.Parse("31/12/1910")) 
                {
                    throw new Exception("La fecha de nacimiento no es válida.");
                }
            }
        }

        private long _lngTelefono;

        public long Telefono
        {
            get { return _lngTelefono; }
            set { _lngTelefono = value;
                if (_lngTelefono.ToString().Length > 10)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        private string _strCorreo;

        public string Correo
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }



    }
}
