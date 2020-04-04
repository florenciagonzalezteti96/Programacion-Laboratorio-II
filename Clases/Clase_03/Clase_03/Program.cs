using System;

namespace Clase_03
{
    class Program
    {
        static void Main(string[] args)
        {
            MiClase.estatico = 15;//asi accedo al estatico

            //para acceder un objeto no estatico: utilizo un constructor
            //tengo que inicializarlo con NEW, y a partir de ahi 
            //puedo acceder a los atributos no estaticos de la clase

            MiClase nuevo_objeto;
            MiClase nuevo_objeto2;
            //genero las variables, se generan en el stack por el CLR y la variable apunta a NULL porque no apuntan a nada en el HEAP
            //

            nuevo_objeto = new MiClase();//esto es un metodo mas, por eso MiClase(); no solo MiClase;
                                            //reserva memoria en el HEAP

            nuevo_objeto.no_estatico = 55;

            nuevo_objeto2 = new MiClase();

            nuevo_objeto2.no_estatico = 88;//todos los objetos tienen la misma estructura porque vienen de la misma clase
                                           //entre objetos solo comparten los atributos estaticos, porque son de clase, tienen el mismo valor para 
                                           //todas las instancias que yo genere de la clase
                                           //los valores de instancia son propios del objeto
            
            nuevo_objeto.CambiarValorEstatico(9);
            nuevo_objeto2.CambiarValorEstatico(8);

            MiClase nuevo_objeto3;

            nuevo_objeto3 = nuevo_objeto;//comparten los mismos atributos, asigno la misma direccion de memoria en el heap

            nuevo_objeto3.no_estatico = 44;//puedo cambiar el valor de este atributo en los dos objetos

            MiClase.MostrarEstatico(nuevo_objeto);

            Console.ReadKey();

        }
    }
}
