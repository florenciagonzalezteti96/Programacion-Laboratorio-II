using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{/// <summary>
/// tiene clases y otros elementos que se pueden usar desde otros elementos pero no desde el mismo proyecto Entidades
/// </summary>
    public class Tinta
    {
        private ConsoleColor color;
        private ElTipoTinta tipo;

        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ElTipoTinta.Comun;
        }

        public Tinta(ElTipoTinta tipoDeTinta) : this()
        {
            this.tipo = tipoDeTinta;
        }
        public Tinta(ElTipoTinta tipoDeTinta, ConsoleColor color) : this(tipoDeTinta)
        {
            this.color = color;
        }

        private string Mostrar()
        {
            return "El tipo de tinta es: " + this.tipo + " y el color es: " + this.color;
        }

        public static string Mostrar(Tinta unaTinta)
        {
            return unaTinta.Mostrar();
        }

        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool retorno = false;

            if(t1.color == t2.color && t1.tipo == t2.tipo)
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Tinta t1, Tinta t2)
        {
            return !(t1 == t2);
        }
    }
}
