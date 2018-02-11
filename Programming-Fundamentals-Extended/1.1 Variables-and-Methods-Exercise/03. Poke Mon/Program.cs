using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());
            int precent = N / 2;
            int count = 0;
            while (N>=M)
            {
                N -= M;
                if (N==precent)
                {
                    if (Y>0)
                    {
                        N /= Y;
                    }
                }
                count++;
            }
            Console.WriteLine(N);
            Console.WriteLine(count);

        }
    }
}
