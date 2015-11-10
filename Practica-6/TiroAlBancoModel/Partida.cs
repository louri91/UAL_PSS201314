using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBancoModel
{
    public class Partida : IPartida
    {
        public List<IMisil> disparos = new List<IMisil>();

        public int NumDisparos { get {
            return disparos.Count;} set { NumDisparos=disparos.Count;} }


        public int DistanciaRelativaImpacto
        {
            get
            {
                int valor = (int)disparos[disparos.Count - 1].Alcance;
                return (int)(Math.Abs(Objetivo.Distancia - valor));
            }
        }


        public IUsuario Usuario
        {
            get
            {
                return usuario;
            }
            set
            {
                this.Usuario = usuario;
            }
        }
        private IUsuario usuario = TiroAlBlancoFactory.CrearUsuario();


        public bool ObjetivoAlcanzado
        {
            get
            {
                if(Math.Abs(disparos[(disparos.Count)-1].Alcance-Objetivo.Distancia)==1.00)
                {
                    return true;
                }
                else return false;
            }
            set
            {
                ObjetivoAlcanzado = false;
            }
        }

        public IObjetivo Objetivo
        {
            get
            {
                return TiroAlBlancoFactory.CrearObjetivoFijo();
            }
        }


        public void DispararMisil(IMisil misil)
        {
            if (disparos != null)
            {
                disparos.Add(misil);
            }
            else {
                disparos = new List<IMisil>();
                disparos.Add(misil);
            }
        }

        public Partida() {
            IMisil misil = TiroAlBlancoFactory.CrearMisil(13,13);
            IObjetivo objetivo = TiroAlBlancoFactory.CrearObjetivoFijo();
            DispararMisil(misil);
        }

        public Partida(IObjetivo objetivo)
        {
            // TODO: Complete member initialization
            IObjetivo Objetivo = TiroAlBlancoFactory.CrearObjetivoFijo();
        }

       
    }
    
}
