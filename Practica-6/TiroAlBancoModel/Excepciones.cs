using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroAlBancoModel
{
    public class Excepciones
    {
        public class AnguloMisilException : System.Exception
        {
            public AnguloMisilException() : base() { }
            public AnguloMisilException(string message) : base(message) { }
            public AnguloMisilException(string message, System.Exception inner) : base(message, inner) { }

            // A constructor is needed for serialization when an
            // exception propagates from a remoting server to the client. 
            protected AnguloMisilException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) { }
        }

        public class VelocidadMisilException : System.Exception
        {
            public VelocidadMisilException() : base() { }
            public VelocidadMisilException(string message) : base(message) { }
            public VelocidadMisilException(string message, System.Exception inner) : base(message, inner) { }

            // A constructor is needed for serialization when an
            // exception propagates from a remoting server to the client. 
            protected VelocidadMisilException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) { }
        }

        public class ObjetivoDistanciaException : System.Exception
        {
            public ObjetivoDistanciaException() : base() { }
            public ObjetivoDistanciaException(string message) : base(message) { }
            public ObjetivoDistanciaException(string message, System.Exception inner) : base(message, inner) { }

            // A constructor is needed for serialization when an
            // exception propagates from a remoting server to the client. 
            protected ObjetivoDistanciaException(System.Runtime.Serialization.SerializationInfo info,
                System.Runtime.Serialization.StreamingContext context) { }
        }
    }
}
