using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_47
{
    public class Torneo<T> where T : Equipo
    {
        private string nombre;
        private List<T> equipos;

        private Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(string nombre): this()
        {
            this.nombre = nombre;
        }
        public static bool operator ==(Torneo<T> unTorneo, T equipo)
        {
            bool yaExiste = false;
            foreach (T equipoEnLista in unTorneo.equipos)
            {
                if(equipoEnLista == equipo)
                {
                    yaExiste = true;
                    break;
                }
            }
            return yaExiste;
        }
        public static bool operator !=(Torneo<T> unTorneo, T equipo)
        {
            return !(unTorneo == equipo);
        }
        public static Torneo<T> operator +(Torneo<T> unTorneo, T equipo)
        {
            if(!(unTorneo == equipo))
            {
                unTorneo.equipos.Add(equipo);
            }
            else
            {
                Console.WriteLine("El equipo ya existe en el torneo.");
            }
            return unTorneo;
        }
        public string Mostrar()
        {
            StringBuilder torneo = new StringBuilder();
            torneo.AppendLine("TORNEO " + this.nombre);
            torneo.AppendLine("LISTA DE EQUIPOS: ");
            foreach(T equipo in this.equipos)
            {
                torneo.AppendLine(equipo.Ficha());
            }
            return torneo.ToString();
        }
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random resultado = new Random();
            return equipo1.Nombre + resultado.Next(0, 5) + "---" + resultado.Next(0, 5) + equipo2.Nombre;
        }
        public string JugarPartido
        {
            get
            {
                Random partido = new Random();
                return CalcularPartido(this.equipos[partido.Next(0, this.equipos.Count)], this.equipos[partido.Next(0, this.equipos.Count)]);
            }
        }
    }
}
