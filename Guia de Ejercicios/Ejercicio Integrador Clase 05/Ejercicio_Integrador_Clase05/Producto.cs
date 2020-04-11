using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Marca del producto: " + p.marca);
            sb.AppendLine("Codigo de barra del producto: " + p.codigoDeBarra);
            sb.AppendLine("Precio del producto: " + p.precio);

            return sb.ToString();
        }
        public static explicit operator string(Producto p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(p.codigoDeBarra);

            return sb.ToString();
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;
            if(p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;
            if (p1.marca == marca)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }


    }
}
