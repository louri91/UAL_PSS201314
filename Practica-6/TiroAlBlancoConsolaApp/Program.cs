using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TiroAlBancoModel;
using TiroAlBlancoConsolaApp.RecursosLocalizables;

namespace TiroAlBlancoConsolaApp
{
    class Program
    {
        private void AplicarIdioma()
        {
            string uno = StringResources.Gretting;
            string dos = StringResources.OpcionOne;
            string tres = StringResources.OpcionZero;
            string cuatro = StringResources.MissileSpeed;
            string cinco = StringResources.MissileAngle;
            string seis = StringResources.MissileLose;
            string siete = StringResources.MissileNumber;
            string ocho = StringResources.Win;
        }
        
        static void Main(string[] args)
        {
            int i=20;
            while (i > 0)
            {
                Console.WriteLine(StringResources.Gretting);
                Console.WriteLine(StringResources.OpcionOne);
                Console.WriteLine(StringResources.OpcionZero);
                i=Int32.Parse(Console.ReadLine());

                switch (i)
                {
                    case 0:
                        Console.Out.Close();
                        break;
                    case 1:
                        Console.Clear();
                        IObjetivo objetivo = TiroAlBlancoFactory.CrearObjetivoFijo();
                        IPartida partida=TiroAlBlancoFactory.CrearPartida(objetivo);
                        Console.WriteLine(StringResources.MissileSpeed);
                        int velocidad = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(StringResources.MissileAngle);
                        int angulo = Int32.Parse(Console.ReadLine());
                        IMisil misil = TiroAlBlancoFactory.CrearMisil(velocidad,angulo);
                        partida.DispararMisil(misil);
                        while (partida.ObjetivoAlcanzado == false) {
                            Console.WriteLine(StringResources.MissileLose + partida.DistanciaRelativaImpacto);
                            Console.WriteLine(StringResources.MissileNumber + partida.NumDisparos);
                            Console.WriteLine(StringResources.MissileSpeed);
                            velocidad = Int32.Parse(Console.ReadLine());
                            Console.WriteLine(StringResources.MissileAngle);
                            angulo = Int32.Parse(Console.ReadLine());
                            misil = TiroAlBlancoFactory.CrearMisil(velocidad, angulo);
                            partida.DispararMisil(misil);
                        }
                        Console.WriteLine(StringResources.Win+partida.DistanciaRelativaImpacto);
                        Console.WriteLine(StringResources.MissileNumber + partida.NumDisparos);
                        break;
                    default:
                        i = 1;
                        break;;
                }           
            }
        }
    }
}
