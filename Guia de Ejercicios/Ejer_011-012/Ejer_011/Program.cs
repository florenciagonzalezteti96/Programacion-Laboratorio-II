using System;

namespace Ejer_011
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int i=0;
            int max = 0;
            int min = 0;
            int acumulador = 0;
            float promedio;

            Console.WriteLine("Ingrese 10 numeros:");

            while (i < 10)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                numero = Validacion.ValidarYSetear(numero, 100, -100);

                if (i==0 || numero>max)
                {
                    max = numero;
                }
                if(i==0 || numero<min)
                {
                    min = numero;
                }

                acumulador = acumulador + numero;

                i++;                
            }

            promedio = (float) acumulador / 10;

            Console.WriteLine("El maximo es {0}, el minimo es {1} y el promedio es {2:.00}", max, min, promedio);

            Console.ReadKey();

        }
    }
}
