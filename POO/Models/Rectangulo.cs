using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Rectangulo : Forma
    {
        protected double lado1;
        protected double lado2;

        public override double Area()
        {
            return lado1 * lado2;
        }

        public override double Perimetro()
        {
            return 2 * (lado1 + lado2);
        }

    }
}
