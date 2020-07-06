using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion : Vehiculo, IAFIP, IARBA
    {
        protected double _velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this._velocidadMaxima = velMax;
        }

        public override double ImpuestoAFIP
        {
            get
            {
                return 0.33;
            }
        }

        public override double ImpuestoARBA
        {
            get
            {
                return 0.27;
            }

        }

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * this.ImpuestoAFIP;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * this.ImpuestoARBA;
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio de avion " + this._precio);
        }

    }
}
