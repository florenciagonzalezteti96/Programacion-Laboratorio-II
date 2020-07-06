using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;
        public Auto(int cantAsientos, string patente, byte cantRuedas, EMarcas marca) : base(patente, cantRuedas, marca)
        {
            this.cantidadAsientos = cantAsientos;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Cantidad De Asientos: " + this.cantidadAsientos);

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
