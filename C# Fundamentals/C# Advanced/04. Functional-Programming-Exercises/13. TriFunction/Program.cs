using System;
using System.Collections.Generic;
using System.Linq;

namespace _13._TriFunction
{
    class Program
    {
        static void Main()
        {
            int sumInput = int.Parse(Console.ReadLine());
            List<string> nams = Console.ReadLine().Split().ToList();

            //Func<string, int, bool> filter = (name, sum) => name.ToCharArray().Sum(c => c) >= sumInput;//tow rezult
            var filter = CreatFunction(sumInput);
            Console.WriteLine(nams.FirstOrDefault(filter));//Filter==//name =>filter(name,sumInput)//tow rezult

            //Console.WriteLine(nams.FirstOrDefault(name =>name.ToCharArray().Sum(c=>c)>=sumInput));//one row rezult
        }
        static Func<string, bool> CreatFunction(int sumInput)
        {
            return name => name.ToCharArray().Sum(c => c) >= sumInput;
        }
    }
}
