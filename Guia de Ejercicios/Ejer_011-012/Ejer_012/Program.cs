using System;

namespace Ejer_012
{
    class Ejer_012
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            char continuar = ' ';
            bool validacionContinuar = true;

            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese numero para sumar:");
                numero = Convert.ToInt32(Console.ReadLine());
                acumulador = acumulador + numero;

                Console.WriteLine("¿Continuar? (S/N)");
                continuar = Console.ReadKey().KeyChar;
                continuar = Char.ToUpper(continuar);

                validacionContinuar = ValidarRespuesta.ValidaS_N(continuar);
                Console.ReadKey();

            } while (validacionContinuar != false);

            Console.Clear();

            Console.WriteLine("La suma total de numeros es de: " + acumulador);

            Console.ReadKey();
        }
    }
}
