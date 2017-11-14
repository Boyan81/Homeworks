using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] parametar = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = parametar[0];

                if (command=="A")
                {
                    string key = parametar[1];
                    string value = parametar[2];
                    //phoneBook.Add(key,value);
                    phoneBook[key] = value;
                }
                else
                {
                    string key = parametar[1];
                    if (phoneBook.ContainsKey(key))
                    {
                        Console.WriteLine($"{key} -> {phoneBook[key]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {key} does not exist.");
                    }


                }
                input = Console.ReadLine();
            }
        }
    }
}
