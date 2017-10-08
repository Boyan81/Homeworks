using System;

namespace _03._Last_K_Numbers_Sums
{
    class Program
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long k = long.Parse(Console.ReadLine());

            long[] arr = new long[n];
            
            arr[0] = 1;

            for (long i = 1; i < arr.Length; i++)
            {
                long start = Math.Max(0, i - k);
                long end = i - 1;
                long sum = 0;
                for (long j = start; j <= end; j++)
                {
                    sum += arr[j];
                }

                arr[i] = sum;
            }
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
