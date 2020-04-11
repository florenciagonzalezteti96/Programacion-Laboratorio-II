using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pluma
    {
        private string _pluma;
        private Tinta _tinta;
        private int _cantidad;
        public Pluma()
        {
            this._pluma = "Sin Marca";
            this._tinta = null;
            this._cantidad = 1;
        }
        public Pluma(int cantidad): this()
        {
            this._cantidad = cantidad;
        }
        public Pluma(Tinta tinta, int cantidad): this(cantidad)
        {
            this._tinta = tinta;
            //this._cantidad = cantidad;
        }
        public Pluma(string pluma, Tinta tinta, int cantidad): this(tinta, cantidad)
        {
            this._pluma = pluma;
            //this._tinta = tinta;
            //this._cantidad = cantidad;
        }
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Pluma: " + this._pluma);
            if(this._tinta is null)
            {
                sb.AppendLine("Tinta: Datos no Ingresados");
            }
            else
            {
                sb.AppendLine(Tinta.Mostrar(this._tinta));
            }
            sb.AppendLine("Cantidad: "+ this._cantidad);

            return sb.ToString();
        }
        public static bool operator ==(Pluma p1, Tinta t1)
        {
            bool sonIguales = false;
            if(p1._tinta == t1)
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Pluma p1, Tinta t1)
        {
            return !(p1 == t1);
        }
        public static Pluma operator +(Pluma p1, Tinta t1)
        {
            if(p1 == t1)
            {
                p1._cantidad++;
            }
            return p1;
        }
        public static Pluma operator -(Pluma p1, Tinta t1)
        {
            if (p1 == t1)
            {
                p1._cantidad--;
            }
            return p1;
        }
        public static implicit operator string(Pluma p1)
        {
            return p1.Mostrar();
        }
    }
}
