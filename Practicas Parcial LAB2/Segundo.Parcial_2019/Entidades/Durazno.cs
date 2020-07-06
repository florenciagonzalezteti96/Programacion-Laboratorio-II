using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP
{
    public class Durazno : Fruta
    {
        //Durazno-> _cantPelusa:int (protegido); Nombre:string (prop. s/l, retornará 'Durazno'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true
        protected int _cantPelusa;

        public Durazno(string color, double peso, int cantidadDePelusa) : base(color, peso) { this._cantPelusa = cantidadDePelusa; }

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\nCantidad de pelusa: " + this._cantPelusa + "\n" + base.FrutaToString();
        }

    }
}
