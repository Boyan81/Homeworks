using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main()
        {
            string privateKey = Console.ReadLine();
            Regex pattern =new Regex( @"^TO:\s([A-Z]+);\sMESSAGE:\s(.*)$");
            Dictionary<string,List<string>> message = new Dictionary<string, List<string>>();
            string input = "";
            
            while ((input = Console.ReadLine()) != "END")
            {
                if (pattern.IsMatch(input))
                {
                    Match match = pattern.Match(input);
                    string senderName = match.Groups[1].ToString();
                    if (!message.ContainsKey(senderName))
                    {
                        message.Add(senderName, new List<string>());
                    }
                    string messChar = "";
                    int index = 0;
                    for (int i = 0; i < input.Length; i++)
                    {

                        if (index > privateKey.Length - 1)
                        {
                            index = 0;
                        }
                        int x = int.Parse(privateKey[index].ToString());
                        char leter = (char)(input[i] + x);
                        messChar += leter;
                        index++;
                    }
                    message[senderName].Add(messChar);
                }
                    

            }


            foreach (var item in message.OrderBy(x => x.Key))
            {
                Console.WriteLine(String.Join("\r\n",item.Value));
             
            }
        }
    }
}
