using System;
using System.Linq;

namespace _05._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string comand = Console.ReadLine();

            while (comand!= "print")
            {
                var comandArr = comand.Split(new char[] { ' ' }
                           , StringSplitOptions.RemoveEmptyEntries)
                           .ToArray();

                if (comandArr[0]== "add")
                {
                    number.Insert(int.Parse(comandArr[1]), int.Parse(comandArr[2]));
                }
                else if (comandArr[0] == "addMany")
                {
                    var colection = comandArr.Skip(2).Select(int.Parse).ToArray();
                    number.InsertRange(int.Parse(comandArr[1]), colection);
                }
                else if (comandArr[0] == "contains")
                {
                    int num = int.Parse(comandArr[1]);
                    Console.WriteLine(number.IndexOf(num));
                }
                else if (comandArr[0] == "remove")
                {
                    number.RemoveAt(int.Parse(comandArr[1]));
                }
                else if (comandArr[0] == "shift")
                {
                    int num = int.Parse(comandArr[1]);
                    num = num % number.Count;//
                    var temp = number.Take(num).ToList();
                    number.RemoveRange(0, num);
                    number.AddRange(temp);
                }
                else if (comandArr[0] == "sumPairs")
                {
                    for (int i = 0; i < number.Count-1; i++)
                    {
                        var sum = number[i] + number[i + 1];
                        number[i] = sum;
                        number.RemoveAt(i + 1);
                    }
                }

                comand = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ",number)}]");


        }
    }
}
