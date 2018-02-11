using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var queue= new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var pump = Console.ReadLine()
                    .Split().Select(int.Parse).ToArray();
                queue.Enqueue(pump);
            }
            for (int i = 0; i < n-1; i++)
            {
                var fuel = 0;
                bool isSolution = true;
                for (int k = 0; k < n; k++)
                {
                    var curentPomp = queue.Dequeue();
                    queue.Enqueue(curentPomp);
                    fuel += curentPomp[0]-curentPomp[1];
                    if (fuel<0)
                    {
                        i += k;
                        isSolution = false;
                        break;
                    }
                }
                if (isSolution)
                {
                    Console.WriteLine(i);
                    Environment.Exit(0);
                }
            }
            
        }
    }
}
