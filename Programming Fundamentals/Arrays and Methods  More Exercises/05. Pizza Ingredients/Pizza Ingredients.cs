using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            int count = 0;
            List < string > pizza = new List<string>();

            for (int i = 0; i < ingredients.Length; i++)
            {
                string spice = ingredients[i];
                if (spice.Length==n)
                {
                    pizza.Add(ingredients[i]);
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    count++;
                    if (count>=10)
                    {
                        break;
                    }
                }

            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ",pizza)}.");
        }
    }
}
