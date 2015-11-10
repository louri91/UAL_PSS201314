using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica_9;

namespace PruebaConsultas
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Primera Consulta
            UserData datos = new UserData();
            datos.CargarDatos();
            Consultas consulta = new Consultas();
            int id = 1;
            Console.WriteLine("Consulta 1");
            IQueryable<vmNombre> nombre = consulta.UsuariosEnCategoria(id);

            foreach( var T in nombre){
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();
            ///Segunda Consulta
            Console.WriteLine("Consulta 2");
            IQueryable<vmNombre> consulta2 = consulta.UsuariosEnCategoria("Alumno");

            foreach (var T in consulta2)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            ///Tercera Consulta
            Console.WriteLine("Consulta 3");
            IQueryable<vmNombre> consulta3 = consulta.UsuariosConNombreComienza("Ju");

            foreach (var T in consulta3)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            ///Cuarta Consulta
            Console.WriteLine("Consulta 4");
            IQueryable<vmNombre> consulta4 = consulta.UsuariosConNombreComienzaEnCategoria("An","Al");

            foreach (var T in consulta4)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            ///Quinta Consulta
            Console.WriteLine("Consulta 5");
            IQueryable<vmNombre> consulta5 = consulta.UsuariosConectadosIP("193.161.134.18");

            foreach (var T in consulta5)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            //Sexta Consulta
            Console.WriteLine("Consulta 6");
            IQueryable<vmNombre> consulta6 = consulta.EncontrarUsuarioAppEmail(" ", "Juan.pss-2@ual.es");

            foreach (var T in consulta6)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            //Septima Consulta
            Console.WriteLine("Consulta 7");
            IQueryable<vmCategoriaNombre> consulta7 = consulta.ListaParCategoriaUsuarioParaApp("Excel");

            foreach (var T in consulta7)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();

            //Septima Consulta
            Console.WriteLine("Consulta 8");
            IQueryable<vmCategoriaNombre> consulta8 = consulta.AgrupacionUsuariosCategorias();

            foreach (var T in consulta8)
            {
                Console.WriteLine(T.toStringName());
            }
            Console.ReadLine();
        }
    }
}
