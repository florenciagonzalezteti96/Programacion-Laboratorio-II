/**
 Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_013
{
    class Program
    {
        static void Main(string[] args)
        {
            double dobleABinario;
            string numeroEnBinario;

            Console.WriteLine("Ingrese un numero entero a convertir a binario: ");
            dobleABinario = Convert.ToDouble(Console.ReadLine());

            numeroEnBinario = Conversor.DecimalBinario(dobleABinario);
            Console.WriteLine("El numero " + dobleABinario + " en binario es " + numeroEnBinario);

            Console.WriteLine("Ingrese un numero binario a convertir a entero: ");
            numeroEnBinario = Console.ReadLine();

            dobleABinario = Conversor.BinarioDecimal(numeroEnBinario);
            Console.WriteLine("El numero " + numeroEnBinario + " en entero es " + dobleABinario);

            Console.ReadKey();

        }
    }
}
