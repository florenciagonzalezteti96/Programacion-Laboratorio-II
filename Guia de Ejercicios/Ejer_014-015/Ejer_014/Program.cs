/*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el 
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_014
{
    class Ejer_014
    {
        static void Main(string[] args)
        {
            double datoIngresado;
            double resultado;
            int opcion;

            Console.WriteLine("Ingrese la opcion para calcular los datos:");
            Console.WriteLine("1. Calcular el area de un cuadrado.");
            Console.WriteLine("2. Calcular el area de un triangulo.");
            Console.WriteLine("3. Calcular el area de un circulo.");

            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");

                    datoIngresado = Convert.ToDouble(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularCuadrado(datoIngresado);

                    Console.WriteLine("El area del cuadrado con lado de longitud {0:.00} es {1:.00}", datoIngresado, resultado);

                    break;
                case 2:
                    { 
                    double baseTriangulo;
                    double longitudTriangulo;

                    Console.WriteLine("Ingrese la base del triangulo: ");
                    baseTriangulo = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ingrese la logitud del triangulo: ");
                    longitudTriangulo = Convert.ToDouble(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularTriangulo(baseTriangulo, longitudTriangulo);

                    Console.WriteLine("El area del triangulo con base de {0:.00} y longitud de {1:.00} es {2:.00}", baseTriangulo, longitudTriangulo, resultado);
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el diametro del circulo: ");

                    datoIngresado = Convert.ToDouble(Console.ReadLine());

                    resultado = CalculoDeArea.CalcularCirculo(datoIngresado);

                    Console.WriteLine("El area del circulo con diametro {0:.00} es {1:.00}", datoIngresado, resultado);

                    break;
                default:
                    Console.WriteLine("Opcion no valida.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
