using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_014
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double areaCuadrado;

            areaCuadrado = Math.Pow(lado, 2);

            return areaCuadrado;
        }

        public static double CalcularTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double areaTriangulo;

            areaTriangulo = (double) (baseTriangulo * alturaTriangulo) / 2;

            return areaTriangulo;
        }


        public static double CalcularCirculo(double diametro)
        {
            double areaCirculo;
            double radio;

            radio = (double) diametro / 2;
            areaCirculo = 3.14 * (Math.Pow(radio, 2));

            return areaCirculo;
        }
    }
}
