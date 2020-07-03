using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Entidades
{
    public class Lapiz:Utiles,ISerializa,IDeserializa
    {
        public ConsoleColor color;
        public ETipoTrazo trazo;

        public Lapiz():base()
        {

        }
        public Lapiz(ConsoleColor color, ETipoTrazo trazo,string marca,double precio):base(marca,precio)
        {
            this.color = color;
            this.trazo = trazo;
        }

        public override bool PreciosCuidados { get {return true; } }

        public string Path
        {
            get
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                path = path + @"\Silva.Lucas.Lapiz.xml";
                return path;
            }
        }

        protected override string UtilesToString()
        {
            return base.UtilesToString()+"\nColor: "+this.color+"\nTrazo: "+this.trazo;
        }
        public override string ToString()
        {
            return this.UtilesToString();
        }

        public bool Xml()
        {
            bool rta = false;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Lapiz));
                XmlTextWriter sw = new XmlTextWriter(this.Path, Encoding.UTF8);
                xs.Serialize(sw, this);
                sw.Close();
                rta = true;

            }
            catch(Exception)
            {

            }
            return rta;
        }

        bool IDeserializa.Xml(out Lapiz l)
        {
            l = null;
            bool rta = false;
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Lapiz));
                XmlTextReader sr = new XmlTextReader(this.Path);
                l = (Lapiz)xs.Deserialize(sr);
                sr.Close();
                rta = true;
            }
            catch(Exception)
            {

            }
            return rta;
        }
    }
}
