using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {
        static void Main()
        {
            Func<decimal, decimal> vat = d => d * 1.2m;
            Console.ReadLine()
               .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(decimal.Parse)
               .Select(vat)
               .ToList()
               .ForEach(x => Console.WriteLine($"{x:f2}"));
                
            
        }
    }
}
