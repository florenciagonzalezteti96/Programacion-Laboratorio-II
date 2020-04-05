using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer_016
{
    public class Alumno
    {
        public byte nota1;//
        public byte nota2;//
        public float notaFinal;//
        public string apellido;
        public int legajo;
        public string nombre;

        public void Estudiar(byte notaUno, byte notaDos)//metodo de instancia, pertenece a un objeto
        {
            /*Console.WriteLine("Ingrese la primera nota del alumno: ");
            notaUno = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota del alumno: ");
            notaDos = Convert.ToByte(Console.ReadLine());*/

            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            this.notaFinal = -1;//inicializo en -1 y solo cambio si cumple la condicion
            if(this.nota1>=4 && this.nota2>=4)
            {
                Random notaFinal = new Random();

                this.notaFinal = (float) notaFinal.Next(4, 10);
            }
        }
        public string Mostrar()
        {
            string mensaje = "";

            if(this.notaFinal != -1)
            {
                mensaje = "Nombre: " + this.apellido + ", " + this.nombre + "\nLegajo: " + this.legajo + "\nPrimera nota: "+this.nota1+"\nSegunda nota: "+this.nota2+"\nNota final: "+this.notaFinal+"\n";
            }
            else
            {
                mensaje = "Nombre: " + this.apellido + ", " + this.nombre + "\nLegajo: " + this.legajo + "\nPrimera nota: " + this.nota1 + "\nSegunda nota: " + this.nota2 + "\nAlumno Desaprobado.\n";

            }

            return mensaje ;
        }
    }
}
