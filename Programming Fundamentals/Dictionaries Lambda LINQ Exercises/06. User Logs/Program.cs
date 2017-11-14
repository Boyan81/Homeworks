using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_User_Logs
{
    class Program
    {
        static void Main()
        {
            SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] data = input
                        .Split(new string[] { "IP=", "message=", "user=", " " }, StringSplitOptions.RemoveEmptyEntries);
                string iP = data[0];
                string user = data[2];
                if (!users.ContainsKey(user))
                {
                    users.Add(user, new Dictionary<string, int>());
                    users[user].Add(iP, 1);
                }
                else
                {
                    if (!users[user].ContainsKey(iP))
                    {
                        users[user].Add(iP, 1);
                    }
                    else
                    {
                        users[user][iP] += 1;
                    }
                }

                input = Console.ReadLine();
            }
           // Console.WriteLine();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var addresses in user.Value)
                {
                    if (addresses.Equals(user.Value.Last()))
                    {
                        Console.WriteLine($"{addresses.Key} => {addresses.Value}.");
                        break;
                    }

                    Console.Write($"{addresses.Key} => {addresses.Value}, ");
                }

            }
            
        }


    }
}
