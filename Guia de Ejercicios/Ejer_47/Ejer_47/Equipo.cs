using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_47
{
    public abstract class Equipo
    {
        protected string nombre;
        protected DateTime fechaCreacion;

        public Equipo(string nombre, DateTime creacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = creacion;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }
        public DateTime FechaCreacion
        {
            get
            {
                return this.fechaCreacion;
            }
        }
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            return (e1.Nombre == e2.Nombre) && (e1.FechaCreacion == e2.FechaCreacion);
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            return this.nombre + " fundado el " + this.FechaCreacion;
        }
    }
}
