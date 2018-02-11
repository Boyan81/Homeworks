using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Basic_Queue_Operations
{
    class Program
    {
        static void Main()
        {
            int[] comand = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ecount = comand[0];
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var queue = new Queue<int>();

            for (int i = 0; i < ecount; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = 0; i < comand[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(comand[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    var rezult = queue.ToArray();
                    Console.WriteLine(rezult.Min());
                }
            }
        }
    }
}
