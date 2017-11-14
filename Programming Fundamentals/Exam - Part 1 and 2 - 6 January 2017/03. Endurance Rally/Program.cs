using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main()
        {
            string[] nameDriver = Console.ReadLine().Split(' ');
            decimal[] trackLayout = Console.ReadLine().Split(' ').Select(decimal.Parse)
                .ToArray();
            int[] checkPoint = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nameDriver.Length; i++)
            {
                decimal fuel = nameDriver[i].First();
                for (int j = 0; j < trackLayout.Length; j++)
                {
                    if (checkPoint.Contains(j))
                    {
                        fuel += trackLayout[j];
                    }
                    else
                    {
                        fuel -= trackLayout[j];
                        if (fuel<=0)
                        {
                            Console.WriteLine($"{nameDriver[i]} - reached {j}");
                            j = trackLayout.Length;
                            break;
                        }
                    }  
                }
                if (fuel<=0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{nameDriver[i]} - fuel left {fuel:f2}");
                }
                
            }
        }
    }
}
