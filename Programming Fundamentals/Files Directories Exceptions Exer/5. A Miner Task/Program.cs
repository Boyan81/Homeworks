using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace _5.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();

            Dictionary<string, long> mine = new Dictionary<string, long>();

            for (int readLine = 0; readLine < line.Length - 1; readLine += 2)
            {

                string input = line[readLine].Trim();
                if (input == "")
                {
                    continue;
                }
                if (line[readLine] == "stop" || line[readLine + 1] == "stop")
                {
                    break;
                }

                if (!mine.ContainsKey(input))
                {
                    mine.Add(input, long.Parse(line[readLine + 1]));
                }

                else
                {
                    mine[input] += long.Parse(line[readLine + 1]);
                }

            }
            foreach (var item in mine)
            {
                string output = $"{item.Key} -> {item.Value}" + Environment.NewLine;
                File.AppendAllText(outputName, output);
            }

        }
        private static string NameOutput()
        {
            var number = Directory.GetFiles(@"..\..\")//-текуща директория кадето са фаиловете
                .Where(f => f.StartsWith(@"..\..\output"))//-намираме всички фаилове които стартират с output
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())//-
                .Where(f => f != null)//-
                .Select(f => f.Replace(".txt", ""))//-
                .Select(int.Parse);

            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            string outputName = @"..\..\output_" + nextNumber + ".txt";
            return outputName;
        }
    }
}
