using System;
/**
 Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
*/

namespace Ejer_04
{
    class Ejer_04
    {
        static void Main(string[] args)
        {
            int contadorNumerosPerfectos = 0;
            int acumuladorDeDivisores = 0;
            int i = 1; //Numero actual
            int j; //Representa todos los numeros

            Console.WriteLine("Los primeros 4 numeros perfectos son: ");

            while (contadorNumerosPerfectos != 4)
            {
                acumuladorDeDivisores = 0; //Este hay que resetearlo para cada numero evaluado
                for (j = 1; j < i; j++) //Recorro los numeros a partir del 1 hasta mi numero actual
                {
                    if (i % j == 0) //Aca te fijas si es divisor, entonces se suman
                    {
                        acumuladorDeDivisores += j;
                    }
                }
                if (acumuladorDeDivisores == i) //Aca mostrar al numero perfecto
                {
                    contadorNumerosPerfectos++;
                    Console.Write(i + " ");
                }
                i++; //Aca cambio al numero siguiente
            }

            Console.ReadKey(true);
        }
    }
}
