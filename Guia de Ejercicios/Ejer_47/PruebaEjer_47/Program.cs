using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejer_47;

namespace PruebaEjer_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("TORNEO DE FUTBOL!");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("TORNEO DE BASQUET!");

            EquipoFutbol futbol1 = new EquipoFutbol("FUTBOL 1", DateTime.Today);
            EquipoFutbol futbol2 = new EquipoFutbol("FUTBOL 2", DateTime.Today);
            EquipoFutbol futbol3 = new EquipoFutbol("FUTBOL 3", DateTime.Today);

            EquipoBasquet basquet1 = new EquipoBasquet("BASQUET 1", DateTime.Today);
            EquipoBasquet basquet2 = new EquipoBasquet("BASQUET 2", DateTime.Today);
            EquipoBasquet basquet3 = new EquipoBasquet("BASQUET 3", DateTime.Today);

            torneoFutbol += futbol1;
            torneoFutbol += futbol2;
            torneoFutbol += futbol3;

            torneoFutbol += futbol1;

            torneoBasquet += basquet1;
            torneoBasquet += basquet2;
            torneoBasquet += basquet3;

            torneoBasquet += basquet1;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());

            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}
