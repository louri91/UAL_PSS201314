using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBancoModel
{
    public interface IPartida
    {
        IUsuario Usuario { get; set; }

        IObjetivo Objetivo { get;}

        void DispararMisil(IMisil misil);

        int NumDisparos { get; set; }

        int DistanciaRelativaImpacto { get;}

        bool ObjetivoAlcanzado { get; set; }
    }
}
