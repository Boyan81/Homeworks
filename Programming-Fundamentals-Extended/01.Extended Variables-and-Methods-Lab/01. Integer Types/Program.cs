using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Integer_Types
{
    class Program
    {
        static void Main()
        {
            byte num1 = byte.Parse(Console.ReadLine());
            uint num2 = uint.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            ulong num4 = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} {num2} {num3} {num4}");
        }
    }
}
