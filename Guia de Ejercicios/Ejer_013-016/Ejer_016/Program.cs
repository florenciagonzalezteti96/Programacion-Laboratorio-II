/**
 16. Crear la clase Alumno de acuerdo al siguiente diagrama (ver pdf):--
a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle 
nombre, apellido y legajo a cada uno de ellos.--
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se 
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno 
desaprobado".
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_016
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte notaUno = 0;
            //byte notaDos = 0;

            Alumno primerAlumno;
            Alumno segundoAlumno;
            Alumno tercerAlumno;

            primerAlumno = new Alumno();
            segundoAlumno = new Alumno();
            tercerAlumno = new Alumno();

            primerAlumno.nombre = "Juana";
            primerAlumno.apellido = "Gonzalez";
            primerAlumno.legajo = 108520;

            segundoAlumno.nombre = "Lorena";
            segundoAlumno.apellido = "Garcia";
            segundoAlumno.legajo = 108560;

            tercerAlumno.nombre = "Rocio";
            tercerAlumno.apellido = "Estevez";
            tercerAlumno.legajo = 108950;

            primerAlumno.Estudiar(5,3);
            segundoAlumno.Estudiar(5,9);
            tercerAlumno.Estudiar(1,2);

            primerAlumno.CalcularFinal();
            segundoAlumno.CalcularFinal();
            tercerAlumno.CalcularFinal();

            Console.WriteLine(primerAlumno.Mostrar());
            Console.WriteLine(segundoAlumno.Mostrar());
            Console.WriteLine(tercerAlumno.Mostrar());

            Console.ReadKey();
        }
    }
}
