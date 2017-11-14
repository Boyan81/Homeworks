using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                input.Add(num);
            }

            Console.WriteLine($"Sum = {input.Sum()}");
            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Max = {input.Max()}");
            Console.WriteLine($"Average = {input.Average()}");
   

        }
    }
}
