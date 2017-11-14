using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Manipulate_Array
{
    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ' });
            int numCommand = int.Parse(Console.ReadLine());

            string[] result;
            int count = 0;
            
            while (count != numCommand)
            {
                
                string[] comand = Console.ReadLine()
                    .Split(new char[] { ' ' });
                if (comand[0]=="Reverse")
                {
                    Array.Reverse(input);
                }
                else if (comand[0] == "Distinct")
                {
                    input = input.Distinct().ToArray();
                    
                }
                else if (comand[0]== "Replace")
                {
                    int numArr =int.Parse(comand[1]);
                    input[numArr] = comand[2];
                }
                count++;
            }
            Console.WriteLine(String.Join(", ",input));
        }
    }
}
