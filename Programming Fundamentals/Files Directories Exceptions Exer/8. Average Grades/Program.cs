using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace _8.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Greyds { get; set; }
        public double Average
        {
            get
            {
                return Greyds.Average();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            string outputName = NameOutput();

            while (!reader.EndOfStream)
            {
            int n = int.Parse(reader.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();
                string[] input = reader.ReadLine().Split();
                student.Name = input[0];
                student.Greyds = input.Skip(1).Select(double.Parse).ToList();
                students.Add(student);
            }

            students.Where(s => s.Average >= 5.00)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.Average)
                .ToList()
                .ForEach(s => File.AppendAllText(outputName,$"{s.Name} -> {s.Average:f2}"+Environment.NewLine));
            }
            reader.Close();

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
