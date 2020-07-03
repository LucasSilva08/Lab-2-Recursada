﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sacapunta:Utiles
    {
        public bool deMetal;

        public override bool PreciosCuidados { get {return false; } }

        public Sacapunta():base()
        {

        }
        public Sacapunta(bool deMetal,double precio,string marca):base(marca,precio)
        {
            this.deMetal = deMetal;
        }
    }
}
