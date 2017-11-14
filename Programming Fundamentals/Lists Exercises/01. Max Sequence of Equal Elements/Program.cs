using System;
using System.Collections.Generic;
using System.Linq;
namespace _01._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList<int>();

            int count = 1;
            int maxCount = 1;
            List<int> temp = new List<int>();
            List<int> result = new List<int>();
            temp.Add(arr[0]);

            for (int i = 0; i < arr.Count - 1; i++)
            {
                if (arr[i]==arr[i+1])
                {
                    count++;
                    temp.Add(arr[i + 1]);
                }
                else
                {
                    count = 1;
                    temp.Clear();
                    temp.Add(arr[i+1]);
                }
                if (count>maxCount)
                {
                    result.Clear();
                    maxCount = count;
                    result.AddRange(temp);
                }
               
            }
            if (maxCount==1)
            {
                Console.WriteLine(arr[0]);
            }
            else
            {
                Console.WriteLine(String.Join(" ",result));
            }
            
        }
    }
    
}
