using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            string F="F";
            
            while (!F.Equals(Console.ReadLine()))
            {
                Console.Write("Hola Mundo \n" );
                Console.Write("Introduzca una F para salir \n");
            }   
        }
    }
}
