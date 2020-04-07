using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase_04
{
    class Cosa
    {
        int entero;
        string cadena;
        DateTime fecha;
        public Cosa(int entero, string cadena) : this(cadena)
        {
            this.EstablecerValor(entero);
        }
        public Cosa(string cadena) : this()
        {
            this.EstablecerValor(cadena);
        }
        public Cosa()
        {
            this.EstablecerValor(DateTime.Now);
        }

        public void EstablecerValor(int entero)
        {
            this.entero = entero;
        }
        public void EstablecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void EstablecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }
        public void Mostrar()
        {
            Console.WriteLine(this.entero);
            Console.WriteLine(this.cadena);
            Console.WriteLine(this.fecha);
            Console.WriteLine("**************");
        }


    }
}
