using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotel
{
    internal class Programa : HabitacionDeluxe
    {
        public List<Habitacion> habitaciones;
        
        

        static void NuevaHabitacionSimple(int numero, double costo, int numeroCamas, bool disponibilidad, string tipo)
        {
            Console.WriteLine("Ingrese el numero de la habitacion");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el costo de la habitacion");
            costo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de camas que tiene la habitacion");
            numeroCamas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de habitacion que es");
            tipo = Console.ReadLine();

            disponibilidad = true;
        }

        static void Menu()
        {
        }
    }
}
