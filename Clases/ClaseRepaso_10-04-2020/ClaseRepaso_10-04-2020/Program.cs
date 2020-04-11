using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
- estacionamiento
- altas y bajas de autos grabados en un estacionamiento
     
     */
namespace ClaseRepaso_10_04_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto("fgh456", "Fiat", 4, 11222333);
            Auto auto2 = new Auto("fgh456", "Fiat", 5, 11222555);
            string infoDeAuto;

            Console.WriteLine(auto1.GetPatente());

            auto1.SetInformacion(5);
            if (auto1 == auto2)
            {
                Console.WriteLine("Son iguales");
            }
            if (auto1 != auto2)
            {
                Console.WriteLine("Son distintos");
            }

            Estacionamiento estacionamiento1 = new Estacionamiento("Sector A", 5);
            Estacionamiento estacionamiento2 = new Estacionamiento("Sector B", 6);

            infoDeAuto = (string)auto1;//->tengo que castear. explicito. Se transforma generalmente de uno mas grande a uno mas chico.

            Estacionamiento estacionamiento3 = 10;//->implicito. piso el dato anterior. Se transforma generalmente de uno mas chico a uno mas grande.




            Console.ReadKey();

        }
    }
}
