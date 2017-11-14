using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b([a-zA-Z][a-zA-Z0-9_]{2,24})\b";

            MatchCollection collection = Regex.Matches(input, pattern);
            List<string> list = new List<string>();

            foreach (Match item in collection)
            {
                list.Add(item.ToString());
            }
            int maxSum = 0;
            string user1 = "";
            string user2 = "";
            for (int i = 0; i < list.Count-1; i++)
            {
                int sum = list[i].Length + list[i + 1].Length;
                if (sum>maxSum)
                {
                    maxSum = sum;
                    user1 = list[i];
                    user2 = list[i+1];
                }
            }
            Console.WriteLine(user1);
            Console.WriteLine(user2);
           
        }
    }
}
