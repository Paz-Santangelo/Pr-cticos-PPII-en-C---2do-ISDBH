using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Models
{
    public interface IVehiculo
    {
        void Conducir();
        bool Cargar(int cantidadGasolina);
    }
}
