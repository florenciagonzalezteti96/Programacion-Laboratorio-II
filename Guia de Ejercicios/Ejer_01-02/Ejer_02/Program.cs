using System;

/**
Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */

namespace Ejer_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int cuadrado = 0;
            int cubo = 0;

            Console.WriteLine("Ingrese un numero para calcular el cuadrado y el cubo del mismo:");

            numero = Int32.Parse(Console.ReadLine());

            while(numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");

                numero = Int32.Parse(Console.ReadLine());
            }

            cuadrado = (int) Math.Pow(numero, 2);
            cubo = (int) Math.Pow(numero, 3);

            Console.WriteLine("El cuadrado del numero es {0} y el cubo es {1}.", cuadrado, cubo);
            Console.ReadLine();
        }
    }
}
