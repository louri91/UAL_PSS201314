using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_9
{
    public class Conexion
    {
        public int Id { get; set; }

        public string IP { get; set; }

        public DateTime FechaInicio { get; set; }

        public int Duracion { get; set; }

        public int UsuarioCategoriaId { get; set; }
    }
}
