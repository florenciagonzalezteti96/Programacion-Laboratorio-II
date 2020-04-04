using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_015
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            double numero1;
            double numero2;
            double resultado;
            string operador = "";

            do
            {
                Console.Clear();

                Console.WriteLine("Ingrese el primero operando: ");
                numero1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo operando: ");
                numero2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Elija entre los operadores + , - , / o * :");
                operador = Console.ReadLine();

                while(Calculadora.ValidarOperador(operador) == true)
                {
                    Console.WriteLine("El operador ingresado es invalido. Vuelva a elegir entre los operadores + , - , / o * :");
                    operador = Console.ReadLine();
                }

                resultado = Calculadora.Calcular(numero1, numero2, operador);
                Console.WriteLine("El resultado de {0:0.0} {1} {2:0.0} es: {3:0.0}", numero1, operador, numero2, resultado);

                Console.WriteLine("¿Desea continuar calculando? Ingrese s o n para SI o NO: ");
                continuar = Console.ReadKey().KeyChar;

                Console.ReadKey();

            } while (continuar == 's');
        }
    }
}
