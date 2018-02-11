using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            string cmd = Console.ReadLine().ToLower();

            Predicate<int> predicate;
            switch (cmd)
            {
                case "odd":
                    predicate = x => x % 2 != 0;
                    break;
                case "even":
                    predicate = x => x % 2 == 0;
                    break;
                default:
                    predicate = null;
                    break;
            }
            var result = EvanOrOdd(input, predicate);
            Console.WriteLine(String.Join(" ",result));
        }

        private static Queue<int> EvanOrOdd(int[] input, Predicate<int> predicate)
        {
            var queue = new Queue<int>();
            for (int i = input[0]; i <= input[1]; i++)
            {
                if (predicate(i))
                {
                    queue.Enqueue(i);
                }
                
            }
            return queue;
        }
    }
}
