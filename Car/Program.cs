using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyotas", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
        }
    }
}
