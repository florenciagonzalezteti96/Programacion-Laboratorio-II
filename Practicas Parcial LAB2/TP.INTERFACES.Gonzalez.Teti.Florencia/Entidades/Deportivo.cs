using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;

        public Deportivo(double precio, string patente, int hp) : base(precio, patente)
        {
            this._caballosFuerza = hp;
        }

        public override double ImpuestoAFIP
        {
            get
            {
                return 0.28;
            }

        }

        public override double ImpuestoARBA
        {
            get
            {
                return 0.23;
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
    }
}
