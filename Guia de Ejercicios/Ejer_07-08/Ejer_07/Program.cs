using System;
/**
 Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
     */
namespace Ejer_07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento;
            TimeSpan tiempoTotalVivido;
            int diasTotalesVividos;

            Console.Write("Ingrese su fecha de nacimiento (DD/MM/AAAA): ");
            fechaDeNacimiento = DateTime.Parse(Console.ReadLine());

            if((DateTime.Compare(fechaDeNacimiento, DateTime.Now))>0)
            {
                Console.WriteLine("Error. Reingrese su fecha de nacimiento (DD/MM/AAAA): ");
                fechaDeNacimiento = DateTime.Parse(Console.ReadLine());
            }
            else
            {
                tiempoTotalVivido = DateTime.Now - fechaDeNacimiento;
                diasTotalesVividos = tiempoTotalVivido.Days;

                Console.WriteLine("Usted ha vivido un total de {0} dias. ", diasTotalesVividos);

            }
            
            Console.ReadKey(); 

            /*int diaDeNacimiento;
            int mesDeNacimiento;
            int anioDeNacimiento;
            int diaActual;
            int mesActual;
            int anioActual;

            int diasPorAniosBisiestos = 0; //contador para los dias vividos por anios bisiestos
            int diasPorAniosNoBisiestos = 0; //contador para los dias vividos sin anios bisiestos
            bool esBisiesto = false;
            int instanciasDeBisiestos = 0;//contador que uso para calcular todos los años bisiestos del nacimiento hasta el anio actual
            int aniosTotales = 0;
            int diasTotales = 0;
            int i;

            //guardo la fecha actual
            anioActual = DateTime.Now.Year;
            mesActual = DateTime.Now.Month;
            diaActual = DateTime.Now.Day;

            Console.WriteLine("El anio actual es: {0}, el mes actual es {1} y el dia actual es {2}", anioActual, mesActual, diaActual);

            //pido la fecha de nacimiento del usuario
            Console.WriteLine("Ingrese su dia de nacimiento: ");
            diaDeNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su mes de nacimiento: ");
            mesDeNacimiento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese su anio de de nacimiento: ");
            anioDeNacimiento = Convert.ToInt32(Console.ReadLine());

            i = anioDeNacimiento;//variable de control que comienza en el anio de nacimiento

            while(anioDeNacimiento < anioActual)
            {
                esBisiesto = DateTime.IsLeapYear(i);
                if(esBisiesto)
                {
                    instanciasDeBisiestos++;//si es bisiesto sumo el contador.
                }
                i++;//voy avanzando los años
            }

            aniosTotales = anioActual - anioDeNacimiento; //calculo los anios totales

            diasPorAniosNoBisiestos = (aniosTotales - instanciasDeBisiestos) * 365; //calculo los dias sin anios bisiestos
            diasPorAniosBisiestos = instanciasDeBisiestos * 366;//calculo los dias con anios bisiestos

            diasTotales = diasPorAniosBisiestos + diasPorAniosNoBisiestos; // calculo la cantidad de dias por anios bisiestos

            int j;
            if(DateTime.IsLeapYear(anioActual))
            {
                while(j != mesDeNacimiento)
                {

                }
            }*/

        }
    }
}
