using System;
using System.Linq;
using System.IO;

namespace _1.Most_Frequent_Number
{
    class Program
    {
        static void Main()
        {
            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();

            for (int i = 0; i < line.Length; i++)
            {
                int[] curenLine = line[i]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (curenLine.Length == 0)
                {
                    continue;
                }

                int count = 0;
                int bestCount = 0;
                int bestNum = 0;

                for (int j = 0; j < curenLine.Length; j++)
                {
                    count = 0;

                    for (int k = 0; k < curenLine.Length; k++)
                    {
                        if (curenLine[j] == curenLine[k])
                        {
                            count++;
                        }

                    }
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestNum = curenLine[j];
                    }

                }
                string output = $"{bestNum}" + Environment.NewLine;
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
