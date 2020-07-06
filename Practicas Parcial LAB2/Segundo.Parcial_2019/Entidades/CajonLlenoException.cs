using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP
{
    public class CajonLlenoException : Exception
    {
        public CajonLlenoException() : base("No se pudo agregar la fruta al cajon. Se ha llegado a la capacidad maxima del cajon") { }
    }
}
