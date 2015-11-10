using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autentificador
{
    public interface IAutentificacion
    {
        /// <summary>
        /// Su finalidad es comprobar que el usuario está autentificado.
        /// </summary>
        /// <param name="userName"> Clave primaria = UsuarioId</param>
        /// <param name="passWord"> Palabra de paso </param>
        /// <returns> Devuelve el código de autentificación </returns>
        CodigoAutentificacion EsUsuarioAutentificado(string UsuarioId, string PalabraPaso);
    }
}
