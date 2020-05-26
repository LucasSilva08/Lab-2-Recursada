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

        public DepositoDeCocinas(int capacidad)
        {
            this._lista = new List<Cocina>();
            this._capacidadMaxima = capacidad;
        }

        public static bool operator +(DepositoDeCocinas d, Cocina a)
        {
            bool retorno = false;
            if (d._lista.Count == 0)
            {
                retorno = true;
            }
            else if (d._lista.Count < d._capacidadMaxima)
            {
                foreach (Cocina item in d._lista)
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
        private int GetIndice(Cocina a)
        {

            int i = -1;
            foreach (Cocina item in this._lista)
            {
                i++;
                if (item.Equals(a))
                {
                    return i;

                }
            }
            return -1;
        }
        public static bool operator -(DepositoDeCocinas d, Cocina a)
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
        public bool Agregar(Cocina a)
        {
            bool retorno = false;
            if (this + a)
            {
                retorno = true;

            }
            return retorno;
        }
        public bool Remover(Cocina a)
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
            sb.AppendLine("Listado de Cocinas: ");
            foreach (Cocina item in this._lista)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();

        }
    }
}
