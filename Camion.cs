using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionViajes
{
    public class Camion : Vehiculo
    {
        public int CapacidadAdicional { get; set; }
        public int CargaMaxima()
        {
            int max = 0;
            foreach (var Viaje in ListaViajes )
                if (Viaje.CargaTransportada > max)
                {
                    max = Viaje.CargaTransportada;
                }
            return max;
        }
        public Camion(int capacidadAdicional, string placa, int kilometraje)
        {
            this.CapacidadAdicional = capacidadAdicional;
            this.Placa = placa;
            this.Kilometraje = kilometraje;
            ListaViajes = new List<Viaje>();
        }

    }
}
