using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_015
{
    class Calculadora
    {
        public static double Calcular (double numero1, double numero2, string operador)
        {
            double resultado = 0;

            switch(operador)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "/":
                    while(Validar(numero2)==true)
                    {
                        Console.WriteLine("No se puede realizar la division por 0. Reingrese el segundo numero: ");
                        numero2 = Convert.ToDouble(Console.ReadLine());
                    }
                    resultado = numero1 / numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
            }

            return resultado;
        }
        static bool Validar(double numero2)
        {
            bool flag = false;
            if(numero2 == 0)
            {
                flag = true;
            }
            return flag;
        }

        public static bool ValidarOperador(string operador)
        {
            bool flag = false;
            switch (operador)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "/":
                    break;
                case "*":
                    break;
                default:
                    flag = true;
                    break;
            }
            return flag;
        }
    }
}
