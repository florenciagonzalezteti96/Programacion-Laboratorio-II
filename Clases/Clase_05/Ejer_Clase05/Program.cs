using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Ejer_Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Tinta tinta1 = new Tinta();
            Tinta tinta2 = new Tinta(ElTipoTinta.ConBrillito);
            Tinta tinta3 = new Tinta(ElTipoTinta.China, ConsoleColor.Red);
            Tinta tinta4 = new Tinta(ElTipoTinta.China, ConsoleColor.Red);

            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            if(tinta3==tinta4)
            {
                Console.WriteLine("son iguales1!");
            }
            if (tinta3 != tinta4)
            {
                Console.WriteLine("son disntintos1!");
            }
            if (tinta2 == tinta4)
            {
                Console.WriteLine("son iguales2!");
            }
            if (tinta2 != tinta4)
            {
                Console.WriteLine("son distintos2!");
            }

            Console.ReadKey();

        }
    }
}
