using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        #region Propiedades
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
        }
        public bool EsIndustrial
        {
            get
            {
                return this._esIndustrial;
            }
        }
        public double Precio
        {
            get
            {
                return this._precio;
            }
        }
        #endregion

        #region Metodos
        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Cocina)) && (this == (Cocina)obj);
        }
        public static bool operator ==(Cocina c, Cocina b)
        {
            return (c.Codigo == b.Codigo);
        }
        public static bool operator !=(Cocina c, Cocina b)
        {
            return !(c == b);
        }
        public override string ToString()
        {
            return "CODIGO: " + this.Codigo + "-- PRECIO: " + this.Precio + "-- Es industrial? " + this.EsIndustrial;
        }
        #endregion

    }
}
