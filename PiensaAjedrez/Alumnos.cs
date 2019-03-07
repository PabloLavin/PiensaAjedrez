using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    class Alumno:IEquatable<Alumno>, IComparable<Alumno>
    {
        private string _strNumeroDeControl;

        public string NumeroDeControl
        {
            get { return _strNumeroDeControl; }
            set { _strNumeroDeControl = value; }
        }


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

        private string _strTelefono;

        public string Telefono
        {
            get { return _strTelefono; }
            set { _strTelefono = value; }
        }

        private string _strCorreo;

        public string Correo
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }

        private bool _blnActivo;

        public bool Activo
        {
            get { return _blnActivo; }
            set { _blnActivo = value; }
        }

        private string _strTutor;

        public string Tutor
        {
            get { return _strTutor; }
            set { _strTutor = value; }
        }


        public bool Equals(Alumno otroAlumno)
        {
            return this.NumeroDeControl.Equals(otroAlumno.NumeroDeControl);
        }

        public int CompareTo(Alumno otroAlumno)
        {
            return int.Parse(this.NumeroDeControl).CompareTo(int.Parse(otroAlumno.NumeroDeControl));
        }
    }
}
