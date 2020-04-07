using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa cosa1 = new Cosa(2, "cosa1");
            Cosa cosa2 = new Cosa(50, "cosa2");
            Cosa cosa3 = new Cosa(20, "cosa3");

            cosa1.Mostrar();
            cosa2.Mostrar();
            cosa3.Mostrar();

            Console.ReadKey();

        }
    }
}
