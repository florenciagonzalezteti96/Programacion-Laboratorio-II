using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace SP
{
    public class Cajon<T> : ISerializar
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }
        public int Capacidad
        {
            get
            {
                return this._capacidad;
            }
            set { this._capacidad = value; }
        }
        
        public double PrecioTotal
        {
            get
            {
                return this._precioUnitario * this._elementos.Count;
            }
            set { this._precioUnitario = value; }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
            this._elementos.Capacity = this._capacidad;
        }
        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }
        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            StringBuilder sbCajon = new StringBuilder();
            sbCajon.Append("Capacidad: " + this._capacidad + "\nCantidad de elementos: " + this.Elementos.Count + "\nPrecio total: " + this.PrecioTotal);

            foreach (T frutaEnCajon in this.Elementos)
            {
                sbCajon.AppendLine(frutaEnCajon.ToString());
            }

            return sbCajon.ToString();
        }

        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c != null && f != null)
            {
                if (c._capacidad >= c.Elementos.Count)
                {
                    c.Elementos.Add(f);
                }
                else
                {
                    throw new CajonLlenoException();
                }
            }

            return c;
        }
        public bool Xml(string datos)
        {
            bool sePudo = false;

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));

                using (TextWriter escritor = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + datos))
                {
                    serializador.Serialize(escritor, this);
                    sePudo = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error al serializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sePudo;
        }

        public delegate void DelegadoEventoPrecio(double precio, Cajon<T> cajon);

        public event DelegadoEventoPrecio EventoPrecio;
    }
}
