using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ParaisoFiscal
    {
        private List<CuentaOffShore> _listadoCuentas;
        private eParaisosFiscales _lugar;
        public static int cantidadDeCuentas;
        public static DateTime fechaInicioActividades;

        ParaisoFiscal()
        {
            this._listadoCuentas = new List<CuentaOffShore>();    
        }
        private ParaisoFiscal(eParaisosFiscales lugar):this()
        {
            this._lugar = lugar;
        }
        static ParaisoFiscal()
        {
            cantidadDeCuentas = 0;
            fechaInicioActividades = DateTime.Now;
        }
        public static implicit operator ParaisoFiscal(eParaisosFiscales epf)
        {
            //ParaisoFiscal pf = new ParaisoFiscal(epf);
            return new ParaisoFiscal(epf);
        }
        public static bool operator ==(ParaisoFiscal pf, CuentaOffShore cos)
        {
            bool existeCuenta = false;
            foreach(CuentaOffShore item in pf._listadoCuentas)
            {
                if(item == cos)
                {
                    existeCuenta = true;
                    break;
                }
            }
            return existeCuenta;
        }
        public static bool operator !=(ParaisoFiscal pf, CuentaOffShore cos)
        {
            return !(pf == cos);
        }
        public static ParaisoFiscal operator -(ParaisoFiscal pf, CuentaOffShore cos)
        {
            int i = 0;
            if(pf == cos)
            {
                foreach (CuentaOffShore item in pf._listadoCuentas)
                {
                    if (item == cos)
                    {
                        pf._listadoCuentas.RemoveAt(i);
                        break;
                    }
                    i++;
                }
                Console.WriteLine("Se quito la cuenta del paraiso...");
                cantidadDeCuentas--;
            }
            else
            {
                Console.WriteLine("La cuenta no existe en el paraiso...");
            }
            return pf;
        }
        public static ParaisoFiscal operator +(ParaisoFiscal pf, CuentaOffShore cos)
        {
            if (!(pf == cos))
            {
                pf._listadoCuentas.Add(cos);
                
                Console.WriteLine("Se agrego la cuenta al paraiso...");
                cantidadDeCuentas++;
            }
            else
            {
                foreach(CuentaOffShore item in pf._listadoCuentas)
                {
                    if(item == cos)
                    {
                        item.Saldo += cos.Saldo;
                        break;
                    }
                }
                Console.WriteLine("Se actualizo el saldo de la cuenta...");
            }
            return pf;
        }
        public void MostrarParaiso()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nFecha de Inicio: " + fechaInicioActividades);
            sb.AppendLine("Locacion: "+ this._lugar);
            sb.AppendLine("Cantidad de 'cuentitas': " + cantidadDeCuentas);
            sb.Append("***************Listado de cuentas offshores***************");

            foreach(CuentaOffShore item in this._listadoCuentas)
            {
                sb.AppendLine("\n"+Cliente.RetornarDatos(item.Dueño));
                sb.AppendLine("Numero de cuenta: " + ((int)item).ToString());
                sb.AppendLine("Saldo en la cuenta: " + (item.Saldo).ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
