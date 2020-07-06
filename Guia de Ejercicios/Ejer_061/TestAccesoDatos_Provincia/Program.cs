using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadeBaseDeDatos_Provincia;

namespace TestAccesoDatos_Provincia
{
    class Program
    {
        static void Main(string[] args)
        {
            AccesoDatos_Provincia acceso = new AccesoDatos_Provincia();
            List<Provincia> listaProvincias = acceso.ObtenerListaProvincias();

            foreach(Provincia provinciaEnLista in listaProvincias)
            {
                Console.WriteLine(provinciaEnLista.ToString());
            }


            Console.ReadKey();
        }
    }
}
