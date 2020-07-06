using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        protected string _apellido;
        protected int _dni;
        protected string _fotoAlumno;
        protected string _nombre;

        public string Apellido
        {
            get
            {
                return this._apellido;
            }
            set
            {
                this._apellido = value;
            }
        }
        public int DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                this._dni = value;
            }
        }
        public string FotoAlumno
        {
            get
            {
                return this._fotoAlumno;
            }
            set
            {
                this._fotoAlumno = value;
            }
        }
        public string Nombre
        {
            get
            {
                return this._nombre;
            }
            set
            {
                this._nombre = value;
            }
        }

        public Alumno(string nombre, string apellido, int dni, string ruta)
        {
            this._apellido = apellido;
            this.Nombre = nombre;
            this.DNI = dni;
            this.FotoAlumno = ruta;
        }

    }
}
