using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto
    {
        private string _marca;
        private string _color;

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool retorno = false;
            if (a._color == b._color && a._marca == b._marca)
            {
                retorno = true;
            }
            return retorno;

        }
        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auto)
            {
                if (((Auto)obj) == this)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public override string ToString()
        {
            return String.Format("Marca: {0} - Color: {1}", this._marca, this._color);
        }
        public string Color { get { return this._color; } }
        public string Marca { get { return this._marca; } }
    }
}

