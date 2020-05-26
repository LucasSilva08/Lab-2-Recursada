using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados
{
    class Bicicleta
    {
        public Color micolor;
        public string dueño;

        public Bicicleta(string dueño)
        {
            this.dueño = dueño;

        }

        public Bicicleta(string dueño, Color colorDeLaBici)
        {
            this.dueño = dueño;
            this.micolor = colorDeLaBici;
        }
    }
}
