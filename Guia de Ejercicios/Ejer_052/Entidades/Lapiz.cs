using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        public Lapiz(int unidades)
        {
            this.tamanioMina = unidades;
        }

        ConsoleColor IAcciones.Color
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw (NotImplementedException)((IAcciones)this).Recargar();
            }
        }
        float IAcciones.UnidadesDeEscritura
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            }
        }
        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            ((IAcciones)this).UnidadesDeEscritura = ((IAcciones)this).UnidadesDeEscritura - (float)(texto.Length * 0.1);

            return new EscrituraWrapper(texto, ((IAcciones)this).Color);
        }

        bool IAcciones.Recargar(int unidades)
        {
                return new NotImplementedException();
        }

        public override string ToString()
        {
            return "LAPIZ DE COLOR " + ((IAcciones)this).Color + " CON UNA CANTIDAD DE TINTA DE " + this.UnidadesDeEscritura;
        }
    }
}
