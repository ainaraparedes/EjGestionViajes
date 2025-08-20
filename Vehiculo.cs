namespace gestionViajes
{
    public abstract class Vehiculo
    {
        public string Placa { get; set; }
        public int Kilometraje { get; set; }
        public int CantidadDeViajes => ListaViajes.Count;
        public List<Viaje> ListaViajes { get; set; }
        public void agregarViaje(Viaje agregarViaje)
        {
            ListaViajes.Add(agregarViaje);
            
        }
        public abstract distanciaRecorrida();

        public Vehiculo (string placa, int kilometraje, List<Viaje> listaViajes)
        {
            this.Placa = placa;
            this.Kilometraje = kilometraje;
            ListaViajes = listaViajes;

        }

    }
}
