namespace SistemaHotel
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double Costo { get; set; }
        private string NombreCliente { get; set; }
        public int NumeroCamas { get; set; }
        public bool Disponibilidad { get; set; }

        public Habitacion(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad)
        { 
            Numero = numero;
            Costo = costo;
            NombreCliente = nombreCliente;
            NumeroCamas = numeroCamas;
            Disponibilidad = disponibilidad;
        }

        public void MostrarInformacion(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad)
        {
            Console.WriteLine(numero);
            Console.WriteLine(costo);
            Console.WriteLine(nombreCliente);
            Console.WriteLine(numeroCamas);
            Console.WriteLine(disponibilidad);
        }

        public bool CambiarDisponibilidad(bool disponibilidad)
        {
            return true;
        }

        public void AsignarCliente()
        {

        }
    }

    public class Suite : Habitacion 
    {
        public bool Jacuzzi { get; set; }
        public int CantidadHabitaciones { get; set; }
    }

    public class HabitacionDeluxe : Suite
    {
        public bool Comidas { get; set; }
    }
}