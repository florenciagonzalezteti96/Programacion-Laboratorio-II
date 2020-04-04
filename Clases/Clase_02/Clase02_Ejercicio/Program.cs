using System;

namespace Clase02_Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "easdsadasd";

            Console.WriteLine(Sello.Imprimir());

            Sello.Borrar();

            Console.WriteLine(Sello.Imprimir());

            Sello.mensaje = "nuevo mensaje";

            Sello.color = ConsoleColor.Red;

            Sello.ImprimirEnColor();

            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();
        }
    }
}
