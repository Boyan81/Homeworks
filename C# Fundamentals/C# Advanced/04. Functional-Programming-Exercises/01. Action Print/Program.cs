using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Action_Print
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList()
                 .ForEach(x => Console.WriteLine(x));
        }
    }
}
