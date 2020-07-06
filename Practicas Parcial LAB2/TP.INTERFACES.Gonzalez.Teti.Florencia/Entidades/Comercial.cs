using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercial : Avion
    {
        protected int _capacidadPasajeros;

        public Comercial(double precio, double velocidad, int pasajeros) : base(precio, velocidad)
        {
            this._capacidadPasajeros = pasajeros;
        }

        public override double ImpuestoARBA
        {
            get
            {
                return 0.25;
            }
        }


    }
}
