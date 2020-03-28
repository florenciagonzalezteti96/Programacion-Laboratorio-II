using System;

/** Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en 
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) 
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el 
usuario ingrese por consola.
*/

namespace Ejer_05
{
    class Ejer_05
    {
        static void Main(string[] args)
        {
            int numeroIngresado;//guardo el numero ingresado
            int i;
            int j;
            int m;
            int sumaDeAnteriores;//acumulador de todos los numeros anteriores al num a analizar
            int sumaDePosteriores;//acumulador de todos los numeros anteriores al num a analizar
            int ningunCentro = 0;

            Console.WriteLine("Ingrese un numero para calcular todos los centros numericos previos al mismo: ");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            for(i=2; i<numeroIngresado; i++)
            {
                sumaDeAnteriores = 0;
                sumaDePosteriores = 0;

                for(j=1;j<i;j++)
                {
                    sumaDeAnteriores = j + sumaDeAnteriores;
                }

                for(m=i+1; sumaDePosteriores < sumaDeAnteriores; m++)
                {
                    sumaDePosteriores = m + sumaDePosteriores;

                    if(sumaDePosteriores == sumaDeAnteriores)
                    {
                        Console.WriteLine(i + " ");
                        ningunCentro = 1;
                        break;
                    }
                }
            }
            if(ningunCentro == 0)
            {
                Console.WriteLine("No se encontro ningun centro numerico.");
            }
            Console.ReadKey(true);
        }
    }
}
