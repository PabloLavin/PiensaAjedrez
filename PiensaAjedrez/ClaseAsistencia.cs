using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
   public class ClaseAsistencia
    {
        private string _strIDCurso;

        public string IDCurso
        {
            get { return _strIDCurso; }
            set { _strIDCurso = value; }
        }

        private DateTime _dtmFecha;

        public DateTime Fecha
        {
            get { return _dtmFecha; }
            set { _dtmFecha = value; }
        }

        public ClaseAsistencia(string Curso, DateTime dtmFecha)
        {
            IDCurso = Curso;
            Fecha = dtmFecha;
        }

    }
}
