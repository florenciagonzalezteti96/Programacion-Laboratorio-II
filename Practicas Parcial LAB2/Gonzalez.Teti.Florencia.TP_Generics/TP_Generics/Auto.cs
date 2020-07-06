using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _color;
        private string _marca;

        #region Propiedades
        public string Color
        {
            get
            {
                return this._color;
            }
        }
        public string Marca
        {
            get
            {
                return this._marca;
            }
        }
        #endregion

        #region Metodos
        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }
        public override bool Equals(object obj)
        {
            return (obj.GetType() == typeof(Auto)) && (this == (Auto)obj);
        }
        public static bool operator ==(Auto a, Auto b)
        {
            return (String.Compare(a.Color, b.Color) == 0) && (String.Compare(a.Marca, b.Marca) == 0);
        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return "MARCA: " + this.Marca + " -- COLOR: " + this.Color;
        }
        #endregion
    }
}
