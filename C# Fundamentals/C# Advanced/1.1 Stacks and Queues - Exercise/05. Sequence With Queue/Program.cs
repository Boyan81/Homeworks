using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            Console.Write($"{input} ");
            queue.Enqueue(input);
            int count = 1;

            while (count<50)
            {
                input = queue.Dequeue();
                Console.Write($"{input+1} ");
                queue.Enqueue(input + 1);
                count++;
                if (count<50)
                {
                    Console.Write($"{2 * input + 1} ");
                    queue.Enqueue(2 * input + 1);
                    count++;
                }
                else
                {
                    break;
                }
                if (count<50)
                {
                    Console.Write($"{input + 2} ");
                    queue.Enqueue(input + 2);
                    count++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine();
        }
    }
}
