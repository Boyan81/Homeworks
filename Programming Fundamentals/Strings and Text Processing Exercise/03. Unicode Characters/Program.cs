using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder result = new StringBuilder();
            string input = Console.ReadLine();
            foreach (char item in input)
            {
                result.AppendFormat("\\u{0:x4}", (int)item);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
