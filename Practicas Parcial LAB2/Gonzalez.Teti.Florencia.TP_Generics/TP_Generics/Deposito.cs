using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T> where T : class
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        #region Metodos
        public Deposito(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<T>();
        }
        public bool Agregar(T a)
        {
            bool sePudoAgregar = false;
            if (this._lista.Count < this._capacidadMaxima)
            {
                if (this.GetIndice(a) == -1)
                {
                    this._lista.Add(a);
                    sePudoAgregar = true;
                }
            }
            return sePudoAgregar;
        }
        private int GetIndice(T a)
        {
            int seEncontro = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == a)
                {
                    seEncontro = i;
                    break;
                }
            }
            return seEncontro;
        }
        public static bool operator +(Deposito<T> d, T a)
        {
            return d.Agregar(a);
        }
        public bool Remover(T a)
        {
            bool sePudoRemover = false;
            if (this.GetIndice(a) != -1)
            {
                this._lista.RemoveAt(this.GetIndice(a));
                sePudoRemover = true;
            }
            return sePudoRemover;
        }
        public static bool operator -(Deposito<T> d, T a)
        {
            return d.Remover(a);
        }
        public override string ToString()
        {
            StringBuilder deposito = new StringBuilder();
            deposito.AppendLine("CAPACIDAD MAXIMA: " + this._capacidadMaxima);
            deposito.AppendLine("LISTADO DE " + typeof(T).Name);
            foreach (T itemEnDeposito in this._lista)
            {
                deposito.AppendLine(itemEnDeposito.ToString());
            }
            return deposito.ToString();
        }
        #endregion
    }
}
