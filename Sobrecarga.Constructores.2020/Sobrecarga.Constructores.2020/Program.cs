using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos.Constructores._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            Auto a1 = new Auto();
            Auto a2 = new Auto(ConsoleColor.Black);
            Auto a3 = new Auto(ConsoleColor.Cyan, EMarcas.Ford);
            Auto a4 = new Auto(4, ConsoleColor.Green, EMarcas.Fiat);
            Auto a5 = new Auto();



            Console.WriteLine(Auto.Mostrar(a1));
            Console.WriteLine(Auto.Mostrar(a2));
            Console.WriteLine(Auto.Mostrar(a3));
            Console.WriteLine(Auto.Mostrar(a4));

            Auto.DiferenciaEntreInstancias();


            Console.ReadLine();
        }
    }
}
