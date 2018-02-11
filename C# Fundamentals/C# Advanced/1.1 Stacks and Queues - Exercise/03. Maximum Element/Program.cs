using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main()
        {
            int commandCount = int.Parse(Console.ReadLine());
            var steck = new Stack<int>();
            var steckMax = new Stack<int>();
            steckMax.Push(int.MinValue);

            for (int i = 0; i < commandCount; i++)
            {
                int[] cmd = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                switch (cmd[0])
                {
                    case 1:
                        int elements = cmd[1];
                        steck.Push(elements);
                        if (elements>=steckMax.Peek())
                        {
                            steckMax.Push(elements);
                        }
                        break;
                    case 2:
                        var popedElemend = steck.Pop();
                        if (steckMax.Peek()==popedElemend)
                        {
                            steckMax.Pop();
                        }
                        break;
                    case 3:
                        int maxElement = steckMax.Peek();
                        Console.WriteLine(maxElement);
                        break;

                }
            }
        }
    }
}
