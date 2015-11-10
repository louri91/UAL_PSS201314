using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    public class Carton3
    {
        public Linea primera;
        public Linea segunda;
        public Linea tercera;

        public Carton3()
        {
            this.primera = new Linea(1);
            this.segunda = new Linea(2);
            this.tercera = new Linea(3);
        }
        public bool TacharBola(Bola bola)
        {
            if (primera.Bolas.Contains(bola)) 
            {
                primera.TacharBola(bola);
                return true;
            }
            if (segunda.Bolas.Contains(bola))
            {
                segunda.TacharBola(bola);
                return true;
            }
            if (tercera.Bolas.Contains(bola))
            {
                segunda.TacharBola(bola);
                return true;
            }
            return false;
        }
        public int PremioLinea()
        {
            if (primera.Bolas.Count == 0 ||
                segunda.Bolas.Count == 0 ||
                tercera.Bolas.Count == 0)
            {
                return 1;
            }
            else if (primera.Bolas.Count == 0 &&
                segunda.Bolas.Count == 0 &&
                tercera.Bolas.Count == 0)
            {
                return 0;
            }
            return -1;
        }
    }  
}
