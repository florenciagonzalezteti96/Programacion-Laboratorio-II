using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected double _precio;

        public virtual double ImpuestoAFIP{ get; }

        public virtual double ImpuestoARBA{ get; }

        public abstract void MostrarPrecio();

        public Vehiculo(double precio)
        {
            this._precio = precio;
        }

    }
}
