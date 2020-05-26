using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        #region
        private const int MEDIDA=330;
        private Tipo tipo;
        #endregion

        #region Constructor
        public Cerveza(int capacidadML,string marca,int contenidoML):base(marca,capacidadML,contenidoML)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML,string marca,Tipo tipo,int contenidoML):this(capacidadML,marca,contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodos
        public override int ServirMedida()
        {
            if(MEDIDA<=this.contenidoML)
            {
                this.Contenido = this.contenidoML - ((80 * MEDIDA) / 100);
            }
        }
        #endregion
    }
}
