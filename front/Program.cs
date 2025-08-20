using gestionViajes;
using System.Security.Cryptography.X509Certificates;

namespace consola
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public class MenuPrincipal
        {

            public List<Vehiculo> vehiculosRegistrados = new List<Vehiculo>();
            public void Mostrar()
            {
                bool salir = false;
                while (!salir)
                {
                    Console.Clear();
                    Console.WriteLine("MENÚ PRINCIPAL");
                    Console.WriteLine("1. Agregar un vehículo.");
                    Console.WriteLine("2. Registrar un viaje para un vehículo.");
                    Console.WriteLine("3. Mostrar información de un vehículo.");
                    Console.WriteLine("4. Mostrar todos los vehículos y estadísticas generales.");
                    Console.WriteLine("5. Salir.");
                    Console.WriteLine("Seleccione una de las opciones anteriores: ");

                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                AgregarVehiculo();
                                break;
                            case 2:
                                RegistrarViaje();
                                break;
                            case 3:
                                MostrarInfo();
                                break;
                            case 4:
                                MostrarVehiculosEst();
                                break;
                            case 5:
                                salir = true;
                                break;
                            default:
                                Console.WriteLine("Opción fuera de rango,presione una tecla para volver a intentar...");
                                Console.ReadKey();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Opción inválida, presione una tecla para volver a intentar...");
                        Console.ReadKey();
                    }


                }


            }

            public void AgregarVehiculo()
            {
                Console.WriteLine("1. Camión");
                Console.WriteLine("2. Furgoneta");
                Console.WriteLine("3. Motocicleta");
                Console.WriteLine("Ingrese el tipo de vehículo a registrar: ");
                string input = Console.ReadLine();


                if (int.TryParse(input, out int opcion))
                {
                    Vehiculo nuevoVehiculo = null;
                    switch (opcion)
                    {
                        case 1:
                            nuevoVehiculo = CrearVehiculoCarga();
                            break;
                        case 2:
                            nuevoVehiculo = CrearVehiculoCarga();
                            break;
                        case 3:
                            nuevoVehiculo = CrearMotocicleta();
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            return;
                    }
                    vehiculosRegistrados.Add(nuevoVehiculo);
                    Console.WriteLine("Vehículo registrado exitosamente.");
                }



            }

            public void CrearVehiculoCarga()
            {
                Console.WriteLine("Ingrese el número de placa: ");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el kilometraje del camión: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int kilometraje))
                {
                    Console.WriteLine("Ingrese la capacidad de carga máxima: ");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out int capacidadAdicional))
                    {
                        Camion nuevoCamion = new Camion(capacidadAdicional, placa, kilometraje);
                        vehiculosRegistrados.Add(nuevoCamion);
                        Console.WriteLine("Vehículo registrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Ingreso no válido.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso no válido.");
                    return;
                }
            }
            public void CrearMotocicleta()
            {
                Console.WriteLine("Ingrese el número de placa: ");
                string placa = Console.ReadLine();
                Console.WriteLine("Ingrese el kilometraje de la motocicleta: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int kilometraje))
                {
                    Console.WriteLine("Ingrese la cantidad de pasajeros: ");
                    string entrada = Console.ReadLine();
                    if (int.TryParse(entrada, out int cantidadPasajeros))
                    {
                        Motocicleta nuevoMotocicleta = new Motocicleta(cantidadPasajeros, placa, kilometraje);
                        vehiculosRegistrados.Add(nuevoMotocicleta);
                        Console.WriteLine("Vehículo registrado exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Ingreso no válido.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Ingreso no válido.");
                    return;
                }
            }
            public void RegistrarViaje()
            {
                Console.WriteLine("Ingrese la distancia del viaje: ");
                string dist = Console.ReadLine();
                if (int.TryParse(dist, out int distancia))
                {
                    Console.WriteLine("1. Vehículo de carga.");
                    Console.WriteLine("2. Vehículo de transporte.");
                    Console.WriteLine("Seleccione la opcion que desea: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int opcion))
                    {
                        switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Ingrese la carga en Kilogramos a transportar");
                                string entrada = Console.ReadLine();
                                if (int.TryParse(entrada, out int cargaTransportada))
                                {
                                    Console.WriteLine("Ingrese la fecha: ");
                                    string enter = Console.ReadLine();
                                    if (int.TryParse(enter, out int fecha))
                                    {
                                        Viaje nuevoViaje = new Viaje(distancia, cargaTransportada, fecha);
                                    }
                                }
                                break;
                            case 2:
                                Console.WriteLine("No hace falta la carga transportada.");
                                break;
                        }
                    }
                }
            }
            public void MostrarInfo()
            {

            }
        }

        


}