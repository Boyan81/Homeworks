using System;

namespace _01._Practice_Integers
{
    class Program
    {
        static void Main()
        {
            sbyte sbyteNum = sbyte.Parse(Console.ReadLine());
            byte byteNum = byte.Parse(Console.ReadLine());
            short shortNum = short.Parse(Console.ReadLine());
            ushort ushortNum = ushort.Parse(Console.ReadLine());
           // int intNum = int.Parse(Console.ReadLine());
            uint uintNum = uint.Parse(Console.ReadLine());
            long longNum = long.Parse(Console.ReadLine());
            long longNum1 = long.Parse(Console.ReadLine());
            //ulong ulongNum = ulong.Parse(Console.ReadLine());

            Console.WriteLine(sbyteNum);
            Console.WriteLine(byteNum);
            Console.WriteLine(shortNum);
            Console.WriteLine(ushortNum);
           // Console.WriteLine(intNum);
            Console.WriteLine(uintNum);
            Console.WriteLine(longNum);
            Console.WriteLine(longNum1);
            // Console.WriteLine(ulongNum);
        }
    }
}