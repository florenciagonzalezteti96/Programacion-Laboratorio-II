using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;
        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }
        public void SetTinta(short tinta)
        {
            /*if (tinta < 0)//gasta tinta
            {
                while (tinta <= 0 && this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)//mientras que haya para restar
                {                                                           //y mientras que se mantenga en el rango la tinta del boligrafo
                    this.tinta--;//resto tinta que gaste
                    tinta++;//resto de lo que gaste
                }
            }
            else//carga tinta
            {
                while (tinta> 0 && this.tinta >= 0 && this.tinta <= cantidadTintaMaxima)
                {
                    this.tinta++;
                    Console.WriteLine("El nivel de tinta: {0}", this.tinta);
                    tinta--;
                    Console.WriteLine("tinta: {0}", tinta);
                    Console.ReadKey();
                }
            }*/
            int i;
            
                if (tinta < 0)//gasta tinta
                {
                    for (i=0; i > tinta; i--) //mientras que i sea mayor a tinta
                    {
                        this.tinta--; //resto tinta
                    }
                }
                else//carga tinta
                {
                    for (i = 0; i < tinta; i++) //mientras i sea menor a tinta
                    {
                        if (this.tinta < cantidadTintaMaxima) //si la tinta es menor a la cantidad maxima
                        {
                            this.tinta++; //agrego tinta
                        }
                        else//si llega al limite de la cantidad maxima
                        {
                            break;//me voy xd
                        }
                    }
                }
            
        }
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool banderaPintar = false;
            StringBuilder tintaUsada = new StringBuilder();
            short nivelDeTintaOriginal;//para obtener el nivel de tinta antes de restar o sumar el valor de tinta usado o cargado -> (short tinta)
            int nuevaTintaUsada;//la diferencia entre el valor original y el nuevo

            dibujo = tintaUsada.ToString();//inicializo el valor out

            if (this.GetTinta() > 0)//si hay tinta
            {
                banderaPintar = true;//pudo pintar, habia tinta

                nivelDeTintaOriginal = this.GetTinta();

                this.SetTinta(gasto);//resto el nivel de tinta que gasto
                nuevaTintaUsada = (int)nivelDeTintaOriginal - (this.GetTinta());

                tintaUsada.Append('*', nuevaTintaUsada);//creo el string de asteriscos
                dibujo = tintaUsada.ToString();

                Console.ForegroundColor = this.GetColor();
            }

            return banderaPintar;
        }
    }
}
