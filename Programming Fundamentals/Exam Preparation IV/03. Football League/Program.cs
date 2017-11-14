using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        static void Main()
        {
            string key = Console.ReadLine();
            key = Regex.Escape(key);
            string input;
            Dictionary<string, ulong> teamPoint = new Dictionary<string, ulong>();
            Dictionary<string, ulong> teamGoal = new Dictionary<string, ulong>();
          
            string paterrenTeam = $@"(?:{key})(\w+)(?:{key})";
            string paterrenGoal = @"([0-9]*)(?:[:])([0-9]*)";

            while ((input = Console.ReadLine()) != "final")
            {

                MatchCollection teams = Regex.Matches(input, paterrenTeam);
                var firstTeam = teams[0].Groups[1].ToString();
                var first = firstTeam.ToCharArray().Reverse().ToArray();
                var nameFirst = new string(first);
                nameFirst = nameFirst.ToUpper();

                var secondsTeam = teams[1].Groups[1].ToString();
                var seconds = secondsTeam.ToCharArray().Reverse().ToArray();
                var nameSeconds = new string(seconds);
                nameSeconds = nameSeconds.ToUpper();
                Match goal = Regex.Match(input, paterrenGoal);
                ulong firstGoal = ulong.Parse(goal.Groups[1].Value);
                ulong secondGoal = ulong.Parse(goal.Groups[2].Value);
                ulong pointFirst = 0;
               ulong pointSecond = 0;
                if (firstGoal>secondGoal)
                {
                    pointFirst = 3; 
                }
                else if (firstGoal==secondGoal)
                {
                    pointFirst = 1;
                    pointSecond = 1;
                }
                else
                {
                    pointSecond = 3;
                }
                if (!teamPoint.ContainsKey(nameFirst))
                {
                    teamPoint.Add(nameFirst, pointFirst);
                    teamGoal.Add(nameFirst, firstGoal);
                }
                else
                {
                    teamPoint[nameFirst] += pointFirst;
                    teamGoal[nameFirst] += firstGoal;
                }
                if (!teamPoint.ContainsKey(nameSeconds))
                {
                    teamPoint.Add(nameSeconds, pointSecond);
                    teamGoal.Add(nameSeconds, secondGoal);
                }
                else
                {
                    teamPoint[nameSeconds] += pointSecond;
                    teamGoal[nameSeconds] += secondGoal;
                }

            }
            int count = 1;
            Console.WriteLine("League standings:");
            foreach (var item in teamPoint.OrderByDescending(x=>x.Value).ThenBy(z=>z.Key))
            {
                Console.WriteLine($"{count}. {item.Key} {item.Value}");
                count++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in teamGoal.OrderByDescending(s=>s.Value).ThenBy(d=>d.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value}");
            }
        }
    }
}
