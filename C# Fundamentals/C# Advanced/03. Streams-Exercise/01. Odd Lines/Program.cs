using System;
using System.IO;
namespace _01._Odd_Lines
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = new StreamReader("../Resources/text.txt");

            using (reader)
            {
                int lineNum = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (lineNum % 2 != 0)
                    {
                        Console.WriteLine(line);
                    }
                    lineNum++;
                }
            }
        }
    }
}
