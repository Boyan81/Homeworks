using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _4.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();

            for (int readLine = 0; readLine < line.Length; readLine++)
            {

                int[] arr = line[readLine]
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray();

                if (arr.Length==0)
                {
                    continue;
                }

                int lent = 0;
                int bestLen = 0;
                int bestStart = 0;

                for (int i = 0; i < arr.Length - 1; i++)
                {

                    if (arr[i] == arr[i + 1])
                    {
                        lent++;

                        if (lent > bestLen)
                        {
                            bestLen = lent;
                            bestStart = i - lent;
                        }
                    }
                    else
                    {
                        lent = 0;
                    }

                }
                for (int i = bestStart + 1; i <= bestLen + bestStart + 1; i++)
                {
                    File.AppendAllText(outputName,arr[i] + " ");
                }
                File.AppendAllText(outputName, Environment.NewLine);

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
