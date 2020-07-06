using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace SP
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        //Manzana-> _provinciaOrigen:string (protegido); Nombre:string (prop. s/l, retornará 'Manzana'); 
        //Reutilizar FrutaToString en ToString() (mostrar todos los valores). TieneCarozo->true

        protected string _provinciaOrigen;

        public Manzana(): this("vacio", 0, "vacio") { }

        public Manzana(string color, double peso, string provinciaDeOrigen): base(color, peso) { this._provinciaOrigen = provinciaDeOrigen; }

        public string Nombre
        {
            get
            {
                return "Manzana";
            }
        }

        public string ProvinciaOrigen
        {
            get
            {
                return this._provinciaOrigen;
            }
            set { this._provinciaOrigen = value; }
        }
        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + "\nProvincia de origen: " + this._provinciaOrigen + "\n" + base.FrutaToString();
        }

        public bool Xml(string datos)
        {
            bool sePudo = false;

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Manzana));

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

        bool IDeserializar.Xml(string datos, out Fruta fruta)
        {
            bool sePudo = false;
            fruta = null;

            try
            {
                XmlSerializer serializador = new XmlSerializer(typeof(Manzana));

                using (TextReader lector = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + datos))
                {
                    fruta = (Fruta)serializador.Deserialize(lector);
                    sePudo = true;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error al deserializar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sePudo;
        }
    }
}
