using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_9
{
    public class Personal
    {
        public int UsuarioId { get; set; }

        public int Id { get; set; }

        public int AplicacionId { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public bool EstaBloqueado { get; set; }

        public DateTime FechaAlta { get; set; }
    }
}
