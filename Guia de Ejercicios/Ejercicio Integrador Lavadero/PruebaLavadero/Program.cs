using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaLavadero
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Gonzalez Teti Florencia";

            //primero creo un lavadero
            Lavadero lavadero1 = new Lavadero(1250, 9800, 6520);
            Lavadero lavadero2 = new Lavadero(2500, 1500, 8000);

            //Agrego los vehiculos accediendo a las clases derivadas
            Auto auto1 = new Auto(4, "AUT985", 4, Vehiculo.EMarcas.Fiat);
            Auto auto2 = new Auto(4, "AUT988", 4, Vehiculo.EMarcas.Honda);
            Auto auto3 = new Auto(4, "AUT980", 4, Vehiculo.EMarcas.Honda);

            Moto moto1 = new Moto(250, "MOT650", 2, Vehiculo.EMarcas.Fiat);
            Moto moto2 = new Moto(500, "MOT842", 2, Vehiculo.EMarcas.Scania);
            Moto moto3 = new Moto(250, "MOT784", 2, Vehiculo.EMarcas.Honda);

            Camion camion1 = new Camion(4, "CAM125", 4, Vehiculo.EMarcas.Fiat);
            Camion camion2 = new Camion(4, "CAM254", 4, Vehiculo.EMarcas.Zanella);
            Camion camion3 = new Camion(4, "CAM165", 4, Vehiculo.EMarcas.Scania);

            //agrego vehiculos
            lavadero1 += auto1;
            lavadero1 += moto1;
            lavadero1 += camion1;

            //muestro lavadero

            lavadero2 += auto2;
            lavadero2 += moto2;
            lavadero2 += camion2;

            Console.WriteLine(lavadero2.GetLavadero);

            lavadero2 -= camion3;//no existe

            lavadero2 -= auto2;//se quito

            lavadero1 += auto1;//ya existe

            
            Console.WriteLine("*******------------------*******");
            lavadero2.GetVehiculo.Sort(Lavadero.OrdenarVehiculosPorMarca);
            Console.WriteLine(lavadero2.GetLavadero);
            Console.WriteLine("*******------------------*******");
            lavadero2.GetVehiculo.Sort(Lavadero.OrdenarVehiculosPorPatente);
            Console.WriteLine(lavadero2.GetLavadero);

            Console.ReadKey();

        }
    }
}
