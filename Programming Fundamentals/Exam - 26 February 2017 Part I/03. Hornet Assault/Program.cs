using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main()
        {
            long[] beehives = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray(); 
            List<long> hornets = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            for (int i = 0; i < beehives.Length; i++)
            {
                if (Sum(hornets) ==0)
                {
                    break;
                }
                if (beehives[i]>=hornets.Sum())
                {
                    beehives[i] -= Sum(hornets);
                    hornets.RemoveAt(0);
                   
                }
                else
                {
                beehives[i] = 0;
                }
            }
            if (beehives.Sum()>0)
            {
                Console.WriteLine(String.Join(" ",beehives.Where(x=>x>0)));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
            
        }

        private static long Sum(List<long> hornets)
        {
            long sum = 0;
            foreach (int item in hornets)
            {
                sum += item;
            }
            return sum;
        }
    }
}
