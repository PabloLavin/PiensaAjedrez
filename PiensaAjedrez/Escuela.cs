﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
     public class Escuela: IEquatable<Escuela>
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        public Escuela(string strNombre)
        {
            Nombre = strNombre;
        }

       public List<Cursos> listaCursos = new List<Cursos>();
       public List<Alumno> listaAlumno = new List<Alumno>();

        public bool Equals(Escuela otraEscuela)
        {
            return this.Nombre.Equals(otraEscuela.Nombre);
        }

    }
}
