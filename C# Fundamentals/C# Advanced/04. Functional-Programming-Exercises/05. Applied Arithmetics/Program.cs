using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var colection = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse);

            
            string cmd;
            while ((cmd=Console.ReadLine())!="end")
            {
                switch (cmd)
                {
                    case "add":
                        colection = ForEach(colection, n => n + 1);
                        break;
                    case "multiply":
                        colection = ForEach(colection, n => n * 2);
                        break;
                    case "subtract":
                        colection = ForEach(colection, n => n - 1);
                        break;
                    case "print":
                        Console.WriteLine(String.Join(" ",colection));
                        break;
                    default:
                        break;
                }
                
            }
        }

        private static IEnumerable<int> ForEach(IEnumerable<int> colection, Func<int, int> func)
        {
            return colection.Select(n => func(n));
        }
    }
}
