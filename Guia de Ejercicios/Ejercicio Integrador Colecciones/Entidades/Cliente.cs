using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        private Cliente()
        {
            this._aliasParaIncognito = "Sin Alias";
            this._nombre = "NN";
            this._tipoDeCliente = eTipoCliente.SinTipo;
        }
        public Cliente(eTipoCliente tipoCliente): this()
        {
            this._tipoDeCliente = tipoCliente;
            this.CrearAlias();
        }
        public Cliente(eTipoCliente tipoCliente, string nombre) : this(tipoCliente)
        {
            this._nombre = nombre;
        }
        private void CrearAlias()
        {
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();
            int random = rnd.Next(1000, 9999);
        
            this._aliasParaIncognito = (random.ToString()+this._tipoDeCliente).ToString();
        }
        public string GetAlias()
        {
            int sonIguales;
            sonIguales = String.Compare(this._aliasParaIncognito, "Sin Alias");
            if (sonIguales == 0)
            {
                this.CrearAlias();
            }
            return this._aliasParaIncognito;
        }
        private string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this._nombre);
            sb.AppendLine("Tipo de cliente: " + this._tipoDeCliente);
            sb.Append("Alias: " + this._aliasParaIncognito);

            return sb.ToString();
        }
        public static string RetornarDatos(Cliente uncliente)
        {
            return uncliente.RetornarDatos();
        }
    }





}
