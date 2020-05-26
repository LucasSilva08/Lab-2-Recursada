using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DepositoDeAutos
    {
        private int _capacidadMaxima;
        private List<Auto> _lista;

        public DepositoDeAutos(int capacidad)
        {
            this._lista = new List<Auto>();
            this._capacidadMaxima = capacidad;
        }
        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            if (d._lista.Count == 0)
            {
                retorno = true;
            }
            else if (d._lista.Count < d._capacidadMaxima)
            {
                foreach (Auto item in d._lista)
                {
                    if (!item.Equals(a))
                    {

                        retorno = true;
                        break;

                    }
                }

            }
            if (retorno)
                d._lista.Add(a);
            return retorno;
        }
        private int GetIndice(Auto a)
        {

            int i = -1;
            foreach (Auto item in this._lista)
            {
                i++;
                if (item.Equals(a))
                {
                    return i;

                }
            }
            return -1;
        }
        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool retorno = false;
            int indice = d.GetIndice(a);
            if (indice > -1)
            {
                d._lista.RemoveAt(indice);
                retorno = true;
            }
            return retorno;
        }
        public bool Agregar(Auto a)
        {
            bool retorno = false;
            if (this + a)
            {
                retorno = true;

            }
            return retorno;
        }
        public bool Remover(Auto a)
        {
            bool retorno = false;
            if (this - a)
            {
                retorno = true;
            }
            return retorno;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Capacidad Maxima: {0}\n", this._capacidadMaxima);
            sb.AppendLine("Listado de Autos: ");
            foreach (Auto item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }
    }
}
