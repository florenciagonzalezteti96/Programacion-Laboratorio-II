using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;

namespace Ejer_017
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul;
            Boligrafo boligrafoRojo;
            string tintaUsada;
            bool banderaSePinto = false;

            boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine("El color del boligrafo es " + boligrafoAzul.GetColor());
            Console.WriteLine("La cantidad de tinta del boligrafo es " + boligrafoAzul.GetTinta());

            Console.WriteLine("El nivel de tinta anterior era de: {0}.", boligrafoRojo.GetTinta());

            banderaSePinto = boligrafoRojo.Pintar(-20, out tintaUsada);

            if (banderaSePinto)
            {
                Console.WriteLine("El nivel de tinta actual de: {0}.\nSe uso {1} de tinta", boligrafoRojo.GetTinta(), tintaUsada);
            }

            boligrafoRojo.Recargar();
            Console.WriteLine(boligrafoRojo.GetTinta());

            Console.ReadKey();

        }
    }
}
