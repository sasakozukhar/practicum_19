using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 10; 
            double increaseRate = 0.1; 
            int day = 1;

            while (distance <= 20)
            {
                distance *= (1 + increaseRate);
                day++;
            }

            Console.WriteLine($"Лыжник пробежит больше 20 км на {day}-й день.");
            Console.ReadKey();
        }
    }
}
