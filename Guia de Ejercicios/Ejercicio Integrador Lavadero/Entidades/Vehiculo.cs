using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected string patente;
        protected Byte cantRuedas;
        protected EMarcas marca;
        public enum EMarcas
        {
            Honda,
            Ford,
            Zanella,
            Scania,
            Iveco,
            Fiat
        }
        public string GetPatente
        { 
            get
            {
                return this.patente;
            }             
        }
        public EMarcas GetMarca
        {
            get
            {
                return this.marca;
            }
        }
        public Byte GetCantidadRuedas
        {
            get
            {
                return this.cantRuedas;
            }
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nPatente: " + GetPatente);
            sb.AppendLine("Cantidad de ruedas: " + this.cantRuedas);
            sb.Append("Marca: " + GetMarca);

            return sb.ToString();
        }
        public Vehiculo(string patente, Byte cantRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantRuedas = cantRuedas;
            this.marca = marca;
        }
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool sonIguales = false;
            if((String.Compare(v1.patente,v2.patente)==0) && v1.marca == v2.marca)
            {
                sonIguales = true;
            }
            return sonIguales;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
           return !(v1 == v2);
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Vehiculo)
            {
                retorno = (this == (Vehiculo)obj);
            }
            return retorno;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
