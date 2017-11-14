using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            List<string> messages = new List<string>();
            List<string> broadcasts = new List<string>();
            string paterenMess = @"^([\d]+) <-> ([A-Za-z0-9]+)$";
            string paternCast = @"^([\D]+) <-> ([A-Za-z0-9]+)$";
            Regex message = new Regex(paterenMess);
            //Regex boadcast = new Regex(paternCast);

            string input;

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                string[] inputArr = input.Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);
                if (message.IsMatch(input))
                {
                    var reciprecipient = inputArr[0].ToCharArray().Reverse();
                    messages.Add($"{String.Join("", reciprecipient)} -> {inputArr[1]}");
                }
                if (Regex.IsMatch(input, paternCast))//съкратен запис без инициализиране на new Regex
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (char ch in inputArr[1].ToCharArray())
                    {
                        if (Char.IsLower(ch))
                        {
                            sb.Append(Char.ToUpper(ch));
                            continue;
                        }
                        if (Char.IsUpper(ch))
                        {
                            sb.Append(Char.ToLower(ch));
                            continue;
                        }
                        sb.Append(ch);
                    }
                    broadcasts.Add($"{sb.ToString()} -> {inputArr[0]}");
                }
            }
            Console.WriteLine("Broadcasts:");
            Print(broadcasts);
            Console.WriteLine("Messages:");
            Print(messages);
        }

        private static void Print(List<string> broadcasts)
        {
           
            if (broadcasts.Count != 0)
            {
                foreach (var item in broadcasts)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
