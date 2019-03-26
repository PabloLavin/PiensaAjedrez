using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Cursos: IEquatable<Cursos>, IComparable<Cursos>
        
    {
        public List<Alumno> listaAlumnos = new List<Alumno>();
        public List<string> listaActividades = new List<string>();

      
        private DateTime _dtmInicioCursos;

        public DateTime InicioCursos
        {
            get { return _dtmInicioCursos; }
            set { _dtmInicioCursos = value; }
        }

        private DateTime _dtmFinCurso;

        public DateTime FinCurso
        {
            get { return _dtmFinCurso; }
            set { _dtmFinCurso = value;
                if (_dtmFinCurso < _dtmInicioCursos)
                    throw new Exception("Fecha de fin de curso invalida.");     
            }
        }

        private double _dblTotalInscripciones;

        public double TotalInscripcion
        {
            get { return _dblTotalInscripciones; }
            set { _dblTotalInscripciones = value; }
        }

        private double _dbltotalMensualidades;

        public double TotalMensualidad
        {
            get { return _dbltotalMensualidades; }
            set { _dbltotalMensualidades = value; }
        }


        public Cursos(DateTime dtIniciocurso, DateTime dtFinCurso, List<string> actividades)
        {
            _dtmInicioCursos = dtIniciocurso;
            _dtmFinCurso = dtFinCurso;
            Activo = true;
            TotalInscripcion = 0;
            TotalMensualidad = 0;
            foreach (string actividad in actividades)
            {
                listaActividades.Add(actividad);
            }
        }

        private bool _blnActivo;

        public bool Activo
        {
            get { return _blnActivo; }
            set { _blnActivo = value; }
        }


        public Cursos(DateTime dtIniciocurso, DateTime dtFinCurso)
        {
            _dtmInicioCursos = dtIniciocurso;
            _dtmFinCurso = dtFinCurso;
        }

        public bool Equals(Cursos otroCurso)
        {
            return (this.InicioCursos.ToShortDateString().Equals(otroCurso.InicioCursos.ToShortDateString()) 
                && this.FinCurso.ToShortDateString().Equals(otroCurso.FinCurso.ToShortDateString()));
        }

        public int CompareTo(Cursos otroCurso)
        {
            return this.FinCurso.ToShortDateString().CompareTo(otroCurso.FinCurso.ToShortDateString());
        }

    }
}
