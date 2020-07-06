using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP
{
    public class Banana : Fruta
    {
        //Banana-> _paisOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Banana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->false
        protected string _paisOrigen;

        public Banana(string color, double peso, string paisDeOrigen) : base(color, peso) { this._paisOrigen = paisDeOrigen; }

        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\nPais de origen: " + this._paisOrigen + "\n" + base.FrutaToString();
        }

    }
}
