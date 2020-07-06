using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public abstract float CostoLlamada { get; }
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        protected virtual string Mostrar()
        {
            StringBuilder llamada = new StringBuilder();

            llamada.AppendLine("DURACION: " + this.Duracion);
            llamada.AppendLine("NUMERO DE ORIGEN: " + this.NroOrigen);
            llamada.AppendLine("NUMERO DE DESTINO: " + this.NroDestino);

            return llamada.ToString();
        }
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno = 0;

            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = -1;
            }

            return retorno;
        }
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            bool sonIguales = false;

            if ((l1.Equals(l2)) && (String.Compare(l1.NroOrigen, l2.NroOrigen) == 0) && (String.Compare(l1.NroDestino, l2.NroDestino) == 0))
            {
                sonIguales = true;
            }

            return sonIguales;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
