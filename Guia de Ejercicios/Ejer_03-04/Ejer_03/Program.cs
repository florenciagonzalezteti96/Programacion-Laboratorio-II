using System;
/**
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
*/
namespace Ejer_03
{
    class Ejer_03
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int i;
            int j;
            int flag;

            Console.WriteLine("Ingrese un numero:");
            numeroIngresado = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los numeros primos anteriores a {0} son:", numeroIngresado);

            for (i=2 ; i<=numeroIngresado ; i++)
            {
                flag = 0;

                    for(j=2 ; j<i-1 && flag == 0 ; j++)
                    {
                        if (i % j == 0)
                        { 
                            flag = 1;
                        }
                    }
                    if (flag == 0)
                    {
                        Console.WriteLine(i);
                    }
            }

            Console.ReadKey();
        }
    }
}