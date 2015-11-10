using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroAlBancoModel
{
    public class TiroAlBlancoFactory
    {
        public static IMisil CrearMisil(double p1, double p2)
        {
            return new MisilBalistico(p1,p2);
        }

        public static IObjetivo CrearObjetivoFijo(double p)
        {
            return new Objetivo(p);
        }

        public static IObjetivo CrearObjetivoFijo()
        {
            return new Objetivo();
        }

        public static IUsuario CrearUsuario()
        {
            return new Usuario();
        }

        public static IUsuario CrearUsuario(String p)
        {
            return new Usuario(p);
        }

        public static IPartida CrearPartida()
        {
            return new Partida();
        }

        public static IPartida CrearPartida(IObjetivo objetivo)
        {
            return new Partida(objetivo);
        }
    }
}
