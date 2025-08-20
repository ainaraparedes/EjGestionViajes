using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionViajes
{
    public class Viaje
    {
        public int Distancia { get; set; }
        public int CargaTransportada { get; set; }
        public DateTime Fecha { get; set; }

        public Viaje(int distancia, int cargaTransportada, DateTime fecha)
        {
            this.Distancia = distancia;
            this.CargaTransportada = cargaTransportada;
            this.Fecha = fecha;
        }

    }
}
