using System;
using System.Linq;
namespace _03._Count_Uppercase_Words
{
    class Program
    {
        static void Main()
        {
            Func<string, bool> checker = s => char.IsUpper(s[0]);
            Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Where(checker)
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
