using System.Text;

namespace ClaseRepaso_10_04_2020
{
    class Auto
    {
        //patente, marca, cant puertas, dni dueño
        private string patente;
        private string marca;
        private int cantidadPuertas;
        private int dniDueño;
        #region Constructores
        public Auto(string patente, string marca, int cantPuertas, int dniDueño) : this(patente, dniDueño)
        {
            this.marca = marca;
            this.cantidadPuertas = cantPuertas;
        }
        public Auto(string patente, int dniDueño) : this()
        {
            this.patente = patente;
            this.dniDueño = dniDueño;
        }
        private Auto()
        {
            this.marca = "Dato no ingresado";
            this.cantidadPuertas = -1;
        }
        #endregion 
        public string GetInformacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Patente: {this.patente}");//escribe en la misma linea. asi se puede mostrar un string
            sb.AppendFormat("Marca: {0}\n", this.marca);
            if (this.cantidadPuertas != -1)
            {
                sb.AppendLine("Cantidad de puertas: " + this.cantidadPuertas);
            }
            else
            {
                sb.AppendLine("Cantidad de puertas: Dato no ingresado");
            }

            sb.AppendLine("DNI del dueño: " + this.dniDueño);

            return sb.ToString();
        }
        public void SetInformacion(int cantPuertas)
        {
            this.cantidadPuertas = cantPuertas;
        }
        public void SetInformacion(string marca)
        {
            this.marca = marca;
        }
        public void SetInformacion(string marca, int cantPuertas)//sobrecarga del metodo setInformacion pero reutilizo los otros metodos
        {
            this.SetInformacion(marca);
            this.SetInformacion(cantPuertas);
        }
        public static bool operator ==(Auto autoA, Auto autoB)//no es un metodo que necesite llamarse desde una instancia 
        {
            //bool sonIguales = false;
            //if(autoA.patente == autoB.patente)
            //{
            //    sonIguales = true;
            //}
            //return sonIguales;
            return autoA.patente == autoB.patente;
        }
        public static bool operator !=(Auto autoA, Auto autoB)//no es un metodo que necesite llamarse desde una instancia 
        {
            //bool sonDistintos = true;
            //if (autoA.patente == autoB.patente)
            //{
            //    sonDistintos = false;
            //}
            //return sonDistintos;
            return !(autoA == autoB);//se utiliza la comparacion entre autos que cree yo, compara por patentes.
        }

        public static explicit operator string(Auto auto)//tengo que castear
        {
            return auto.GetInformacion();
        }




    }
}
