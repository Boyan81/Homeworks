using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double onOneHundred = volume / 100.0;
            double kcal = onOneHundred *energy;
            double gram = onOneHundred * sugar;

            Console.WriteLine("{0}ml {1}:",volume,name);
            Console.WriteLine($"{kcal}kcal, {gram}g sugars");

        }
    }
}
