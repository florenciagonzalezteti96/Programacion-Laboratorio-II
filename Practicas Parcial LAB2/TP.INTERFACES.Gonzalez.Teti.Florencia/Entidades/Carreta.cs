using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta : Vehiculo, IARBA
    {
        public Carreta(double precio) : base(precio) { }
        public override double ImpuestoARBA
        {
            get
            {
                return 0.18;
            }
        }
        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio de carreta " + this._precio);
        }
        double IARBA.CalcularImpuesto()
        {
            return this._precio * this.ImpuestoARBA;
        }
    }
}
