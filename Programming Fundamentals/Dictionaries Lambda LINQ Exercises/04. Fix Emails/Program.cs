using System;
using System.Collections.Generic;
using System.Linq;


namespace _04.Fix_Emails
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> bookEmail = new Dictionary<string, string>();

            string input = Console.ReadLine();
            int count = 1;
            string temp = "";
            while (input!="stop")
            {
                if (count % 2 != 0)
                {
                    if (!bookEmail.ContainsKey(input))
                    {
                        bookEmail.Add(input, null);
                    }
                }
                else
                {
                    if (!(input.EndsWith("us") || input.EndsWith("uk")))
                    {
                        bookEmail[temp] = input;
                    }
                }
                temp = input;
                count++;
                input = Console.ReadLine();
            }
            foreach (var item in bookEmail.Keys)
            {
                if (!(bookEmail[item]==null))
                {
                    Console.WriteLine($"{item} -> {bookEmail[item]}");
                }
            }
        }
    }
}
