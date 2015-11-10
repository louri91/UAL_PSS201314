using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroAlBancoModel
{
    class Objetivo : Excepciones,IObjetivo
    {
        private double distancia;

        public Objetivo(double dist)
        {
            if (dist >= 0 && dist < 20001)
            {
                this.distancia = dist;
            }
            else throw new Excepciones.ObjetivoDistanciaException();
        }

        public Objetivo()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            this.distancia = r.Next(1,20000);
        }


        public double Distancia
        {
            get
            {
                return distancia;
            }
            set
            {
                this.distancia = value;
            }
        }
    }
}
