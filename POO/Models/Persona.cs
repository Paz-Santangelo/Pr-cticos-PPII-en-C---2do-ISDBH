using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    internal class Persona
    {
        protected string Nombre { get; set; }
        protected int Edad { get; set; }

        public void setNombre(string nombre)
        {
            this.Nombre = nombre;
        }

        public void setEdad(int edad)
        {
            this.Edad = edad;
        }

        public void Saludar()
        {
            Console.WriteLine("¡Hola!");
        }
    }
}
