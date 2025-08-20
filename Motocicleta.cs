using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionViajes
{
    public class Motocicleta : Vehiculo
    {
        public int CantidadPasajeros { get; set; }
        public Motocicleta (int cantidadPasajeros, string placa, int kilometraje)
        {
            this.CantidadPasajeros = cantidadPasajeros;
            this.Placa = placa;
            this.Kilometraje = kilometraje;
            ListaViajes = new List<Viaje> ();
        }
    }
}
