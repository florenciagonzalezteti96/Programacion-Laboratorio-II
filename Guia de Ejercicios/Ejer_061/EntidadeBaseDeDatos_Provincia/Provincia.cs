using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadeBaseDeDatos_Provincia
{
    public class Provincia
    {
        public int id;
        public string nombre_provincia;
        public int cantidad_habitantes;
        
        public Provincia() { }

        public Provincia(string nombre, int habitantes)
        {
            this.nombre_provincia = nombre;
            this.cantidad_habitantes = habitantes;
        }
        public Provincia(int id, string nombre, int habitantes)
        {
            this.id = id;
            this.nombre_provincia = nombre;
            this.cantidad_habitantes = habitantes;
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }
        public string NombreProvincia
        {
            get
            {
                return this.nombre_provincia;
            }
            set
            {
                this.nombre_provincia = value;
            }
        }
        public int CantidadHabitantes
        {
            get
            {
                return this.cantidad_habitantes;
            }
            set
            {
                this.cantidad_habitantes = value;
            }
        }
        public override string ToString()
        {
            return this.id + " - " + this.nombre_provincia + " - " + this.cantidad_habitantes;
        }








    }
}
