using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_026
{
    public class ConArrays
    {
        public int[] ArrayConEnterosRandom;
        public void DefinirTamanio(int tamanio)
        {
            this.ArrayConEnterosRandom = new int[tamanio];
        }
        public void CargarNumerosRandom()
        {
            Random numeroAleatorio = new Random();
            for(int i=0; i<this.ArrayConEnterosRandom.Length; i++)
            {
                this.ArrayConEnterosRandom[i] = numeroAleatorio.Next(int.MinValue,int.MaxValue);
            }
        }
        public static void MostrarArrayRandom(string arrayDeEnteros)
        {
            Console.WriteLine(arrayDeEnteros);
        }
        public static string CrearStringDeArrayEnteros(int[] arrayDeEnteros)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < arrayDeEnteros.Length; i++)
            {
                sb.AppendLine(arrayDeEnteros[i].ToString());
            }
            return sb.ToString();
        }
        public static string CrearArrayDescendente(int[] arrayDeEnteros)
        {
            //uso LINQ
            int[] arrayOrdenadoDec = (from i in arrayDeEnteros orderby i descending select i).ToArray();

            return ConArrays.CrearStringDeArrayEnteros(arrayOrdenadoDec);
        }
        public static string CrearArrayAscendente(int[] arrayDeEnteros)
        {
            //uso LINQ
            int[] arrayOrdenadoAsc = (from i in arrayDeEnteros orderby i ascending select i).ToArray();

            return ConArrays.CrearStringDeArrayEnteros(arrayOrdenadoAsc);
        }
    }
}
