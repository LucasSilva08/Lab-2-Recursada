using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito<T>
    {
        private int _capacidadMaxima;
        private List<T> _lista;

        public Deposito(int capacidad)
        {
            this._lista = new List<T>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(Deposito<T> d, T a)
        {
            bool retorno = false;
            if (d._lista.Count == 0)
            {
                retorno = true;
            }
            else if (d._lista.Count < d._capacidadMaxima)
            {
                foreach (T item in d._lista)
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
        private int GetIndice(T a)
        {

            int i = -1;
            foreach (T item in this._lista)
            {
                i++;
                if (item.Equals(a))
                {
                    return i;

                }
            }
            return -1;
        }

        public static bool operator -(Deposito<T> d, T a)
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

        public bool Agregar(T a)
        {
            bool retorno = false;
            if (this + a)
            {
                retorno = true;

            }
            return retorno;
        }
        public bool Remover(T a)
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

            sb.AppendLine("Listado: ");
            foreach (T item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }

    }
}
