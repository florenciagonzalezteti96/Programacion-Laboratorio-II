using System;
/**
Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
*/
namespace Ejer_06
{
    class Ejer_06
    {
        static void Main(string[] args)
        {
            int anioInicial;
            int anioFinal;
            int i;
            int noHayBisiestos = 0;

            Console.WriteLine("Ingrese un anio inicial: ");
            anioInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un anio final: ");
            anioFinal = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los anios bisiestos entre {0} y {1} son:", anioInicial, anioFinal);

            for(i=anioInicial;i<anioFinal;i++)
            {
                if(i%4 == 0)// si o si tiene que ser multiplo de 4
                {
                    if(i%100 == 0)//si es mult de 4 y de 100
                    {
                        if(i%400 == 0)//tiene que ser tambien mult de 400
                        {
                            Console.Write(i + " ");
                            noHayBisiestos = 1;
                        }
                    }
                    else //si no es multiplo de 100 pero si de 4
                    {
                        Console.Write(i + " ");
                        noHayBisiestos = 1;
                    }  
                }
            }

            if(noHayBisiestos == 0)
            {
                Console.WriteLine("\nNo hay anios bisiestos entre {0} y {1}", anioInicial, anioFinal);
            }

            Console.ReadKey(true);

        }
    }
}
