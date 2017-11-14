using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main()
        {
            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();

            char[] alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(97 + i);
            }
            for (int i = 0; i < line.Length; i++)
            {
                
                char[] curentLine = line[i].ToArray();
                if (curentLine.Length == 0)
                {
                    continue;
                }

                for (int j = 0; j <curentLine.Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (curentLine[j]==alphabet[k])
                        {
                            string output = $"{(char)curentLine[j]} -> {k}" + Environment.NewLine;
                            File.AppendAllText(outputName, output);
                        }
                    }
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
