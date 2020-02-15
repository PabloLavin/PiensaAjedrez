using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
   public class Alumno:IEquatable<Alumno>, IComparable<Alumno>
    {
       public List<Pagos> listaPagos = new List<Pagos>();

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

        private string _strApellidoPaterno;

        public string ApellidoPaterno
        {
            get { return _strApellidoPaterno; }
            set { _strApellidoPaterno = value; }
        }

        private string _strApellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _strApellidoMaterno; }
            set { _strApellidoMaterno = value; }
        }

       
        private int _intGrado;

        public int Grado
        {
            get { return _intGrado; }
            set { _intGrado = value; }
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
                if (_dtFechaNacimiento > DateTime.Today|| _dtFechaNacimiento < DateTime.Parse("31/12/1910")) 
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

        private Int16 _int16PorcentajeBeca;

        public Int16 PorcentajeBeca
        {
            get { return _int16PorcentajeBeca; }
            set { _int16PorcentajeBeca = value; }
        }


        public Alumno()
        {

        }

        public Alumno(string strNroControl, string strNombre, string strEscuela, DateTime dtmFechaNacimiento, string strTelefono, string strCorreo, int intActivo, string strTutor, string strApellidoP, string strApellidoM, int intGrado, Int16 intBeca, string strProfesor, string strRango)
        {
            NumeroDeControl = strNroControl;
            Nombre = strNombre;
            Escuela = strEscuela;
            FechaNacimiento = dtmFechaNacimiento;
            Telefono = strTelefono;
            Correo = strCorreo;
            Activo= (intActivo==1) ? true:false;
            Tutor = strTutor;
            ApellidoPaterno = strApellidoP;
            ApellidoMaterno = strApellidoM;
            Grado = intGrado;
            PorcentajeBeca = intBeca;
            Profesor = strProfesor;
            Rango = strRango;
        }

        public Alumno(string strNumeroControl, string strNombre, string strAMaterno, string strAPaterno)
        {
            NumeroDeControl = strNumeroControl;
            Nombre = strNombre;
            ApellidoMaterno = strAMaterno;
            ApellidoPaterno = strAPaterno;
        }

        public Alumno(string strNumeroControl)
        {
            _strNumeroDeControl = strNumeroControl;
        }

        public bool Equals(Alumno otroAlumno)
        {
            return this.NumeroDeControl.Equals(otroAlumno.NumeroDeControl);
        }

        public int CompareTo(Alumno otroAlumno)
        {
            return int.Parse(this.NumeroDeControl).CompareTo(int.Parse(otroAlumno.NumeroDeControl));
        }

        private string _strProfesor;

        public string Profesor
        {
            get { return _strProfesor; }
            set { _strProfesor = value; }
        }

        private string _strRango;

        public string Rango
        {
            get { return _strRango; }
            set { _strRango = value; }
        }

    }
}
