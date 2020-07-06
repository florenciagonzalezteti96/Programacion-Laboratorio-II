using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace PruebaEntidades
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - IMPLEMENTAR IAFIP.CALCULARIMPUESTO(AVION(33 % PRECIO) - DEPORTIVO(28 % PRECIO))");

            Avion av1 = new Avion(300f, 35.5f);
            Privado priv1 = new Privado(300f, 35.5f, 10);
            Deportivo dep1 = new Deportivo(300f, "DEP255", 55);
            Comercial com1 = new Comercial(300f, 35.5f, 55);

            Console.WriteLine("IMPUESTO DEL AVION: " + ((IAFIP)av1).CalcularImpuesto());
            Console.WriteLine("IMPUESTO DEL DEPORTIVO: " + ((IAFIP)dep1).CalcularImpuesto());

            Console.WriteLine("\n2 - VERIFICAR SI LA IMPLEMENTACION SE HEREDA(ENTRE AVION < --PRIVADO - COMERCIAL)");

            Console.WriteLine("IMPUESTO DEL AVION PRIVADO: " + ((IAFIP)priv1).CalcularImpuesto());
            Console.WriteLine("IMPUESTO DEL AVION COMERCIAL: " + ((IAFIP)com1).CalcularImpuesto());

            Console.WriteLine("\n4 - IMPLEMENTAR EL METODO GESTION.MOSTRARIMPUESTONACIONAL");

            Console.WriteLine("IMPUESTO DEL DEPORTIVO: " + Gestion.MostrarImpuestoNacional(av1));
            Console.WriteLine("IMPUESTO DEL AVION: " + Gestion.MostrarImpuestoNacional(dep1));
            Console.WriteLine("IMPUESTO DEL AVION PRIVADO: " + Gestion.MostrarImpuestoNacional(priv1));
            Console.WriteLine("IMPUESTO DEL AVION COMERCIAL: " + Gestion.MostrarImpuestoNacional(com1));
            
            Console.WriteLine("\n5 - IMPLEMENTAR IARBA.CALCULARIMPUESTO(CARRETA(18 % PRECIO) - AVION(27 % PRECIO) - DEPORTIVO(23 % PRECIO) - COMERCIAL(25 % PRECIO))");

            Deportivo dep2 = new Deportivo(100f, "DEP255", 55);
            Avion av2 = new Avion(100f, 35.5f);
            Comercial com2 = new Comercial(100f, 40f, 40);
            Carreta car2 = new Carreta(100f);

            Console.WriteLine("IMPUESTO DEL DEPORTIVO: " + ((IARBA)dep2).CalcularImpuesto());
            Console.WriteLine("IMPUESTO DEL AVION: " + ((IARBA)av2).CalcularImpuesto());
            Console.WriteLine("IMPUESTO DEL AVION COMERCIAL: " + ((IARBA)com2).CalcularImpuesto());
            Console.WriteLine("IMPUESTO DE LA CARRETA: " + ((IARBA)car2).CalcularImpuesto());

            Console.WriteLine("\n6- IMPLEMENTAR EL METODO GESTION.MOSTRARIMPUESTOPROVINCIAL");

            Console.WriteLine("IMPUESTO DEL DEPORTIVO: " + Gestion.MostrarImpuestoProvincial(dep2));
            Console.WriteLine("IMPUESTO DEL AVION: " + Gestion.MostrarImpuestoProvincial(av2));
            Console.WriteLine("IMPUESTO DEL AVION COMERCIAL: " + Gestion.MostrarImpuestoProvincial(com2));
            Console.WriteLine("IMPUESTO DE LA CARRETA: " + Gestion.MostrarImpuestoProvincial(car2));

            Console.ReadKey();
        }
    }
}
