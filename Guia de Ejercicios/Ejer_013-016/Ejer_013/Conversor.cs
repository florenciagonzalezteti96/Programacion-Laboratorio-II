using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_013
{
    class Conversor
    {
        public static string DecimalBinario(double numeroAConvertir)
        {
            string numeroEnBinario = "";
            int numero;

            numero = (int) Math.Round(numeroAConvertir);

            numeroEnBinario = Convert.ToString(numero, 2);

            return numeroEnBinario;
        }
        public static double BinarioDecimal(string numeroAConvertir)
        {
            double numeroEnEntero = 0;

            numeroEnEntero = Convert.ToInt32(numeroAConvertir, 2);

            return numeroEnEntero;
        }
    }
}
