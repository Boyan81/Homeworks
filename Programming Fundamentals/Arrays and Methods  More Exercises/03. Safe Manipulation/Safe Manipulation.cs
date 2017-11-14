using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Safe_Manipulation
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' });
           
            string[] result;
            string[] comand = Console.ReadLine()
                    .Split(new char[] { ' ' });

            while (comand[0] != "END")
            {
                if (comand[0] == "Reverse")
                {
                    Array.Reverse(input);
                }
                else if (comand[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();

                }
                else if (comand[0] == "Replace")
                {
                    int numArr = int.Parse(comand[1]);
                    if (numArr>comand.Length-1||numArr<0)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        input[numArr] = comand[2];
                    }
                    
                    
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                comand = Console.ReadLine()
                    .Split(new char[] { ' ' });

            }
            Console.WriteLine(String.Join(", ", input));
        }
    }
}
