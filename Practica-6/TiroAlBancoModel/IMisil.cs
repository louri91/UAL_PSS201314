using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TiroAlBancoModel
{
    public interface IMisil
    {
        double VelocidadInicial { get; set; }
        double AnguloSalida { get; set; }
        double Alcance { get; set; }
    }
}
