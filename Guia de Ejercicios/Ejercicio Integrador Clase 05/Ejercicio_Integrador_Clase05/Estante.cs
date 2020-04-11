using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Producto auxProducto in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(auxProducto));
            }

            return sb.ToString();
        }
        public static bool operator ==(Estante e, Producto p)
        {
            /*bool existeElProducto = false;
            foreach (Producto auxProducto in e.productos)
            {
                if(!(auxProducto is null))//si el producto existe
                {
                    if(auxProducto == p)
                    {
                        existeElProducto = true;
                    }
                }
            }
            return existeElProducto;*/

            return e.productos.Contains(p);
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e.productos.Contains(p));
        }
        public static bool operator +(Estante e, Producto p)
        {
            bool sePudoAgregar = false;
            if (e != p)//si el producto no existe en el estante ya
            {
                for (int i = 0; i < e.productos.Length; i++)//recorro el estante
                {
                    if (e.productos[i] is null)//si hay espacio
                    {
                        e.productos[i] = p;
                        sePudoAgregar = true;
                        break;
                    }
                }
            }

            return sePudoAgregar;
        }
        public static Estante operator -(Estante e, Producto p)
        {
            bool sePudoQuitar = false;
            for (int i = 0; i < e.productos.Length; i++)//recorro el estante
            {
                if (e.productos[i] == p)//si existe en el estante
                {
                    e.productos[i] = null;
                    sePudoQuitar = true;
                    break;
                }
            }
            return e;
        }
    }
}
