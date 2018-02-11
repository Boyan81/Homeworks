using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, long>> train = new Dictionary<string, Dictionary<string, long>>();
            string input = "";

            while ((input = Console.ReadLine())!= "It's Training Men!")
            {
                string[] tokens = input
                    .Split(new string[] { " ", "-", ":", ">", "=" }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length==2)
                {
                    string[] cmd = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string firstTrain = cmd[0];
                    string command = cmd[1];
                    string secondTrain = cmd[2];
                    if (command=="->")
                    {
                        if (!train.ContainsKey(firstTrain))
                        {
                            train.Add(firstTrain, new Dictionary<string, long>());
                        }
                        foreach (var item in train[secondTrain])
                        {
                            train[firstTrain].Add(item.Key, item.Value);
                        }
                        train.Remove(secondTrain);
                    }
                    if (command=="=")
                    {
                        if (!train.ContainsKey(firstTrain))
                        {
                            train.Add(firstTrain, new Dictionary<string, long>());
                        }
                        train[firstTrain] = train[secondTrain];
                    }
                }
                else
                {
                    string trainName = tokens[0];
                    string wagonName = tokens[1];
                    long wagonPower = long.Parse(tokens[2]);
                    if (!train.ContainsKey(trainName))
                    {
                        train.Add(trainName, new Dictionary<string, long>());
                        train[trainName].Add(wagonName, wagonPower);
                    }
                    else
                    {
                        if (!train[trainName].ContainsKey(wagonName))
                        {
                            train[trainName].Add(wagonName, wagonPower);
                        }
                        else
                        {
                            train[trainName][wagonName] += wagonPower;
                        }
                    }
                }
            }
            var result = train.OrderByDescending(e => e.Value.Values.Sum()).ThenBy(a=>a.Value.Count);
            foreach (var item in result)
            {
                Console.WriteLine($"Train: {item.Key}");
                foreach (var wagon in item.Value.OrderByDescending(e=>e.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
            
        }
    }
}
