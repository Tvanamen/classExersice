using System;
using System.Collections.Generic;
namespace ClassExersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Cars();
            {
                car1.Year = "2000";
                car1.Make = "Ford";
                car1.Model = "F150";
            }
            var car2 = new Cars();
            {
                car2.Year = "1990";
                car2.Make = "Chevy";
                car2.Model = "Stingray";
            }
            var car3 = new Cars();
            {
                car3.Year = "1996";
                car3.Make = "Subaru";
                car3.Model = "Outback";
            }
            var carList = new List<Cars>() { car1, car2, car3 };

            foreach (var vehicals in carList)
            {
                Console.WriteLine($" {vehicals.Make} {vehicals.Model} {vehicals.Year}");
            }
        }
    }
}
