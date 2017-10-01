using System;

namespace _04._Variable_in_Hex_Format
{
    class Program
    {
        static void Main()
        {
            string hexNum = Console.ReadLine();

            int numConvert = Convert.ToInt32(hexNum, 16);
            Console.WriteLine(numConvert);
        }
    }
}
