using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino) { }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen) 
        {
            this.franjaHoraria = miFranja;
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
            StringBuilder llamadaProvincial = new StringBuilder();

            llamadaProvincial.Append(base.Mostrar());
            llamadaProvincial.Append("COSTO: " + this.CostoLlamada);
            llamadaProvincial.AppendLine("FRANJA HORARIA: " + this.franjaHoraria);

            return llamadaProvincial.ToString();
        }
        private float CalcularCosto()
        {
            float costo = 0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.duracion * (float) 0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.duracion * (float)0.66;
                    break;
            }
            return costo;
        }
        public override bool Equals(object obj)
        {
            bool sonIguales = false;

            if (obj is Provincial)
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
