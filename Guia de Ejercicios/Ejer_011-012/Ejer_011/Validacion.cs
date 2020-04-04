using System;
using System.Collections.Generic;
using System.Text;

namespace Ejer_011
{
    class Validacion
    {
        public static bool Validar(int valor, int max, int min)
        {
            bool validacion = true;

            if (valor<min || valor>max)
            {
                validacion = false;
            }

            return validacion;
        }
        public static int ValidarYSetear(int valor, int max, int min)
        {
            bool validacion = true;

            validacion = Validacion.Validar(valor, max, min);

            while (validacion != true)
            {
                Console.WriteLine("El valor debe encontrarse entre {0} y {1}. Reingrese:", min, max);
                valor = Convert.ToInt32(Console.ReadLine());
                validacion = Validacion.Validar(valor, max, min);
            }

            return valor;
        }
    }
}
