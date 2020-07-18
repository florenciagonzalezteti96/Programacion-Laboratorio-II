using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibreria
{
    public class Producto
    {
        public string nombre;
        public double precioVenta;
        public double costo;
        public int cantidad;

        public string NombreProducto
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public double PrecioDeVenta
        {
            get
            {
                return this.precioVenta;
            }
            set
            {
                this.precioVenta = value;
            }
        }

        public double CostoDeProducto
        {
            get
            {
                return this.costo;
            }
            set
            {
                this.costo = value;
            }
        }

        public int CantidadEnStock
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }

        public Producto() { }

        public Producto(string nombre, double precio, double costo, int cantidad)
        {
            this.nombre = nombre;
            this.precioVenta = precio;
            this.costo = costo;
            this.cantidad = cantidad;
        }

        public override string ToString()
        {
            string producto = string.Empty;

            producto += "Nombre del producto: " + this.nombre;
            producto += "\nPrecio de Venta: " + this.precioVenta;
            producto += "\nCosto del producto: " + this.costo;
            producto += "\nCantidad en Stock: " + this.cantidad;
            producto += "\n----------------------------------------\n";

            return producto;
        }

    }
}
