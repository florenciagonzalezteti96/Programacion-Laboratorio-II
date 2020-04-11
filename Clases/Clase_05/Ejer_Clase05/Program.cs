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
            Tinta tinta4 = new Tinta(ElTipoTinta.China, ConsoleColor.Blue);

            Console.WriteLine(Tinta.Mostrar(tinta2));
            Console.WriteLine(Tinta.Mostrar(tinta3));

            Pluma p1 = new Pluma(tinta1,0);
            Pluma p2 = new Pluma(5);
            Pluma p3 = new Pluma(tinta3, 2);
            Pluma p4 = new Pluma("Faber", tinta3, 6);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            if(p1 == tinta3)
            {
                Console.WriteLine("Las tintas son iguales!");
            }
            else
            {
                Console.WriteLine("Las tintas son distintas");
            }
            if (p1 != tinta2)
            {
                Console.WriteLine("Las tintas son distintas!");
            }
            else
            {
                Console.WriteLine("Las tintas son iguales");
            }
            if (p3 == tinta3)
            {
                Console.WriteLine("Las tintas son iguales!");
            }
            else
            {
                Console.WriteLine("Las tintas son distintas");
            }


            Console.ReadKey();

        }
    }
}
