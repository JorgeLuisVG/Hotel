namespace SistemaHotel
{
    public class Habitacion
    {
        public int Numero { get; set; }
        public double Costo { get; set; }
        public string NombreCliente { get; set; }
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

        public void AsignarCliente(int numero, double costo, string nombreCliente, bool disponibilidad)
        {
            Console.WriteLine($"La habitacion {numero} se asigno a {nombreCliente} a un costo de {costo}");
            disponibilidad = false;
        }
    }

    public class HabitacionSimple : Habitacion
    {
        public bool Baño { get; set; }
        public HabitacionSimple(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad, bool baño)
            : base(numero, costo, nombreCliente, numeroCamas, disponibilidad)
        {
            Baño = baño;
        }
    }

    public class HabitacionDoble : Habitacion
    {
        public bool VistaAlMar { get; set; }
        public HabitacionDoble(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad, bool vistaAlMar)
            : base(numero, costo, nombreCliente, numeroCamas, disponibilidad)
        {
            VistaAlMar = vistaAlMar;
        }
    }

    public class Suite : Habitacion 
    {
        public bool Jacuzzi { get; set; }
        public Suite(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad, bool jacuzzi)
            : base(numero, costo, nombreCliente, numeroCamas, disponibilidad)
        {
            Jacuzzi = jacuzzi;
        }
    }

    public class HabitacionDeluxe : Habitacion
    {
        public bool Comidas { get; set; }
        public HabitacionDeluxe(int numero, double costo, string nombreCliente, int numeroCamas, bool disponibilidad, string tipo, bool comidas)
            : base(numero, costo,nombreCliente, numeroCamas, disponibilidad)
        {
            Comidas = comidas;
        }
    }
}