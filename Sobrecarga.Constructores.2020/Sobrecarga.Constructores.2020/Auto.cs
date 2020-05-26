using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2020
{
    class Auto
    {
        #region Atributos

        #region De Instancia

        public int cantRuedas;
        private ConsoleColor color;
        private EMarcas marca;
        
        #endregion

        #region De Clase

        private static DateTime fechaCreacion;
        public static int cantidadObj;
        public static DateTime fechaUltimaInstancia;
        #endregion

        #endregion

        #region Métodos

        #region De Instancia

        private string Mostrar()
        {
            return this.cantRuedas.ToString() + " - " + this.marca.ToString() + " - " + this.color.ToString() + "\n";
        }

        #endregion

        #region De Clase

        public static string Mostrar(Auto a)
        {
            return a.Mostrar();
        }

        public static void DiferenciaEntreInstancias() 
        {
           TimeSpan dif =  Auto.fechaUltimaInstancia - Auto.fechaCreacion;

           Console.WriteLine(dif.TotalSeconds);
        }

        #endregion

        #endregion

        #region Contructor

        #region De Clase
        static Auto()
        {
            Auto.cantidadObj = 0;
            Auto.fechaCreacion = DateTime.Now;
        }

        #endregion
        
        //Requerimiento:
        //Cualquier instancia (objeto) debe tener los siguientes valores predeterminados:
        //*-cantRuedas -> 4
        //*-color -> white
        //*-marca -> sin marca

        #region De Instancia
        public Auto()
        {
            this.cantRuedas = 4;
            this.marca = EMarcas.Sin_Marca;
            this.color = ConsoleColor.White;

            Auto.cantidadObj++;
            Auto.fechaUltimaInstancia = DateTime.Now;
        }
        public Auto(ConsoleColor color) : this()
        {
            //this.cantRuedas = 4;
            //this.marca = EMarcas.Sin_Marca;
            this.color = color;

            //Auto.cantidadObj++;
            //Auto.fechaUltimaInstancia = DateTime.Now;
        }
        public Auto(ConsoleColor color, EMarcas marca):this(color) 
        {
            //this.cantRuedas = 4;
            this.marca = marca;
            //this.color = color;

            //Auto.cantidadObj++;
            //Auto.fechaUltimaInstancia = DateTime.Now;
        }
        //Excepción a la regla.
        public Auto(int cantRuedas, ConsoleColor color, EMarcas marca):this(color, marca)
        {
            this.cantRuedas = cantRuedas;
            //this.marca = marca;
            //this.color = color;

            //Auto.cantidadObj++;
            //Auto.fechaUltimaInstancia = DateTime.Now;
        }

        #endregion

        #endregion

        #region destructor?

        ~Auto() 
        {
            System.Diagnostics.Trace.WriteLine(this.Mostrar());
        }

        #endregion
    }
}
