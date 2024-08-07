using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel
{
    internal class Programa : HabitacionDeluxe
    {
        public List<Habitacion> habitaciones = new List<Habitacion>();
        public List<Suite> suits = new List<Suite>();

        static void NuevaHabitacionSimple(int numero, double costo, int numeroCamas, bool disponibilidad)
        {
            Console.WriteLine("Ingrese el numero de la habitacion");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el costo de la habitacion");
            costo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de camas que tiene la habitacion");
            numeroCamas = Convert.ToInt32(Console.ReadLine());

            disponibilidad = true;
        }

        static void NuevaSuite(int numero, double costo, int numeroCamas, bool disponibilidad)
        {
        
        }



    }
}
