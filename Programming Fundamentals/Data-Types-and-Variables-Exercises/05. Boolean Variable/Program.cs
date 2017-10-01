using System;

namespace _05._Boolean_Variable
{
    class Program
    {
        static void Main()
        {
            bool isTrue = Convert.ToBoolean(Console.ReadLine());
            if (isTrue)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
