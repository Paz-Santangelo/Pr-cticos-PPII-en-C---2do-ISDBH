using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal class Estudiante : Persona
    {
        public void Estudiar ()
        {
            Console.WriteLine("Estoy estudiando.");
        }

        public void VerNombre()
        {
            Console.WriteLine($"Mi nombre es {Nombre}");
        }

        public void VerEdad()
        {
            Console.WriteLine($"Mi edad es: {Edad} años.");
        }

    }
}
