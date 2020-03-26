using System;

/**
Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el
valor máximo, el valor mínimo y el promedio.
*/

namespace Ejer_01
{
    class Ejer_00
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int max = 0;
            int min = 0;
            int total = 0;
            float promedio = 0;
            int i;
          

            for(i=0; i<5 ; i++)
            {
                Console.WriteLine("Ingrese el numero: ");
                numeroIngresado = Int32.Parse(Console.ReadLine());

                    if(i == 0 || numeroIngresado > max)
                    {
                        max = numeroIngresado;
                    }
                    if(i == 0 || numeroIngresado < min)
                    {
                        min = numeroIngresado;
                    }

                total = total + numeroIngresado;

            }

            promedio = (float) total / i;

            Console.WriteLine("EL MINIMO ES: {0}, EL MAXIMO ES {1} Y EL PROMEDIO ES {2}", min, max, promedio);
        }
    }
}
