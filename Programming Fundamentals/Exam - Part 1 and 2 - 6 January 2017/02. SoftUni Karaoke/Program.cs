using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main()
        {
            string[] applied = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            List<string> songs = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();
            Dictionary<string, Dictionary<string, int>> participants = new Dictionary<string, Dictionary<string, int>>();
            foreach (var item in applied)
            {
                if (!participants.ContainsKey(item))
                {
                    participants.Add(item, new Dictionary<string, int>());
                }
            }
            string input;
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] inputArgs = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();
                string name = inputArgs[0];
                string song = inputArgs[1];
                string award = inputArgs[2];
                if (participants.ContainsKey(name))
                {
                    if (songs.Contains(song))
                    {
                        if (!participants[name].ContainsKey(award))
                        {
                            participants[name].Add(award, 1);
                        }
                        else
                        {
                            participants[name][award] += 1;
                        }
                    }
                }
            }
            int sum = 0;
            foreach (var item in participants)
            {
                foreach (var it in item.Value)
                {
                    sum += it.Value;
                }
            }
            if (sum > 0)
            {
                foreach (var item in participants.OrderByDescending(x => x.Value.Count)//сортиране по Value.Count
                                                 .ThenBy(n => n.Key))//второ сортиране по азбучен ред по клуча
                {
                    if (item.Value.Count != 0)
                    {
                        Console.WriteLine($"{item.Key}: {(item.Value.Count)} awards");
                        foreach (var it in item.Value.OrderBy(x => x.Key))
                        {
                            Console.WriteLine($"--{it.Key}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
