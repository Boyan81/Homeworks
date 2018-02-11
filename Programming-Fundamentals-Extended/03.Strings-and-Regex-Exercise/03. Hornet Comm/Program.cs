using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            string pattrenMessage = @"^(\d+) <-> ([A-Za-z0-9]+)$";
            string pattrenBroadcast = @"^(\D+) <-> ([A-Za-z0-9]+)$";
            string input = Console.ReadLine();
            List<string> message = new List<string>();
            List<string> broadcast = new List<string>();
            while (input!= "Hornet is Green")
            {
                Match privetMassage = Regex.Match(input, pattrenMessage);
                Match privetBroadcast = Regex.Match(input, pattrenBroadcast);
                if (privetBroadcast.Success)
                {
                    string mess = privetBroadcast.Groups[1].ToString();
                    string frequency = privetBroadcast.Groups[2].ToString();
                    string freqlancyResult = "";
                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            freqlancyResult += frequency[i].ToString().ToUpper();
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            freqlancyResult += frequency[i].ToString().ToLower();

                        }
                        else
                        {
                            freqlancyResult += frequency[i].ToString();
                        }
                    }
                    broadcast.Add(freqlancyResult + " -> " + mess);

                }
                if (privetMassage.Success)
                {
                    string recipient = privetMassage.Groups[1].ToString();
                    string mess = privetMassage.Groups[2].ToString();
                    recipient = String.Join("", recipient.ToCharArray().Reverse().ToArray());
                    message.Add(recipient + " -> " + mess);

                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count==0)
            {
                Console.WriteLine("None");
            }
            else
            {
                broadcast.ForEach(a => Console.WriteLine(a));
            }
            Console.WriteLine("Messages:");
            if (message.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {
                message.ForEach(a => Console.WriteLine(a));
            }
        }
    }
}
