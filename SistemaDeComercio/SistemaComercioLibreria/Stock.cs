using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercioLibreria
{
    public class Stock
    {
        public List<Producto> productos;
        public int cantidadEnStock;

        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }
        public int CantidadTotal
        {
            get
            {
                return this.cantidadEnStock;
            }
            set
            {
                this.cantidadEnStock = value;
            }
        }
        public Stock() 
        {
            this.productos = new List<Producto>();
        }

        public static Stock operator +(Stock s, Producto p)
        {
            bool agregar = false;
            if(s != null && p != null)
            {
                s.Productos.Add(p);
                s.CantidadTotal += p.CantidadEnStock;
                agregar = true;
            }
            if(!agregar)
            {
                MessageBox.Show("Ha ocurrido un error al agregar el nuevo producto.");
            }
            return s;
        }

        /*public string ProductosEnStock()
        {
            string stock = string.Empty;

            foreach (Producto p in this.Productos)
            {
                stock += p.ToString();
            }

            return stock;
        }*/

    }
}
