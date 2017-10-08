using System;
using System.Linq;

namespace _5._Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main()
        {
            double[] num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] rounding = new int[num.Length];//
            for (int i = 0; i < num.Length; i++)
            {
                rounding[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
                //Console.WriteLine("{0} => {1}",num[i],(int)Math.Round(num[i],MidpointRounding.AwayFromZero));
            }
            for (int j = 0; j < num.Length; j++)
            {
                Console.WriteLine("{0} => {1}",num[j],rounding[j]);
            }

        }
    }
}
