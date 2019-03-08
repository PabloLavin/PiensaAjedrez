using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    class Cursos: IEquatable<Cursos>    
    {
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
        public Cursos()
        {

        }

        public Cursos(DateTime dtIniciocurso, DateTime dtFinCurso)
        {
            _dtmInicioCursos = dtIniciocurso;
            _dtmFinCurso = dtFinCurso;
        }

        public bool Equals(Cursos otroCurso)
        {
            return (this.InicioCursos.Equals(otroCurso.InicioCursos) && this.FinCurso.Equals(otroCurso.FinCurso));
        }

    }
}
