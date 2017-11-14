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
            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] parametar = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string command = parametar[0];

                if (command == "A")
                {
                    string key = parametar[1];
                    string value = parametar[2];
                    //phoneBook.Add(key,value);
                    phoneBook[key] = value;
                }
                else if(command=="S")
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
                else if (command== "ListAll")
                {
                    foreach (var item in phoneBook.Keys)
                    {
                        Console.WriteLine($"{item} -> {phoneBook[item]}");
                    }
                    
                }
                input = Console.ReadLine();
            }
        }
    }
}
