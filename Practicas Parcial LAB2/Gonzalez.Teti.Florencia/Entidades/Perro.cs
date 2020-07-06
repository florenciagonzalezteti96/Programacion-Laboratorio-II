using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;
        public Perro(string nombre, string raza) : this(nombre, raza, 0, false) { }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            if(this.esAlfa)
            {
                sb.Append("perro - " + base.DatosCompletos() + ", alfa de la manada, edad " + this.edad);
            }
            else
            {
                sb.Append("perro - " + base.DatosCompletos() + ", edad " + this.edad);
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public static bool operator ==(Perro p1, Perro p2)
        {
            bool sonIguales = false;
            if ((((Mascota)p1)==p2) && (p1.edad == p2.edad))
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }
        public static implicit operator int(Perro p)
        {
            return p.edad;
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if(obj != null && obj is Perro)
            {
                sonIguales = (this == ((Perro)obj));
            }
            return sonIguales;
        }

    }
}
