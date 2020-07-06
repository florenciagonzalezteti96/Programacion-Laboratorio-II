using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre, raza) { }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("gato - " + base.DatosCompletos());
           
            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Ficha();
        }
        public static bool operator ==(Gato g1, Gato g2)
        {
            bool sonIguales = false;
            if ((Mascota)g1 == g2)
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;
            if (obj != null && obj is Gato)
            {
                sonIguales = (this == ((Gato)obj));
            }
            return sonIguales;
        }

    }
}
