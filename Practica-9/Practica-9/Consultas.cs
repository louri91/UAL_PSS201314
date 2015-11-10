using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_9
{
    public class Consultas
    {
                //************** Usuarios ********************************
        /// <summary>
        /// Usuarios que pertenecen a la categoria cuyo codigo es categoriaId
        /// </summary>
        /// <param name="categoriaId"> Id de la categoria</param>
        /// <returns> Lista ordenada alfabéticamente de los nombres de ls usuarios en mayúsculas</returns>
        public IQueryable<vmNombre> UsuariosEnCategoria(int categoriaId)
        {
            UserData datos = new UserData();
            datos.CargarDatos();
            var vv = from usuario in datos.Usuarios join userCat in datos.UsuariosCategorias on                 categoriaId equals userCat.CategoriaId where userCat.Id==usuario.Id orderby                     usuario.NombreUsuario ascending select new vmNombre {nombre =                                                                   usuario.NombreUsuario.ToUpper()};
            return vv.AsQueryable();

            
        }
        /// <summary>
        /// Usuarios que pertenecen a la categoria nombreCategoria
        /// </summary>
        /// <param name="nombreCategoria"> Nombre de la categoria</param>
        /// <returns> Lista ordenada alfabéticamente de los nombres de ls usuarios en mayúsculas</returns>
        public IQueryable<vmNombre> UsuariosEnCategoria(string nombreCategoria)
        {
            UserData datos = new UserData();
            datos.CargarDatos();
            var vv = from categoria in datos.Categorias
                         where categoria.NombreCategoria==nombreCategoria
                         join usCa in datos.UsuariosCategorias on 
                             categoria.Id equals usCa.CategoriaId
                             join user in datos.Usuarios on
                                 usCa.UsuarioId equals user.Id orderby                   user.NombreUsuario ascending select new vmNombre { nombre = user.NombreUsuario.ToUpper() };
            return vv.AsQueryable();
        }
        /// <summary>
        /// Usuarios cuyo nombre comienza por cadenaComienzo
        /// </summary>
        /// <param name="cadenaComienzo">cadena de comienzo del nombre</param>
        /// <returns> Lista de los nombres de ls usuarios en mayúsculas</returns>
        /// 
         public IQueryable<vmNombre> UsuariosConNombreComienza(string cadenaComienzo)
         {
             UserData datos = new UserData();
             int cad = cadenaComienzo.Count()-1;
             datos.CargarDatos();
        
             var vv = from user in datos.Usuarios
                      where
                          cadenaComienzo[cad] == user.NombreUsuario[cad]
                      orderby user.NombreUsuario ascending
                      select new vmNombre { nombre = user.NombreUsuario.ToUpper() };
             return vv.AsQueryable();
         }
         /// <summary>
         /// Usuarios cuyo nombre comienza por cadenaComienzo que pertenecen a una categoria dada
         /// </summary>
         /// <param name="categoria">nombre de la caegoria</param>
         /// <param name="cadenaComienzo">cadnea de comienzo del nombre</param>
         /// <returns> Lista ordenada alfabéticamente de los nombres de ls usuarios en mayúsculas</returns>
        
        public IQueryable<vmNombre> UsuariosConNombreComienzaEnCategoria(string cadenaComienzo,
        string categoria)
        {
            UserData datos = new UserData();
            datos.CargarDatos();
            int cad = cadenaComienzo.Count() - 1;
            int dac = categoria.Count() - 1;

            var query = from cat in datos.Categorias where cat.NombreCategoria[dac] == categoria[dac]
                        join usCat in datos.UsuariosCategorias on cat.Id equals usCat.CategoriaId
                        join us in datos.Usuarios on usCat.UsuarioId equals us.Id
                        orderby us.NombreUsuario ascending
                        select new vmNombre { nombre = us.NombreUsuario };
            var query2 = from da in query where da.nombre[cad] == cadenaComienzo[cad] select new vmNombre { nombre = da.nombre.ToUpper() };
            return query2.AsQueryable();

        }
        /// <summary>
        /// Usuarios conectados desde una IP
        /// </summary>
        /// <param name="ip">ip de la conexion</param>
        /// <returns> Lista de los nombres de los usuarios en mayúsculas</returns>
        
        public IQueryable<vmNombre> UsuariosConectadosIP(string ip)
        {
            UserData datos = new UserData();
            datos.CargarDatos();
            var query = from conex in datos.Conexiones where ip==conex.IP
                        join usCat in datos.UsuariosCategorias on conex.UsuarioCategoriaId equals usCat.Id
                        join us in datos.Usuarios on usCat.UsuarioId equals us.Id
                        orderby us.NombreUsuario ascending
                        select new vmNombre { nombre = us.NombreUsuario };
            return query.AsQueryable();
        }
        /// <summary>
        /// Encuentra el nombre del usuario de una aplicación dada a través de su e-mail
        /// </summary>
        /// <param name="Aplicacion"> cadena con el nombre de la aplicación</param>
        /// <param name="email">cadena con el e-mail</param>
        /// <returns> Nombre del Usuario o null si no se encuentra</returns>
        
         public IQueryable<vmNombre> EncontrarUsuarioAppEmail(string aplicacion, string email)
         {
             UserData datos = new UserData();
             datos.CargarDatos();
             var query = from app in datos.Aplicaciones where aplicacion == app.NombreAplicacion
                             from per in datos.Personales 
                         from us in datos.Usuarios
                         where app.Id == per.AplicacionId
                              && per.Email.Equals(email) && per.UsuarioId == us.Id
                         orderby  us.NombreUsuario ascending
                         select new vmNombre { nombre = us.NombreUsuario };
             if (query != null) {
                 return query.AsQueryable();
             }
             return null;
         }
        
         //********** Categorias ***************
         /// <summary>
         /// Lista de pares (Categoria,Usuario) para una aplicación dada
         /// </summary>
         /// <param name="aplicación">nombre de la aplicación</param>
         /// <returns>Lista de pares (nombre de categoria y nombre de Usuario)</returns>
         public IQueryable<vmCategoriaNombre> ListaParCategoriaUsuarioParaApp(string aplicacion)
         {
             UserData datos = new UserData();
             datos.CargarDatos();

             var query = from app in datos.Aplicaciones where aplicacion == app.NombreAplicacion 
                         join us in datos.Usuarios on app.Id equals us.AplicacionId 
                         join usCat in datos.UsuariosCategorias on us.Id equals usCat.UsuarioId
                         join categoria in datos.Categorias on usCat.CategoriaId equals categoria.Id
                         select new vmCategoriaNombre { nombre = us.NombreUsuario.ToUpper(), categoria = categoria.NombreCategoria.ToUpper() };

             return query.AsQueryable();

         }
        
         /// <summary>
         /// Lista de Usuarios agrupados en lista de categorias (un mismo usuario puede estar en dos categorias)
         /// </summary>
         /// <returns> Lista de nombres de usuario agrupados para cada categoria (de otra lista) </returns>
         public IQueryable<vmCategoriaNombre>  AgrupacionUsuariosCategorias() 
         {
             UserData datos = new UserData();
             datos.CargarDatos();

             var query = from categoria in datos.Categorias
                         orderby categoria.NombreCategoria descending
                         join usCat in datos.UsuariosCategorias on categoria.Id equals usCat.CategoriaId
                         join us in datos.Usuarios on usCat.UsuarioId equals us.Id
                         select new vmCategoriaNombre { nombre = us.NombreUsuario, categoria = categoria.NombreCategoria };
             
             return query.AsQueryable();
         }
         /// <summary>
         /// Relacion de Usuarios agrupados en categorias ordenadas éstas en orden descendente alfabéticamente
         ///(un mismo puede aparecer varias veces si esta en varias categorias)
         /// </summary>
         /// <returns> Lista agrupada de usuarios por categorias </returns>
        /*
        public IQueryable<vmCategoriaNombre> AgrupacionUsuariosCategoriasOrdenadas()
         {

         }
         /// <summary>
         /// Categoria con mayor numero de usuarios y total
         /// </summary>
         /// <returns>Devuelve nombre de la categoria con más usurios y el numero de usuarios</returns>
        /*
        public IQueryable<vmCategoriaNombre> CategoriaMaximoNumeroUsuarios()
         //CategoriaConMayorNumeroUsuariosConectados()
         {
         }
         /// <summary>
         /// Todas las categorias de usuarios para una aplicación dada
         /// </summary>
         /// <param name="aplicacion"> nombre de la aplicación</param>
         /// <returns>Lista de los nombres de las categorias de usuarios</returns>
         public IQueryable<vmCategoriaNombre> TodasCategoriasApp(string aplicacion)
         {
         }
         /// <summary>
         /// Lista de Categoria/Aplicación para un usuario dado
         /// </summary>
         /// <param name="usuario">nombre del usuario</param>
         /// <returns>Lista de pares (nombre de categoria y nombre de aplicación)</returns>
         public IQueryable<vmCategoriaNombre> CategoriasAplicacionParaUsuario(string usuario)
         {
         }
         //********************* agrupaciones ********************
         /// <summary>
         /// ¿Desde que IP ha habido más conexiones y cuantas para una categoria dada?
         /// </summary>
         /// <returns>Lista con la IP y el número de conexiones</returns>
         public IQueryable<vmNombreCantidad> IPconMasConexionesSegunCategoria(string nombreCategoria)
         {
         }
         /// <summary>
         /// Secuencia de pares (usuarios, suma total duración de conexion) ordenados de mayor a menor duración/// </summary>
         /// <returns>Lista de pares NombreUsuario, suma de la duración de las conexiones</returns>
         public IQueryable<vmNombreCantidad> UsuarioSumaDuracionConexiones()
         {
         }
         /// <summary>
         /// LEFT OUTER JOIN
         /// Secuencia de pares (usuarios, suma total de duración de conexiones) ordenados de menor a mayor duración
         /// Usuarios que no se hayan conectado nunca deberán aparecer con una cantidad de 0
         /// </summary>
         /// <returns>Lista de pares NombreUsuario, total suma de duración de conexiones</returns>
         public IQueryable<vmNombreCantidad> UsuarioSumaDuracionConexionesNulos()
         {
         }
         /// <summary>
         /// LEFT OUTER JOIN
         /// Relacion de usuarios cuya suma total de duración de conexión sea superior a la media.
         /// </summary>
         /// <returns>Lista con el nombre de usuario y suma total de duracion de conexiones</returns>
         public IQueryable<vmNombreCantidad> UsuariosSumaDuracionMayorMedia1()
         {
         }
         /// <summary>
         /// LEFT OUTER JOIN
         /// Relacion de usuarios cuya suma total de duración de conexión sea superior a la media.
         /// </summary>
         /// <returns>Lista con el nombre de usuario y suma total de duracion de conexiones</returns>
         public IQueryable<vmNombreCantidad> UsuariosSumaDuracionMayorMedia()
         {
         }
         /// <summary>
         /// Relacion de aplicaciones y su respectiva suma de tiempos de conexión de todos los usuarios
         /// </summary>
         /// <returns>Lista con el nombre de aplicacion y suma total de duracion de conexiones</returns>
         public IQueryable<vmNombreCantidad> AplicacionesMasUsadas()
         {
         }
         /// <summary>
         /// Relacion de aplicaciones y su respectiva suma de tiempos de conexión de todos los usuarios (ordenas de mayor a menor)
         /// </summary>
         /// <returns>Lista con el nombre de aplicacion y suma total de duracion de conexiones</returns>
         public IQueryable<vmNombreCantidad> AplicacionesMasUsadasOrdenadas()
         {
         }*/

    }
}
