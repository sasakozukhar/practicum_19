using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Program
    {
        static void Main(string[] args)
        {
             double dailyDistance = 10;
            double totalDistance = 0;
            double increaseRate = 0.1;
            int day = 1;

            while (totalDistance <= 100)
            {
                totalDistance += dailyDistance;
                dailyDistance *= (1 + increaseRate);
                day++;
            }

            Console.WriteLine($"Суммарный пробег превысит 100 км на {day}-й день.");
            Console.ReadKey();
        }
    }
}
