using Lab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведiть модель лiтака:");
            string Model = Console.ReadLine();

            Console.Write("Введiть виробника лiтка: ");
            string Producer = Console.ReadLine();

            Console.Write("Введiть рiк випуску лiтака: ");
            int Year = int.Parse(Console.ReadLine());

            Console.Write("Введiть тип лiтака: ");
            string Type = Console.ReadLine();

            Console.Write("Введiть максимальну кiлькiсть пасажирiв: ");
            int MaxPassengers = int.Parse(Console.ReadLine());

            Console.Write("Введiть максимальну швидкiсть лiтака (км/год): ");
            double MaxSpeed = double.Parse(Console.ReadLine());

            Console.Write("Введiть довжина лiтака: ");
            double Length = double.Parse(Console.ReadLine());

            Console.Write("Введiть висоту лiтака: ");
            double Height = double.Parse(Console.ReadLine());

            Console.Write("Введiть розхiд палива (л/100 км): ");
            double fuelConsumption = double.Parse(Console.ReadLine());

            Plane plane = new Plane();

            plane.Model = Model;
            plane.Producer = Producer;
            plane.Year = Year;
            plane.Type = Type;
            plane.MaxPassengers = MaxPassengers;
            plane.MaxSpeed = MaxSpeed;
            plane.Length = Length;
            plane.Height = Height;
            plane.FuelConsumption = fuelConsumption;


            plane.CalculateMaxFlightRange();
            Console.WriteLine($"Максимальна дальнiсть польоту: {plane.MaxFlightRange} км");

            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("\nДанi про лiтак:");
            Console.WriteLine("----------------------");
            Console.WriteLine();
            Console.WriteLine("Модель:" + plane.Model);
            Console.WriteLine();
            Console.Write("Виробник:" + plane.Producer);
            Console.WriteLine();
            Console.Write("Рiк:" + plane.Year);
            Console.WriteLine();
            Console.Write("Тип:" + plane.Type);
            Console.WriteLine();
            Console.Write("Максимальна кiлькiсть пасажирiв:" + plane.MaxPassengers);
            Console.WriteLine();
            Console.Write("Максимальна швидкiсть:" + plane.MaxSpeed);
            Console.WriteLine();
            Console.Write("Довжина:" + plane.Length);
            Console.WriteLine();
            Console.Write("Висота:" + plane.Height);
            Console.WriteLine();
            Console.Write("Розхiд палива:" + plane.FuelConsumption);
            Console.ReadKey();
        }
    }
}
