using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public class Coche : IVehiculo
    {
        private int Gasolina;

        public Coche(int gasolinaInicial)
        {
            Gasolina = gasolinaInicial;
        }

        public void Conducir ()
        {
            if(Gasolina > 0)
            {
                Console.WriteLine("\nEl coche está conduciendo.");
                Gasolina--;
            } else
            {
                Console.WriteLine("\nNo hay suficiente gasolina para conducir");
            }
        }

        public bool Cargar(int cantidadGasolina)
        {
            if(cantidadGasolina > 0)
            {
                Gasolina += cantidadGasolina;
                Console.WriteLine($"\nAgregaste {cantidadGasolina} unidades de gasolina. Ahora tenés {Gasolina} unidades.");
                return true;
            } else
            {
                Console.WriteLine("\nNo se puede agregar una cantidad negativa o nula de gasolina.");
                return false;
            }
        }
    }
}
