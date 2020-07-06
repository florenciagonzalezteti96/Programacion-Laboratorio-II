using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;
        public Moto(float cilindrada, string patente, byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this.cilindrada = cilindrada;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cilindrada: " + this.cilindrada);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
