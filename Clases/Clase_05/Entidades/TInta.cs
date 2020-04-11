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
        private ConsoleColor _color;
        private ElTipoTinta _tipo;
        public Tinta()
        {
            this._color = ConsoleColor.Black;
            this._tipo = ElTipoTinta.Comun;
        }
        public Tinta(ElTipoTinta tipoDeTinta) : this()
        {
            this._tipo = tipoDeTinta;
        }
        public Tinta(ElTipoTinta tipoDeTinta, ConsoleColor color) : this(tipoDeTinta)
        {
            this._color = color;
        }
        private string Mostrar()
        {
            return "El tipo de tinta es: " + this._tipo + " y el color es: " + this._color;
        }
        public static string Mostrar(Tinta unaTinta)
        {
            return unaTinta.Mostrar();
        }
        public static bool operator ==(Tinta t1, Tinta t2)
        {
            bool retorno = false;

            if(t1._color == t2._color && t1._tipo == t2._tipo)
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
