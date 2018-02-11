using System;
using System.Linq;
using System.Collections.Generic;
namespace _05._Filter_By_Age
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, int> peoples = new Dictionary<string, int>();

            for (int i = 0; i <count; i++)
            {
                string[] nameAndAge = Console.ReadLine()
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                if (!peoples.ContainsKey(nameAndAge[0]))
                {
                    peoples.Add(nameAndAge[0], int.Parse(nameAndAge[1]));
                }
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            peoples.Where(CreatFilter(condition, age)).ToList().ForEach(Print(format));

        }
        static Func<KeyValuePair<string,int>,bool>CreatFilter(string condition,int age)
        {
            if (condition== "younger")
            {
                return x => x.Value < age;
            }
            else
            {
                return x => x.Value >= age;
            }
        }
        static Action<KeyValuePair<string,int>>Print(string format)
        {
            switch (format)
            {
                case "name":
                    return x=>Console.WriteLine(x.Key);
                case "age":
                    return x => Console.WriteLine(x.Value);
                case "name age":
                    return x => Console.WriteLine($"{x.Key} - {x.Value}");
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
