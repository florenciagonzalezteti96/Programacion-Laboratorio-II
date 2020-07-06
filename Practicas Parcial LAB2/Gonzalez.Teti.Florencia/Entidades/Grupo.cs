using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> manada;
        private string nombre;
        static EtipoManada tipo;

        public EtipoManada Tipo
        {
            set
            {
                tipo = value;
            }
        }
        static Grupo()
        {
            tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this.manada = new List<Mascota>();
        }
        public Grupo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {
            this.Tipo = tipo;
        }
        public static bool operator ==(Grupo g, Mascota m)
        {
            bool existeEnGrupo = false;

            foreach (Mascota mascotaEnGrupo in g.manada)
            {
                if (mascotaEnGrupo.Equals(m))
                {
                    existeEnGrupo = true;
                    break;
                }
            }
            return existeEnGrupo;
        }
        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }
        public static Grupo operator +(Grupo g, Mascota m)
        {
            if (!(g == m))
            {
                g.manada.Add(m);
            }
            else
            {
                Console.WriteLine("Ya esta el '{0}' en el grupo\n", m.ToString());
            }
            return g;
        }
        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                foreach (Mascota mascotaEnGrupo in g.manada)
                {
                    if (mascotaEnGrupo == m)
                    {
                        //int auxIndex = g.manada.IndexOf(m);
                        g.manada.Remove(m);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("No esta el '{0}' en el grupo\n", m.ToString());
            }
            return g;
        }
        public static implicit operator string(Grupo g)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Grupo: " + g.nombre + " - tipo: " + tipo);
            sb.AppendFormat("Integrantes ({0})\n", g.manada.Count);
            foreach (Mascota mascotaEnGrupo in g.manada)
            {
                sb.AppendLine(mascotaEnGrupo.ToString());
            }
            return sb.ToString();
        }

    }
}
