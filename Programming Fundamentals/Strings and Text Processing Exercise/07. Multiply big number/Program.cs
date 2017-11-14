using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string inNum = Console.ReadLine().Trim(' ');
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            int temp = 0;
            int rem = 0;
            for (int i = inNum.Length - 1; i >= 0; i--)
            {
                
                temp = (inNum[i]-48) * multiplier+rem;
                if (temp>9)
                {
                    result.Append((temp % 10).ToString());
                    rem = temp / 10;
                }
                else
                {
                    result.Append((temp).ToString());
                    rem = 0;
                }
            }
            if (rem>0)
            {
                result.Append(rem.ToString());
            }
            
            string outResult = new string( result.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
            if (outResult==string.Empty)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(outResult);
            }
            
        }
    }
}
