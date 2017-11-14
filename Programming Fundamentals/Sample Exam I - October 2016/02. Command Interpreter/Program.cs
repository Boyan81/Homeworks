using System;
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
            List<string> list = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arr = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string cmd = arr[0];
                if (ValidComand(arr,list))
                {
                    switch (cmd)
                    {
                        case "reverse":
                            Reverse(list, arr);
                            break;
                        case "sort":
                            Sort(list, arr);
                            break;
                        case "rollLeft":
                            RollLeft(list, arr);
                            break;
                        case "rollRight":
                            RollRight(list, arr);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input parameters.");
                }
            }
            Console.WriteLine($"[{String.Join(", ",list)}]");
        }
        
        private static void RollRight(List<string> list, string[] arr)
        {
            int count = int.Parse(arr[1]);
            for (int i = count - 1; i >= 0; i--)
            {
                string temp = list[list.Count-1];
                list.RemoveAt(list.Count-1);
                list.Insert(0,temp);
            }

        }

        private static void RollLeft(List<string> list, string[] arr)
        {
            int count = int.Parse(arr[1]);
            for (int i = 0; i <count; i++)
            {
                string temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }

        }

        private static void Sort(List<string> list, string[] arr)
        {
            int index = int.Parse(arr[2]);
            int count = int.Parse(arr[4]);
            list.Sort(index, count,null);
        }

        private static void Reverse(List<string> list, string[] arr)
        {
            int index = int.Parse(arr[2]);
            int count = int.Parse(arr[4]);
            list.Reverse(index, count);
        }

        private static bool ValidComand(string[] arr,List<string>list)
        {
           
            if (arr.Length == 5)
            {
                int index = int.Parse(arr[2]);
                int count = int.Parse(arr[4]);

                if (index < 0 || index > list.Count - 1 || count + index > list.Count || count < 0)
                {
                    return false;
                }
            }
            else if (arr.Length == 3)
            {
                int countRL = int.Parse(arr[1]);
                if (countRL < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
