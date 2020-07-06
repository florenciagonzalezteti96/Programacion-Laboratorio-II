using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Una PILA o STACK nos permite guardar elementos usando una estructura de tipo LIFO (last-in-first-out), 
es decir, el último que entra es el primero en salir, las inserciones y extracciones de datos
se realizan por el mismo lado.

Forma de crear:
--El constructor Stack() inicializa una nueva instancia de la clase Stack(Pila)
C/ nueva instancia esta vacia y tiene una capacidad inicial default.
--Stack(ICollection) inicializa una nueva instancia de la clase Stack(Pila)
C/ nueva instancia tiene elementos copiados de la coleccion especifica que se pasa por parametro de entrada
y tiene la misma capacidad inicial que el numero de elementos copiados.
--Stack(Int32) inicializa una nueva instancia de la clase Stack(Pila) que esta vacia
y tiene una capacidad inicial especificada o la capacidad inicial por default, cualquiera sea la mas grande.

*/

namespace Ejer_027
{
    class ConPilas
    {
        public Stack<int> pilaDeEnteros;

        public void DefinirPila()
        {
            this.pilaDeEnteros = new Stack<int>();
        }
        public void CargarNumerosRandom(int tamanio)
        {
            Random numeroAleatorio = new Random();
            for (int i = 0; i <= tamanio; i++)
            {
                this.pilaDeEnteros.Push(numeroAleatorio.Next(int.MinValue, int.MaxValue));
            }
        }
        public static void MostrarPilaRandom(string pilaDeEnteros)
        {
            Console.WriteLine(pilaDeEnteros);
        }
        public static void MostrarPilaRandom(Stack<int> pilaDeEnteros)
        {
            Console.WriteLine(pilaDeEnteros);
        }
        public static string CrearStringDePilaEnteros(Stack<int> pilasDeEnteros)
        {
            StringBuilder sb = new StringBuilder();
            foreach(int item in pilasDeEnteros)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public static string CrearPilaDescendente(Stack<int> pilasDeEnteros)
        {
            //uso LINQ
            Stack<int> pilaDescendente = new Stack<int>();

            pilaDescendente = ConPilas.CrearPilaEnterosPositivos(pilasDeEnteros);

            pilaDescendente = (int)(from i in pilaDescendente orderby i ascending select i);

            return ConPilas.CrearStringDePilaEnteros(pilaDescendente);
        }
        public static Stack<int> CrearPilaEnterosPositivos(Stack<int> pilasDeEnteros)
        {
            Stack<int> pilaDePositivos = new Stack<int>();
            if (pilasDeEnteros.Count > 0)
            {
                foreach (int entero in pilasDeEnteros)
                {
                    if (entero > 0)
                    {
                        pilaDePositivos.Push(entero);
                    }
                }
            }
            foreach (int entero in pilaDePositivos)
            {

                Console.WriteLine("ESTOS SON LOS ENTEROS POSITIVOS");
                Console.WriteLine(entero);
                
            }
            return pilaDePositivos;
        }
        public static string CrearPilaAscendente(Stack<int> pilasDeEnteros)
        {
            //uso LINQ
            Stack<int> pilaAscendente = new Stack<int>();

            pilaAscendente = ConPilas.CrearPilaEnterosNegativos(pilasDeEnteros);

            pilaAscendente = (int) (from i in pilaAscendente orderby i ascending select i);

            return ConPilas.CrearStringDePilaEnteros(pilaAscendente);
        }
        public static Stack<int> CrearPilaEnterosNegativos(Stack<int> pilasDeEnteros)
        {
            Stack<int> pilaDeNegativos = new Stack<int>();
            if (pilasDeEnteros.Count > 0)
            {
                foreach (int item in pilasDeEnteros)
                {
                    if (item < 0)
                    {
                        pilaDeNegativos.Push(item);
                    }
                }
            }
            return pilaDeNegativos;
        }

    }
}
