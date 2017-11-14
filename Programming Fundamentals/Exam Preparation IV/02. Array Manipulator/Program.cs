using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            List<long> arr = Console.ReadLine()
                .Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            string cmd;

            while ((cmd = Console.ReadLine())!="end")
            {
                string[] command = cmd.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (command[0])
                {
                    case "exchange":
                        int index = int.Parse(command[1]);
                        Exchange(arr, index);
                        break;
                    case "max":
                        string oddEvenMax = command[1];
                        MaxOddEven(arr, oddEvenMax);
                        break;
                    case "min":
                        string oddEvenMin = command[1];
                        MinOddEven(arr, oddEvenMin);
                        break;
                    case "first":
                        int countFirst = int.Parse(command[1]);
                        string firstOddEven = command[2];
                        FirstCount(arr, countFirst, firstOddEven);
                        break;
                    case "last":
                        int countLast = int.Parse(command[1]);
                        string lastOddEven = command[2];
                        LastCount(arr, countLast, lastOddEven);
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine($"[{String.Join(", ",arr)}]");
        }

        public static void LastCount(List<long> arr, int countLast, string lastOddEven)
        {
            if (!(countLast > arr.Count))
            {
                List<long> odd = arr.Where(x => x % 2 != 0).ToList();
                List<long> even = arr.Where(x => x % 2 == 0).ToList();
                if (lastOddEven == "odd")
                {
                    if (odd.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else if (countLast > odd.Count)
                    {
                        Console.WriteLine($"[{String.Join(", ", odd)}]");
                    }
                    else
                    {
                        List<long> temp = odd.Skip(odd.Count-countLast).Take(countLast).ToList();
                        Console.WriteLine($"[{String.Join(", ", temp)}]");
                    }
                }
                else if (lastOddEven == "even")
                {
                    if (even.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else if (countLast > even.Count)
                    {
                        Console.WriteLine($"[{String.Join(", ", even)}]");
                    }
                    else
                    {
                        List<long> temp = even.Skip(even.Count - countLast).Take(countLast).ToList();
                        Console.WriteLine($"[{String.Join(", ", temp)}]");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid count");
            }

        }

        public static void FirstCount(List<long> arr, int countFirst, string firstOddEven)
        {
            if (!(countFirst > arr.Count))
            {
                List<long> odd = arr.Where(x => x % 2 != 0).ToList();
                List<long> even = arr.Where(x => x % 2 == 0).ToList();
                if (firstOddEven == "odd")
                {
                    if (odd.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else if (countFirst > odd.Count)
                    {
                        Console.WriteLine($"[{String.Join(", ", odd)}]");
                    }
                    else
                    {
                        List<long> temp = odd.Take(countFirst).ToList();
                        Console.WriteLine($"[{String.Join(", ", temp)}]");
                    }
                }
                else if (firstOddEven == "even")
                {
                    if (even.Count == 0)
                    {
                        Console.WriteLine("[]");
                    }
                    else if (countFirst > even.Count)
                    {
                        Console.WriteLine($"[{String.Join(", ", even)}]");
                    }
                    else
                    {
                        List<long> temp = even.Take(countFirst).ToList();
                        Console.WriteLine($"[{String.Join(", ", temp)}]");
                    }
                }

            }
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

        private static void MinOddEven(List<long> arr, string oddEvenMin)
        {
            List<long> filter = new List<long>();
            if (oddEvenMin == "odd")
            {
                filter = arr.Where(x => x % 2 != 0).ToList();
            }
            else if (oddEvenMin == "even")
            {
                filter = arr.Where(x => x % 2 == 0).ToList();
            }
            if (filter.Count != 0)
            {
                long min = filter.Min();
                Console.WriteLine(arr.LastIndexOf(min));
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        private static void MaxOddEven(List<long> arr, string oddEven)
        {
            List<long> filter = new List<long>();
            if (oddEven=="odd")
            {
                filter = arr.Where(x => x % 2 != 0).ToList();
            }
            else if(oddEven=="even")
            {
                filter = arr.Where(x => x % 2 == 0).ToList();
            }
            if (filter.Count!=0)
            {
                long max = filter.Max();
                Console.WriteLine(arr.LastIndexOf(max));
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }

        private static void Exchange(List<long> arr, int index)
        {
            if (index<0||index>arr.Count-1)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                long[] temp = new long[index + 1];
                for (int i = 0; i <= index; i++)
                {
                    temp[i] = arr[i];
                }
                arr.RemoveRange(0, index + 1);
                arr.AddRange(temp);
            }
        }
    }
}
