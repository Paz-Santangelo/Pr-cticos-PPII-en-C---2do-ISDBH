using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal class Circulo : Forma
    {
        protected double radio;

        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }
    }
}
