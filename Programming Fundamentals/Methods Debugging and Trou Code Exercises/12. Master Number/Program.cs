using System;

namespace _12._Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                if (ContainsEvenDigit(i) && SumOfDigits(i) && IsPalindrome(i.ToString()))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            bool even = false;
            while (num!=0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                     even = true;
                }
                num /= 10;
            }
            return even;
        }

        static bool SumOfDigits(int num)
        {
            string number = num.ToString();
            ushort sum = 0;
            for (ushort i = 0; i <number.Length; i++)
            {
                sum += ushort.Parse(number[i].ToString());
            }
            if (sum%7==0)
            {
                return true;
            }
            return false;
        }

        static bool IsPalindrome(string num)
        {
            for (int i = 0; i < num.Length/2; i++)
            {
                //проверка за симетричност на масив 
                if (num[i]==num[num.Length-1-i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
