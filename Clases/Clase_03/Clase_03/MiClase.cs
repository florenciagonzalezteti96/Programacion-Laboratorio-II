using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_03
{
    class MiClase
    {
        public static int estatico;
        public int no_estatico;

        static MiClase()
        {
            MiClase.estatico = 7;
        }
        public MiClase()//anula al constructor que viene desde el main
        {               //CONSTRUCTOR EXPLICITO -> inicializa atributos DE LA CLASE
                        //el new reserva la cant de memoria suficiente para que algo del tipo MiClase se pueda guardar en memoria
            this.no_estatico = 7;

        }

        public void CambiarValorEstatico(int valor)//metodo de instancia (si no especifico static, el determinado es no estatico)
        {
            MiClase.estatico = valor;

            //no_estatico = 77; si bien la IDE lo reconoce, por convencion, se usa this 

            this.no_estatico = 77;//this refiere al objeto que esta accediendo al metodo en ese momento
                                    //el this nunca puede referir a un parametro actual, a un objeto que sea actual.
        }

        public static void MostrarEstatico(MiClase param)//le paso una referencia de mi clase para poder acceder a ella y mostrar no estaticos
        {
            Console.WriteLine(MiClase.estatico);

            Console.WriteLine(param.no_estatico);//los atributos estaticos solo se muestran a partir de una instancia de objeto
            
        
        }

    }
}
