using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP
{
    public interface IDeserializar
    {
        bool Xml(string archivo, out Fruta datos);
    }
}
