using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo): this(llamada.NroDestino, llamada.Duracion,llamada.NroOrigen, costo) { }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen) 
        {
            this.costo = costo;
        }
        
        public override float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }

        protected override string Mostrar()
        {
            StringBuilder llamadaLocal = new StringBuilder();

            llamadaLocal.Append(base.Mostrar());
            llamadaLocal.AppendLine("COSTO: " + this.CostoLlamada);

            return llamadaLocal.ToString();
        }
    
        private float CalcularCosto()
        {
            return this.costo * this.duracion;
        }

        public override bool Equals(object obj)
        {
            return (obj is Local); 
        }
        public override string ToString()
        {
            return this.Mostrar();
        }


    }
}
