using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Command_Interpreter
{
    class Program
    {
        static void Main()
        {
            List<string> item = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                var cmdComand = input.Split(' ').ToArray();
                var cmdName = cmdComand[0];
                switch (cmdName)
                {
                    case "reverse":
                        ReversItem(cmdComand, item);
                        break;
                    case "sort":
                        SortItem(cmdComand, item);
                        break;
                    case "rollLeft":
                        RollLeft(cmdComand, item);
                        break;
                    case "rollRight":
                        RollRight(cmdComand, item);
                        break;
                    default:
                        Console.WriteLine("Invalid input parameters.");
                        break;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", item)}]");

        }

        static void RollRight(string[] cmdComand, List<string> item)
        {
            int count = int.Parse(cmdComand[1]);
            
            for (int i = 0; i < count; i++)
            {
                string temp = item[item.Count-1];
                item.Remove(item[item.Count - 1]);
                item.Insert(0,temp);
            }
            
        }

        static void RollLeft(string[] cmdComand, List<string> item)
        {
            int count = int.Parse(cmdComand[1]);

            for (int i = 0; i < count; i++)
            {
                string temp = item[0];
                item.Remove(item[0]);
                item.Add(temp);
            }
        }

        static void SortItem(string[] cmdComand, List<string> item)
        {
            int startIndex = int.Parse(cmdComand[2]);
            int count = int.Parse(cmdComand[4]);
            if (InValidCmd(startIndex, count, item))
            {
                Sort(startIndex, count, item);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

        }

         static void Sort(int startIndex, int count, List<string> item)
        {
            item.Sort(startIndex, count, null);
        }

        static void ReversItem(string[] cmdComand, List<string> item)
        {
            int startIndex = int.Parse(cmdComand[2]);
            int count = int.Parse(cmdComand[4]);
            if (InValidCmd(startIndex, count, item))
            {
                Revers(startIndex, count, item);
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
            }

        }

        static void Revers(int startIndex, int count, List<string> item)
        {
            var endIndex = startIndex + count - 1;
            while (startIndex < endIndex)
            {
                var temp = item[startIndex];
                item[startIndex] = item[endIndex];
                item[endIndex] = temp;
                endIndex--;
                startIndex++;
            }
        }

        static bool InValidCmd(int startIndex, int count, List<string> item)
        {
            if (startIndex < 0 || count <= 0)
            {
                return false;
            }
            if (startIndex + count-1 >= item.Count||startIndex>item.Count)
            {
                return false;
            }
            return true;

        }
    }
}
