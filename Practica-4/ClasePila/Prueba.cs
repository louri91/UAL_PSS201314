using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    class Prueba
    {
        static void Main(string[] args)
        {
            Pila a = new Pila();
            a.push(1);
            a.push(3);
            a.push(5);/*
           // a.push(7);
            //a.push(9);*/
           /* a.espejo(a);
            Console.WriteLine("Pila Actual \n");
            Console.Read();
            */
            a.contenidoPila();
            
            Console.Read();
            Console.WriteLine(a.pop());
            Console.WriteLine(a.pop());
            Console.WriteLine(a.pop());
            a.contenidoPila();
            Console.Read();
        }
    }
}
