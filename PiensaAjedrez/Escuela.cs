﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiensaAjedrez
{
    public class Escuela : IEquatable<Escuela>
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
            CursoActivo = null;
        }

        public Escuela(string strNombre, bool blnActualizado, bool blnActivo)
        {
            Nombre = strNombre;
            CursoActivo = null;
            GradoActualizado = blnActualizado;
            Activo = blnActivo;
        }

        public List<Cursos> listaCursos = new List<Cursos>();
        public List<Alumno> listaAlumno = new List<Alumno>();

        private Cursos _CursoActivo;

        public Cursos CursoActivo
        {
            get { return _CursoActivo; }
            set { _CursoActivo = value; }
        }

        private bool _blnGradoACtualizado;

        public bool GradoActualizado
        {
            get { return _blnGradoACtualizado; }
            set { _blnGradoACtualizado = value; }
        }

        private bool _blnActivo;

        public bool Activo
        {
            get { return _blnActivo; }
            set { _blnActivo = value; }
        }



        public bool Equals(Escuela otraEscuela)
        {
            return this.Nombre.Equals(otraEscuela.Nombre);
        }
    }
}

