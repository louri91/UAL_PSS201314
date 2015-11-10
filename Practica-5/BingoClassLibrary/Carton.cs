using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bingo
{
    public class Carton
    {
        HashSet<Bola> _bolas;
        public int NumeroBolas { get; set; }
        public int numeroBolasSinTachar { get { return _bolas.Count; } }
        public Carton()
        {
            _bolas = new HashSet<Bola>();
            Rellenar();
        }
        private void Rellenar()
        {
            Random ramdom = new Random(DateTime.Now.Millisecond);
            do
            {
                Bola bola = new Bola();
                int numAleatorio = ramdom.Next(1, 90);
                bola.Numero = numAleatorio;
                _bolas.Add(bola);
            }
            while (_bolas.Count < 15);
        }
        public void TacharBola(Bola bola)
        {
            _bolas.Remove(bola);
        }
        public int NumeroBolasSinTachar(Bombo bombo)
        {
            return bombo.Bolas.Intersect(this._bolas).Count();
        }
    }
}
