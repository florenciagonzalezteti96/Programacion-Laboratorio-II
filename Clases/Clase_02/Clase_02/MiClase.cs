using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    class MiClase
    {
        /* MIEMBROS DE UNA CLASE
         * 
         * miembros ESTATICOS:
         * llevan la palabra reservada "static"
         * se pueden llamar: miembro estatico, miembro de clase(significa que es estatico)
         * como se invocan: NombreDeLaClase.MiembroAlCualQuieroAcceder (Ejemplo: Miclase.entero) 
         * 
         * miembros NO ESTATICOS
         * no llevan la palabra "static"
         * se pueden llamar: miembros de instancia(variables que no son estaticas)
         * como se invocan: a partir del objeto. Objeto.MiembroAlCualQuieroAcceder
         * 
         */

        //atributos...

        public static int entero;//puedo acceder a este atributo desde fuera de la clase

        public static string  cadena;

        public static void Mostrar(string otraVariable)
        {
            int variable;

            System.Console.WriteLine(MiClase.entero);//siempre colocar el nombre de la clase.atributo -> para diferencias las variables que son de una clase
                                                // y las que son creadas dentro de un metodo o que el metodo recibe como parametro
            System.Console.WriteLine(cadena);
        }
    
    }
}
