using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Goma:Utiles
    {
        public bool soloLapiz;

        public override bool PreciosCuidados { get {return true; } }

        public Goma():base()
        {

        }
        public Goma(bool soloLapiz,string marca,double precio):base(marca,precio)
        {
            this.soloLapiz = soloLapiz;
        }

        protected override string UtilesToString()
        {
            return base.UtilesToString()+"\nSolo Lapiz: "+this.soloLapiz;
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }
    }
}
