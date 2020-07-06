using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeCocinas
    {
        private int _capacidadMaxima;
        private List<Cocina> _lista;

        #region Metodos
        public DepositoDeCocinas(int capacidad)
        {
            this._capacidadMaxima = capacidad;
            this._lista = new List<Cocina>();
        }
        public bool Agregar(Cocina c)
        {
            bool sePudoAgregar = false;
            if (this._lista.Count < this._capacidadMaxima)
            {
                if (this.GetIndice(c) == -1)
                {
                    this._lista.Add(c);
                    sePudoAgregar = true;
                }
            }
            return sePudoAgregar;
        }
        private int GetIndice(Cocina c)
        {
            int seEncontro = -1;
            for (int i = 0; i < this._lista.Count; i++)
            {
                if (this._lista[i] == c)
                {
                    seEncontro = i;
                    break;
                }
            }
            return seEncontro;
        }
        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            return d.Agregar(c);
        }
        public bool Remover(Cocina c)
        {
            bool sePudoRemover = false;
            if (this.GetIndice(c) != -1)
            {
                this._lista.RemoveAt(this.GetIndice(c));
                sePudoRemover = true;
            }
            return sePudoRemover;
        }
        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            return d.Remover(c);
        }
        public override string ToString()
        {
            StringBuilder depositoDeCocinas = new StringBuilder();
            foreach (Cocina cocinaEnDeposito in this._lista)
            {
                depositoDeCocinas.AppendLine(cocinaEnDeposito.ToString());
            }
            return depositoDeCocinas.ToString();
        }
        #endregion
    }
}
