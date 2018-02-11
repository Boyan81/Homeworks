using System;
using System.IO;
namespace _02._Line_Numbers
{
    class Program
    {
        static void Main()
        {

            using (StreamReader reader = new StreamReader("../Resources/text.txt"))
            {
                using (var writer = new StreamWriter("../Resources/output.txt"))
                {
                    int lineNum = 1;
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"Line {lineNum}: {line}");
                        lineNum++;

                    }
                }
            }

        }
    }
}
