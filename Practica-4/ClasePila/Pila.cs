using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila
{
    public class Pila
    {
        public ArrayList miembros = new ArrayList();

        public Pila(int n)
        {
            if (n >= 0) 
            {
                for (int x = 0; x <= n; x++) miembros.Add(0);
            }
            else throw new Exception("El tamaño de la pila no puede ser negativo");
        }

        public Pila()
        {
            this.miembros = new ArrayList();
        }

        public bool esVacia() 
        {
            bool compr=false;
            if (miembros.Count == 0) return true;
            for (int x = 0; x < tamaño(); x++) 
            {
                if ((int)miembros[x] == 0) compr = true;
            }
            return compr;
        }

        public int tamaño()
        {
            return miembros.Count;
        }
        
        public void push(int n)
        {
            miembros.Add(n);
            invertir(this.miembros);
        }

        public void contenidoPila()
        {
            for (int iterador = 0; iterador < this.tamaño(); iterador++)
            {
                Console.WriteLine("Elemento en la posicion: " + iterador +
                    " Elemento: " + this.miembros[iterador] + "\n");
            }
            Console.Read();
        }

        public bool pop()
        {
            if (!this.esVacia())
            {
                miembros[0] = 0;
                miembros.RemoveAt(0);
                return true;
            }
            return false;
        }



        public void invertir(ArrayList pila)
        {
            this.miembros.Reverse();
        }

        public int peek(ArrayList Pila) 
        {
            return (int)miembros[0];
        }
    }
}
