using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_027
{
    class Program
    {
        static void Main(string[] args)
        {
            /* CON PILAS */
            ConPilas pila1 = new ConPilas();
            ConPilas pila2 = new ConPilas();
            ConPilas pila3 = new ConPilas();
            ConPilas pila4 = new ConPilas();

            //instancio las pilas de cada objeto
            pila1.DefinirPila();
            pila2.DefinirPila();
            pila3.DefinirPila();
            pila4.DefinirPila();

            //cargo cada pila con cant definida de numeros random
            pila1.CargarNumerosRandom(20);
            pila2.CargarNumerosRandom(10);
            pila3.CargarNumerosRandom(5);
            pila4.CargarNumerosRandom(1);

            //Muestro las pilas
            ConPilas.MostrarPilaRandom(pila1.pilaDeEnteros);
            Console.WriteLine("------------------------------------------------------------");
            ConPilas.MostrarPilaRandom(pila2.pilaDeEnteros);
            Console.WriteLine("------------------------------------------------------------");
            ConPilas.MostrarPilaRandom(pila3.pilaDeEnteros);
            Console.WriteLine("------------------------------------------------------------");
            ConPilas.MostrarPilaRandom(pila4.pilaDeEnteros);
            Console.WriteLine("------------------------------------------------------------");

            //Muestro enteros positivos ordenados desc
            Console.WriteLine("---------------------Muestro positivos desc-----------------------");
            ConPilas.MostrarPilaRandom(ConPilas.CrearPilaDescendente(pila1.pilaDeEnteros));
            Console.WriteLine("------------------------------------------------------------");
            ConPilas.MostrarPilaRandom(ConPilas.CrearPilaDescendente(pila2.pilaDeEnteros));
            Console.WriteLine("------------------------------------------------------------");

            Console.WriteLine("---------------------Muestro negativos asc-----------------------");
            ConPilas.MostrarPilaRandom(ConPilas.CrearPilaAscendente(pila1.pilaDeEnteros));
            Console.WriteLine("------------------------------------------------------------");
            ConPilas.MostrarPilaRandom(ConPilas.CrearPilaAscendente(pila2.pilaDeEnteros));
            Console.WriteLine("------------------------------------------------------------");

            Console.ReadKey();

        }
    }
}
