using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


          
            int count = 0;
            int bestCount = 0;
            int bestNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i]==arr[j])
                    {
                        count++;
                    }

                }
                if (count>bestCount)
                {
                    bestCount = count;
                    bestNum = arr[i];
                }
                

            }
            Console.WriteLine(bestNum);
        }
    }
}
