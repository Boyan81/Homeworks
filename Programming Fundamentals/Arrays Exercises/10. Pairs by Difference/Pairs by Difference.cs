using System;
using System.Linq;


namespace _10.Pairs_by_Difference
{
    public class Program
    {
        public static void Main()
        {
            int[] inputArr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int nudifference = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = i; j < inputArr.Length; j++)
                {
                    int result = Math.Abs(inputArr[i] - inputArr[j]);
                    if (result==nudifference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count>0?count:0);
        }
    }
}
