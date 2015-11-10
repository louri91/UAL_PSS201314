using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica_9
{
    public class vmCategoriaNombre
    {
        public string nombre { get; set; }
        public string categoria { get; set; }

        public string toStringName()
        {
            return nombre.ToString() + " " + categoria.ToString();
        }
    }
}
