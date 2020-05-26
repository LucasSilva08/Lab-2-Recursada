using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        #region Atributos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Constructor
        public Botella(string marca,int capacidadML,int contenidoML)
        {
            if(capacidadML<contenidoML)
            {
                this.contenidoML = capacidadML;
                this.capacidadML = capacidadML;
            }
            else
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }
            this.marca = marca;
        }
        #endregion

        #region Propiedades
        public int CapacidadLitros { get {return (this.capacidadML/1000); } }
        public int Contenido { get {return this.contenidoML; } set {this.contenidoML=value; } }
        public float PorcentajeContenido
        {
            get
            {
              return ((float)this.contenidoML*100)/this.capacidadML;
            }
        }
        #endregion

        #region Metodos
        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("CAPACIDAD: {0}ml\n", this.capacidadML);
            sb.AppendFormat("CONTENIDO: {0}ml\n", this.contenidoML);
            sb.AppendFormat("MARCA: {0}\n", this.marca);
            return sb.ToString();
        }
        #endregion

        #region SobreCargas
        public override string ToString()
        {
            return this.GenerarInforme();
        }                 
        
        #endregion
    }
}
