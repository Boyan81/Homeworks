using System;
using System.Linq;

namespace _09._Extract_Middle_Elements
{
    class Program
    {
        static void Main()
        {
            var num = Console.ReadLine().Split(' ').ToArray();
            string[] newNum = MidleElement(num);
            Console.Write("{ ");
            Console.Write(String.Join(", ",newNum));
            Console.WriteLine(" }");
        }

        static string[] MidleElement(string[] num)
        {
            string[] temp = new string[num.Length];
            if (num.Length == 1)
            {
                temp = new string[1];
                temp[0] = num[0];
            }
            else if (num.Length % 2 == 0)
            {
                temp = new string[2];

                temp[0] = num[num.Length / 2 - 1];
                temp[1] = num[num.Length / 2];

            }
            else if (num.Length % 2 == 1)
            {
                temp = new string[3];

                temp[0] = num[num.Length / 2 - 1];
                temp[1] = num[num.Length/2];
                temp[2] = num[num.Length / 2 + 1];
            }
            return temp;
        }
    }
}
