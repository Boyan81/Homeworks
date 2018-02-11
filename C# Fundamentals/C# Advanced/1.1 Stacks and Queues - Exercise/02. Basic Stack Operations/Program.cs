using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main()
        {
            int[] comand = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int ecount = comand[0];
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var steck = new Stack<int>();

            for (int i = 0; i < ecount; i++)
            {
                steck.Push(input[i]);
            }
            for (int i = 0; i < comand[1]; i++)
            {
                steck.Pop();
            }
            if (steck.Contains(comand[2]))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (steck.Count==0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                var rezult = steck.ToArray();
                Console.WriteLine(rezult.Min());
                }
            }
        }
    }
}
