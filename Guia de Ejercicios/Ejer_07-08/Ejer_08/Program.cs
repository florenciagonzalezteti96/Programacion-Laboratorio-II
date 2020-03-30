using System;
using System.Collections.Generic;
/**
Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.

Se pide calcular el importe a cobrar teniendo en cuenta que al total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.

    REVISAR 
    
    Console.Write("Desea seguir ingresando empleados? s / n :");
    seguir = Console.ReadKey().KeyChar; -> No permite ingresar nombre, directamente va al apellido.

 */
namespace Ejer_08
{
    class Ejer_08
    {
        public struct Empleado//public -> visibilidad struct -> palabra reservada Empleado -> nombre de estructura
        {
            public int valorHora;//debo declararlas como variables publicas para acceder a ellas desde otra funcion, por defecton son private
            public string nombre;
            public string apellido;
            public int antiguedad;
            public int cantidadHorasTrabajadas;
            public float totalDescuentos;
            public float salarioBruto;
            public float salarioNeto;
        }
        static void Main(string[] args)
        {
            char seguir = 's';
            int totalEmpleados = 0;

            List<Empleado> listaDeEmpleados = new List<Empleado>();

            do
            {
                Empleado nuevoEmpleado = new Empleado();
                Console.WriteLine();

                Console.WriteLine("\nIngrese los datos del empleado:");

                Console.WriteLine("Nombre del empleado:");
                nuevoEmpleado.nombre = Console.ReadLine();

                Console.WriteLine("Apellido del empleado:");
                nuevoEmpleado.apellido = Console.ReadLine();

                Console.WriteLine("Antiguedad del empleado (anios):");
                nuevoEmpleado.antiguedad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("El valor de la hora trabajada por el empleado:");
                nuevoEmpleado.valorHora = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cantidad de horas trabajadas del empleado:");
                nuevoEmpleado.cantidadHorasTrabajadas = Convert.ToInt32(Console.ReadLine());

                nuevoEmpleado.salarioBruto = (nuevoEmpleado.valorHora*nuevoEmpleado.cantidadHorasTrabajadas) + (nuevoEmpleado.antiguedad*150);

                nuevoEmpleado.totalDescuentos = (nuevoEmpleado.salarioBruto * 13) / 100;

                nuevoEmpleado.salarioNeto = nuevoEmpleado.salarioBruto - nuevoEmpleado.totalDescuentos;

                listaDeEmpleados.Add(nuevoEmpleado);

                Console.Write("Desea seguir ingresando empleados? s / n :");

                seguir = Char.Parse(Console.ReadLine());

            } while (seguir != 'n');

            totalEmpleados = listaDeEmpleados.Count;

            for (int i=0;i<totalEmpleados;i++)
            {
                Console.WriteLine(" -------------------- ");
                Console.WriteLine("Nombre del empleado: {1}, {0}", listaDeEmpleados[i].nombre, listaDeEmpleados[i].apellido);
                Console.WriteLine("Antiguedad del empleado: {0}", listaDeEmpleados[i].antiguedad);
                Console.WriteLine("Valor por hora: {0}", listaDeEmpleados[i].valorHora);
                Console.WriteLine("Salario Bruto: {0:.0}", listaDeEmpleados[i].salarioBruto);
                Console.WriteLine("Total de descuentos: {0:.0}", listaDeEmpleados[i].totalDescuentos);
                Console.WriteLine("Salario Neto: {0:.0}", listaDeEmpleados[i].salarioNeto);
            }

            Console.ReadKey();
        }
    }
}
