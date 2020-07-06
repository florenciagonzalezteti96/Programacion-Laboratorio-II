using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_026
{
    class Program
    {
        static void Main(string[] args)
        {   
            //creo los arrays
            ConArrays array1 = new ConArrays();
            ConArrays array2 = new ConArrays();
            ConArrays array3 = new ConArrays();
            ConArrays array4 = new ConArrays();
            
            //defino la cantidad de cada array
            array1.DefinirTamanio(20);
            array2.DefinirTamanio(5);
            array3.DefinirTamanio(10);
            array4.DefinirTamanio(1);

            //cargo cada array con numeros random
            array1.CargarNumerosRandom();
            array2.CargarNumerosRandom();
            array3.CargarNumerosRandom();
            array4.CargarNumerosRandom();

            //muestro
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayDescendente(array1.ArrayConEnterosRandom));
            Console.WriteLine("------------------------------------------------------------------->");
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayDescendente(array2.ArrayConEnterosRandom));
            Console.WriteLine("------------------------------------------------------------------->");
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayDescendente(array3.ArrayConEnterosRandom));
            Console.WriteLine("------------------------------------------------------------------->");
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayDescendente(array4.ArrayConEnterosRandom));

            Console.WriteLine("ORDENADO DECRECIENTE----------------------------------------------->");
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayDescendente(array3.ArrayConEnterosRandom));
            Console.WriteLine("ORDENADO CRECIENTE----------------------------------------------->");
            ConArrays.MostrarArrayRandom(ConArrays.CrearArrayAscendente(array3.ArrayConEnterosRandom));



            Console.ReadKey();
        }
    }
}
