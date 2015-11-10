using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBancoModel
{
    public class Usuario : IUsuario
    {
        private string p;
        public string UsuarioId { get; set; }
        public Usuario(string p)
        {
            // TODO: Complete member initialization

            this.p = p;
            this.UsuarioId = p;
        }

        public Usuario()
        {
            UsuarioId = "Humano";
        }
       
    }
}
