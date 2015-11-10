using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Linea
    {
        HashSet<Bola> _bolas=new HashSet<Bola>();
        public HashSet<Bola> Bolas
        {
            get { return _bolas; }
            set { _bolas = value; }
        }
 
        public Linea(int posicion) 
        {
            _bolas = new HashSet<Bola>();
            this.Rellenar(posicion);
        }
        private void Rellenar(int posicion)
        {
            if (posicion == 1)
            {
                for (int ball = 1; _bolas.Count < 5; ball++)
                {
                    Random ramdom = new Random(DateTime.Now.Millisecond);
                    int numAleatorio = ramdom.Next(1, 30);
                    Bola bola = new Bola();
                    bola.Numero = numAleatorio;
                    _bolas.Add(bola);
                }
            }
            if (posicion == 2)
            {
                for (int ball = 1; _bolas.Count < 5; ball++)
                {
                    Random ramdom = new Random(DateTime.Now.Millisecond);
                    int numAleatorio = ramdom.Next(30,60);
                    Bola bola = new Bola();
                    bola.Numero = numAleatorio;
                    _bolas.Add(bola);
                }
            }
            if (posicion == 3)
            {
                for (int ball = 1; _bolas.Count < 5; ball++)
                {
                    Random ramdom = new Random(DateTime.Now.Millisecond);
                    int numAleatorio = ramdom.Next(60, 90);
                    Bola bola = new Bola();
                    bola.Numero = numAleatorio;
                    _bolas.Add(bola);
                }
            }
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
