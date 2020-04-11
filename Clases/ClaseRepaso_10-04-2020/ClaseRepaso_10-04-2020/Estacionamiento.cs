using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseRepaso_10_04_2020
{
    class Estacionamiento
    {
        string nombreEstacionamiento;
        private Auto[] arrayDeAuto;//el array esta ocupando memoria, pero no lo puedo usar hasta no hacerle un NEW
        private double precioDeAuto;
        public static Random numeroAleatorio;

        public Estacionamiento(string estacionamiento, int capacidadEstacionamiento) : this(capacidadEstacionamiento)
        {
            this.nombreEstacionamiento = estacionamiento;

        }
        private Estacionamiento(int capacidadEstacionamiento)
        {
            arrayDeAuto = new Auto[capacidadEstacionamiento];  //un array es un objeto asi que lo creo con el NEW.
            this.precioDeAuto = Estacionamiento.GenerarPrecio();

        }
        static Estacionamiento()
        {
            numeroAleatorio = new Random();
        }
        public static int GenerarPrecio()
        {
            return numeroAleatorio.Next(100, 500);
        }
        public static string MostrarMensaje()
        {
            return "Hola Mundo";
        }
        public static bool operator ==(Estacionamiento estacionamiento, Auto auto)
        {
            /*bool siExiste = false;
            foreach(Auto auxAuto in estacionamiento.arrayDeAuto)//recorro el array de autos dentro del objeto estacionamiento, copiando el atributo en un dato aux
            {
                Console.WriteLine(auxAuto.GetInformacion());//no se pueden modificar datos dentro del foreach, no tengo el indice7
                if( ! (auxAuto is null) )
                {
                    if(auxAuto == auto)//utilizo el metodo de sobrecargar de operadores de Auto - compara por patentes
                    {
                        siExiste = true;
                    }
                }
                
            }

            for(int i=0;i<estacionamiento.arrayDeAuto.Length;i++)
            {
                Console.WriteLine(estacionamiento.arrayDeAuto[i].GetInformacion());//el array de autos, en la posicion i, es un dato de tipo Auto, entonces puedo acceder a los metodos de esa clase.
                if (!(estacionamiento.arrayDeAuto[i] is null))
                {
                    if (estacionamiento.arrayDeAuto[i] == auto)
                    {
                        siExiste = true;
                    }
                }
            }

            return siExiste;*/

            return estacionamiento.arrayDeAuto.Contains(auto);//devuelve true si esta o false si no esta
        }

        public static bool operator !=(Estacionamiento estacionamiento, Auto auto)
        {
            return !(estacionamiento == auto);
        }
        public static bool operator +(Estacionamiento estacionamiento, Auto auto)
        {
            bool sePudoAgregar = false;
            if(estacionamiento != auto)// si el auto no esta adentro
            {
                for (int i = 0; i < estacionamiento.arrayDeAuto.Length; i++)
                {
                    if (estacionamiento.arrayDeAuto[i] is null)//si encuentra un lugar disponible
                    {
                        estacionamiento.arrayDeAuto[i] = auto;//agrego el elemento
                        sePudoAgregar = true;
                        break;
                    }
                }
            }
            return sePudoAgregar;
        }

        public static implicit operator Estacionamiento(int capacidad)//tengo que castear
        {
            return new Estacionamiento(capacidad);
        }
    }
}
