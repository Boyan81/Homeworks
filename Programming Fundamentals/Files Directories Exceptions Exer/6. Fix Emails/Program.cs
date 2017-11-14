﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace _6.Fix_Emails
{
    class Program
    {
        static void Main()
        {
            string[] line = File.ReadAllLines(@"..\..\input.txt");
            string outputName = NameOutput();

            for (int i = 0; i < line.Length; i+=2)
            {
                if (line[i]=="stop"||line[i+1]=="stop")
                {
                    break;
                }
                string name = line[i];
                string email = line[i + 1];
                if (email.EndsWith(".us")||email.EndsWith(".uk"))
                {
                    continue;
                }
                string output = $"{name} -> {email}"+Environment.NewLine;

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
