using System;
using System.Collections.Generic;
using System.Text;

namespace Clase02_Ejercicio
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        //static string color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Sello.Imprimir());
            Console.ResetColor();
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        static string ArmarFormatoMensaje()
        {
            int tamanio;
            int i;
            string sello = "";

            tamanio = Sello.mensaje.Length;

            for(i=0; i<tamanio+2 ;i++)
            {
                sello += "*";
            }

            

            return sello + "\n" + "*" + mensaje + "*\n" + sello;
        }
        
    }
    
}
