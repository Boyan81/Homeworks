using System;
using System.Linq;
using System.Collections.Generic;

namespace _10._Predicate_Party_
{
    class Program
    {
        public static List<string> guests;
        static void Main()
        {
            guests = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            string command;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] tokens = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length < 3)
                {
                    continue;
                }
                switch (tokens[1])
                {
                    case "StartsWith":
                        ForeachGuests(tokens[0], n => n.StartsWith(tokens[2]));
                        break;
                    case "EndsWith":
                        ForeachGuests(tokens[0], n => n.EndsWith(tokens[2]));
                        break;
                    case "Length":
                        ForeachGuests(tokens[0], n => n.Length == int.Parse(tokens[2]));
                        break;
                    default:
                        break;
                }
            }
            PrintGuests();
        }

        private static void PrintGuests()
        {
            if (guests.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                //guests = guests.OrderBy(n => n).ToList();
                Console.WriteLine($"{String.Join(", ", guests)} are going to the party!");
            }
        }

        private static void ForeachGuests(string firstComand, Func<string, bool> func)
        {
            for (int i = guests.Count - 1; i >= 0; i--)
            {
                if (func(guests[i]))
                {
                    if (firstComand == "Remove")
                    {
                        guests.RemoveAt(i);

                    }
                    else if (firstComand == "Double")
                    {
                        guests.Add(guests[i]);

                    }
                }
            }
        }
    }
}
