using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BindingCollection
{

    public interface IUsuarioView
    {
        string Id { get; set; }
        string Nombre { get; set; }
        string PalabraPaso { get; set; }
        string Categoria { get; set; }
        Boolean esValido { get; set; }
    }
}
