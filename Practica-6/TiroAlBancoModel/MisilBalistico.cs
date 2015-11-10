using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiroAlBancoModel
{
    public class MisilBalistico : Excepciones,IMisil
    {
        private double anguloSalida { get; set; }
        private double velocidadInicial { get; set; }
        private double alcance { get; set; }
 

        public MisilBalistico(double velocidad, double angulo)
        {
            if (angulo > -1 && angulo < 91)
            {
                this.anguloSalida = angulo;
            }
            else throw new Excepciones.AnguloMisilException();
            if (velocidad >= 0 && velocidad < 300000)
            {
                this.velocidadInicial = velocidad;
            }
            else throw new Excepciones.VelocidadMisilException();
            double VelocidadMS = velocidadInicial * 1000 / 3600;
            alcance = Math.Cos(anguloSalida * Math.PI / 180) * VelocidadMS * 2 * Math.Sin(anguloSalida * Math.PI / 180) * VelocidadMS / 9.81;
        }

        public double VelocidadInicial
            {
            get
            {
                return velocidadInicial;
            }
            set
            {
                velocidadInicial = VelocidadInicial;
            }
        }

        public double AnguloSalida
        {
            get
            {
                return anguloSalida;
            }
            set
            {
                anguloSalida = AnguloSalida;
            }
        }


        public double Alcance
        {
            get
            {
                return alcance;
            }
            set
            {
                this.alcance = Alcance;
            }
        }




    }
}
