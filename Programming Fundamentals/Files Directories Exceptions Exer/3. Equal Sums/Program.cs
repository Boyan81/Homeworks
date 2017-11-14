using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _3.Equal_Sums
{
    class Program
    {
        static void Main()
        {
            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();
            for (int readLine = 0; readLine <line.Length; readLine++)
            {
                int[] inputArr = line[readLine]
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (inputArr.Length == 0)
                {
                    continue;
                }
                bool isFindEqual = false;
                for (int i = 0; i < inputArr.Length; i++)
                {
                    int[] leftArr = inputArr.Take(i).ToArray();
                    int[] right = inputArr.Skip(i + 1).ToArray();
                    if (leftArr.Sum() == right.Sum())
                    {
                        File.AppendAllText(outputName, $"{i}");
                        isFindEqual = true;
                        break;
                    }
                }
                if (!isFindEqual)
                {
                    File.AppendAllText(outputName, "no");
                }
                File.AppendAllText(outputName,Environment.NewLine);
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
