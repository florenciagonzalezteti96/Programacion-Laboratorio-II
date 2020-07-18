using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaComercioLibreria
{
    public class Cliente
    {
        public string nombre;
        public string apellido;
        public string residenciaLocal;
        public string nombreLocal;
        public string numeroDelCliente;
        public string telefonoDelCliente;
        public string CUIT;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = value;
            }
        }
        public string ResidenciaDelLocal
        {
            get
            {
                return this.residenciaLocal;
            }
            set
            {
                this.residenciaLocal = value;
            }
        }
        public string NombreDelLocal
        {
            get
            {
                return this.nombreLocal;
            }
            set
            {
                this.nombreLocal = value;
            }
        }
        public string CUITDelCliente
        {
            get
            {
                return this.CUIT;
            }
            set
            {
                this.CUIT = value;
            }
        }
        public string NumeroCliente
        {
            get
            {
                return this.numeroDelCliente;
            }
            set
            {
                this.numeroDelCliente = value;
            }
        }
        public string TelefonoCliente
        {
            get
            {
                return this.telefonoDelCliente;
            }
            set
            {
                this.telefonoDelCliente = value;
            }
        }

        public Cliente() { }
        
        public Cliente(string nombre, string apellido, string residenciaLocal, string nombreLocal, string numeroDelCliente, string telefono, string CUIT)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.residenciaLocal = residenciaLocal;
            this.nombreLocal = nombreLocal;
            this.numeroDelCliente = numeroDelCliente;
            this.telefonoDelCliente = telefono;
            this.CUIT = CUIT;
        }
    }
}
