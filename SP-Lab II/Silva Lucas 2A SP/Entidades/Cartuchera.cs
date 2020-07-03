using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cartuchera<T>where T:Utiles
    {
        protected int capacidad;
        protected List<T> elementos;

        public List<T> MyProperty { get {return this.elementos; } }
        public double PrecioTotal
        {
            get
            {
                double contador=0;
                foreach(T f in this.elementos)
                {
                    contador += f.precio;
                }
                return contador;
            }
        }
        
        public Cartuchera()
        {
            this.elementos = new List<T>();
        }
        public Cartuchera(int capacidad):this()
        {
            this.capacidad = capacidad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CARTUCHERA | Capacidad: " + this.capacidad + " | Cant: " + this.elementos.Count + " | Precio Total: " + this.PrecioTotal);
            foreach(T f in this.elementos)
            {
                sb.AppendLine(f.ToString());
            }
            return sb.ToString();
        }

        public static Cartuchera<T> operator+(Cartuchera<T> c,T u)
        {
            if(c.elementos.Count+1<=c.capacidad)
            {
                c.elementos.Add(u);
            }
            else
            {
                throw new CartucheraLlenaException();
            }
            return c;
        }
    }
}
