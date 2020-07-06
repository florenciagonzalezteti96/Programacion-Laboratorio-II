using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lavadero
    {
        private List<Vehiculo> vehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        public enum EVehiculos
        {
            Auto,
            Camion,
            Moto,
        }
        private Lavadero()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioA, float precioC, float precioM) : this()
        {
            this.precioAuto = precioA;
            this.precioCamion = precioC;
            this.precioMoto = precioM;
        }
        public string GetLavadero
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("***** LAVADERO *****");
                sb.AppendLine("Precio de Autos: " + precioAuto);
                sb.AppendLine("Precio de Camion: " + precioCamion);
                sb.AppendLine("Precio de Moto: " + precioMoto);
                sb.AppendLine("----- Vehiculos en Lavadero -----");
                foreach(Vehiculo item in GetVehiculo)
                {
                    sb.Append(item.ToString());
                }
                return sb.ToString();
            }
        }
        public override string ToString()
        {
            return this.GetLavadero;
        }
        public List<Vehiculo> GetVehiculo
        {
            get
            {
                return this.vehiculos;
            }
        }
        public static bool operator ==(Lavadero l1, Vehiculo v1)
        {
            bool existeEnLavadero = false;
            foreach(Vehiculo item in l1.vehiculos)
            {
                if(item == v1)
                {
                    existeEnLavadero = true;
                    break;
                }
            }
            return existeEnLavadero;
        }
        public static bool operator !=(Lavadero l1, Vehiculo v1)
        {
            return !(l1 == v1);
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
            return this.GetHashCode();
        }
        public static Lavadero operator +(Lavadero l1, Vehiculo v1)
        {
            if (!(l1==v1))
            {
                l1.vehiculos.Add(v1);
                Console.WriteLine("Se agrego el vehiculo al lavadero.\n");
            }
            else
            {
                Console.WriteLine("El vehiculo ya existe en el lavadero.\n");
            }
            return l1;
        }
        public static Lavadero operator -(Lavadero l1, Vehiculo v1)
        {
            if (l1 == v1)
            {
                int i = 0;
                foreach(Vehiculo item in l1.vehiculos)
                {
                    if (item == v1)
                    {
                        l1.vehiculos.RemoveAt(i);
                        Console.WriteLine("Se ha eliminado al vehiculo del lavadero.\n");
                        break;
                    }
                    i++;
                }
            }
            else
            {
                Console.WriteLine("El vehiculo no existe en el lavadero.\n");
            }
            return l1;
        }
        public double MostrarTotalFacturado(EVehiculos tipoVehiculo)
        {
            double totalFacturado = 0;
            
            foreach (Vehiculo item in this.vehiculos)
            {
                if(item is Auto && tipoVehiculo == EVehiculos.Auto)
                {
                    totalFacturado += this.precioAuto;
                }
                if (item is Camion && tipoVehiculo == EVehiculos.Camion)
                {
                    totalFacturado += this.precioCamion;
                }
                if (item is Moto && tipoVehiculo == EVehiculos.Moto)
                {
                    totalFacturado += this.precioMoto;
                }
            }
            return totalFacturado;
        }
        public static int OrdenarVehiculosPorPatente(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.GetPatente, v2.GetPatente);
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo v1, Vehiculo v2)
        {
            return String.Compare(v1.GetMarca.ToString(), v2.GetMarca.ToString());
        }
    }
}
