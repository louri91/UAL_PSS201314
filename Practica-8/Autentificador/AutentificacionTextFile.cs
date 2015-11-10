using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using BindingCollection;

namespace Autentificador
{
    public class AutentificacionTextFile : IAutentificacion {
        private string p;

        public AutentificacionTextFile(string textFile, FormatoRegistro formatoRegistro, string finCampo) {
            string line;
            //Regex r = new Regex("(;)");
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(textFile);
            while ((line = file.ReadLine()) != null)
            {
                UsuarioView a=decodificarLinea(line,finCampo);    
            }

            file.Close();
        }

        private UsuarioView decodificarLinea(string line,string finCampo)
        {
            FormatoRegistro _formato = new FormatoRegistro(new CamposRegistro [] {CamposRegistro.Nombre,CamposRegistro.Id,CamposRegistro.PalabraPaso,CamposRegistro.Categoria,CamposRegistro.EsValido});
            Regex r = new Regex(finCampo);
            int indexcampo=0;
            String[] use = r.Split(line);
            CamposRegistro campo = _formato.CamposRegistro[indexcampo];
            UsuarioView user = new UsuarioView();
            /*for (int campo = 0; campo < use.Length; campo++) {
                if (campo == 0) user.Nombre = use[campo];
                if (campo == 1) user.Id = use[campo];
                if (campo == 2) user.PalabraPaso = use[campo];
                if (campo == 3) user.Categoria = use[campo];
                //if (campo == 4) user.PalabraPaso = use[campo];
            }*/
            return user;
        }

        public AutentificacionTextFile(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public CodigoAutentificacion EsUsuarioAutentificado(string p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void ModificarUsuario(string p, BindingCollection.UsuarioView user)
        {
            throw new NotImplementedException();
        }

        public void GuardarDatos(string ficheroModificado)
        {
            throw new NotImplementedException();
        }
    }
}
