using POO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Saludar();

            Console.WriteLine("\nESTUDIANTE:");
            Estudiante estudiante = new Estudiante();
            estudiante.setNombre("Paz");
            estudiante.setEdad(35);
            estudiante.Saludar();
            estudiante.VerNombre();
            estudiante.VerEdad();
            estudiante.Estudiar();

            Console.WriteLine("\nPROFESOR:");
            Profesor profesor = new Profesor();
            profesor.setNombre("Narciso");
            profesor.setEdad(40);
            profesor.Saludar();
            profesor.Explicar();

            Console.WriteLine("\nTAREA DE CLASE COCHE CON INTERFACE VEHICULO");
            Coche miCoche = new Coche(0);
            Console.Write("Ingrese la cantidad de gasolina que desea agregar a su auto: ");
            int cantidadGasolina = int.Parse(Console.ReadLine());

            miCoche.Cargar(cantidadGasolina);
            miCoche.Conducir();


            Console.ReadKey();
        }
    }
}
