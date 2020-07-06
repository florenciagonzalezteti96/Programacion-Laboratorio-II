using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa): this()
        {
            this.razonSocial = nombreEmpresa;
        }
        public float GananciasPorLocal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }
        public float GananciasPorProvincial
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }
        public float GananciasPorTotal
        {
            get
            {
                return this.CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }
        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        private string Mostrar()
        {
            StringBuilder centralita = new StringBuilder();
            centralita.AppendLine("                    CENTRALITA                   ");
            centralita.AppendLine("RAZON SOCIAL: "+ this.razonSocial);
            centralita.AppendLine("GANANCIAS TOTALES: " + this.GananciasPorTotal);
            centralita.AppendLine("GANANCIAS LOCALES: " + this.GananciasPorLocal);
            centralita.AppendLine("GANANCIAS PROVINCIALES: " + this.GananciasPorProvincial);
            centralita.AppendLine("--------------------LISTA DE LLAMADAS--------------------");
            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                centralita.AppendLine(llamada.ToString());
            }

            return centralita.ToString();
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float totalRecaudado = 0;

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                if (llamada is Local && tipo == Llamada.TipoLlamada.Local)
                {
                    totalRecaudado += ((Local)llamada).CostoLlamada;
                }
                else if (llamada is Provincial && tipo == Llamada.TipoLlamada.Provincial)
                {
                    totalRecaudado += ((Provincial)llamada).CostoLlamada;
                }
                else if(tipo == Llamada.TipoLlamada.Todas)
                {
                    if(llamada is Local)
                    {
                        totalRecaudado += ((Local)llamada).CostoLlamada;
                    }
                    if(llamada is Provincial)
                    {
                        totalRecaudado += ((Provincial)llamada).CostoLlamada;
                    }
                }
            }
            return totalRecaudado;
        }
        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            if(nuevaLlamada != null)
            {
                this.listaDeLlamadas.Add(nuevaLlamada);
            }
        }
        public static bool operator ==(Centralita c, Llamada llamada)
        {
            bool yaExiste = false;
            
            foreach(Llamada llamadaEnCentralita in c.listaDeLlamadas)
            {
                if(llamadaEnCentralita == llamada)
                {
                    yaExiste = true;
                    break;
                }
            }

            return yaExiste;
        }
        public static bool operator!=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            //try
            //{
                if (!(c == nuevaLlamada))
                {
                    c.AgregarLlamada(nuevaLlamada);
                }
                else
                {
                    throw new CentralitaException("La llamada ya existe en la centralita!", "Centralita", "Sobrecarga de operador +");
                }
            //}
           /* catch(CentralitaException ex)
            {
                CentralitaException exCentralita = new CentralitaException(ex.Message, ex.NombreClase, ex.NombreMetodo, ex);
                if (exCentralita.InnerException != null)
                {
                    Console.WriteLine(exCentralita.InnerException.Message);
                }
                Console.WriteLine("Nombre de la clase origen del error: " + exCentralita.NombreClase);
                Console.WriteLine("Nombre del metodo origen del error: " + exCentralita.NombreMetodo);
            }*/
            return c;
        }
    }
}