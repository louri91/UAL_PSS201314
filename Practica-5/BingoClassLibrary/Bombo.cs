using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo
{
    public class Bombo
    {
        public HashSet<Bola> Bolas = new HashSet<Bola>();
        private int _numeroBolas;
        public int NumeroBolas { get { return Bolas.Count; } set { _numeroBolas = value; } }
        public void MeterBola(Bola bola)
        {
            Bolas.Add(bola);
        }
        public bool EstaBola(Bola bola)
        {
            return Bolas.Contains(bola);
        }

        public void SacarBola(Bola bola)
        {
            if (EstaBola(bola)) Bolas.Remove(bola);
            else throw new ArgumentOutOfRangeException("Out of Range Index");
        }

        public Bola ElegirBola()
        {
            if (NumeroBolas <= 0) throw new ArgumentOutOfRangeException();
            Random ramdom = new Random(DateTime.Now.Millisecond);
            Bola bola = new Bola();
            do
            {
                int numAleatorio = ramdom.Next(1, 90);
                bola.Numero = numAleatorio;
            }
            while (!EstaBola(bola));
            return bola;
        }

        public void Rellenar()
        {
            for (int nb = 1; nb < 91; nb++)
            {
                Bola bola = new Bola();
                bola.Numero = nb;
                Bolas.Add(bola);
            }
        }
    }
}
