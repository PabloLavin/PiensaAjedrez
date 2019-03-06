using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    class Cursos
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


    }
}
