using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Autentificador
{
    public class AutentificacionExcepcion : Exception
    {
        public CodigoAutentificacion Codigo { get; set; }
        public AutentificacionExcepcion () : base() { }
        public AutentificacionExcepcion(CodigoAutentificacion codigo) : base() {
            Codigo = codigo;
        }
        public AutentificacionExcepcion (string message) : base(message) { }
        public AutentificacionExcepcion (string message, System.Exception inner) : base(message, inner) { }

        // A constructor is needed for serialization when an
        // exception propagates from a remoting server to the client. 
        protected AutentificacionExcepcion(System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) { } 

    }

}
