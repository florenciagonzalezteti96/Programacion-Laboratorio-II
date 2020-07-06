using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        #region Metodos
        public DepositoDeAutos(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Auto>();
        }
        public bool Agregar(Auto a)
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
        private int GetIndice(Auto a)
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
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            return d.Agregar(a);
        }
        public bool Remover(Auto a)
        {
            bool sePudoRemover = false;
            if (this.GetIndice(a) != -1)
            {
                this._lista.RemoveAt(this.GetIndice(a));
                sePudoRemover = true;
            }
            return sePudoRemover;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            return d.Remover(a);
        }
        public override string ToString()
        {
            StringBuilder depositoDeAutos = new StringBuilder();
            foreach(Auto autoEnDeposito in this._lista)
            {
                depositoDeAutos.AppendLine(autoEnDeposito.ToString());
            }
            return depositoDeAutos.ToString(); 
        }
        #endregion

    }
}
