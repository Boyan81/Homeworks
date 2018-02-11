using System;
using System.Collections.Generic;
using System.Text;

namespace BashSoft
{
    public static class StudentsRepository
    {
        public static bool isDataInitialized = false;
        private static Dictionary<string, Dictionary<string, List<int>>> studentsByCurse;

        public static void InitializeData()
        {
            if (!isDataInitialized)
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...!");
                studentsByCurse = new Dictionary<string, Dictionary<string, List<int>>>();
                ReadDta();
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.DataAlreadyInitalisedException);
            }
        }

        private static void ReadDta()
        {
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split(' ');
                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);

                if (!studentsByCurse.ContainsKey(course))
                {
                    studentsByCurse.Add(course, new Dictionary<string, List<int>>());
                }
                if (!studentsByCurse[course].ContainsKey(student))
                {
                    studentsByCurse[course].Add(student, new List<int>());
                }
                studentsByCurse[course][student].Add(mark);
                input = Console.ReadLine();
            }
            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }
    }
}
