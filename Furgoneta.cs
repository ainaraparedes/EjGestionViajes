using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionViajes
{
    public class Furgoneta : Vehiculo
    {
        public int CapacidadAdicional { get; set; }
        public Furgoneta (int capacidadAdicional, string placa, int kilometraje)
        {
            this.CapacidadAdicional = capacidadAdicional;
            this.Placa = placa;
            this.Kilometraje = kilometraje;
            ListaViajes = new List<Viaje>();
        }
    }
}
