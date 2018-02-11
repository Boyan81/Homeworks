using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Trainegram
{
    class Program
    {
        static void Main()
        {
            string input;
            string pattern = @"^(<\[[^A-Za-z0-9\n]*]\.)(\.\[[A-Za-z0-9]*]\.)*$";
            List<string> result = new List<string>();
            
            while ((input=Console.ReadLine())!= "Traincode!")
            {

                if (Regex.IsMatch(input,pattern))
                {
                    result.Add(input);
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
