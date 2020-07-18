using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibreria
{
    public class Venta
    {
        Producto productoVendido;
        Cliente comprador;
        double totalDeVenta;
        
        public Venta() { }

        public Venta(Producto p, Cliente c)
        {
            this.productoVendido = p;
            this.comprador = c;
        }
        
        
    }
}
