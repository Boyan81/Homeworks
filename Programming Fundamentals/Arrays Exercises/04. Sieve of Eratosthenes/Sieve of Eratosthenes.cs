using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input: an integer n > 1.

            //Let A be an array of Boolean values, indexed by integers 2 to n,
            //initially all set to true.

            //for i = 2, 3, 4, ..., not exceeding √n:
            // if A[i] is true:
            // for j = i2, i2 + i, i2 + 2i, i2 + 3i, ..., not exceeding n:
            // A[j] := false.

            //Output: all i such that A[i] is true.
            int n = int.Parse(Console.ReadLine());

            bool[] prime = new bool[n + 1];
            for (int i = 2; i < prime.Length; i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (prime[i])
                {
                    for (int j = i * i; j < prime.Length; j += i)
                    {
                        prime[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 2; i < prime.Length; i++)
            {
                if (prime[i])
                {
                    result.Add(i);
                }
            }
            Console.WriteLine($"{String.Join(" ", result)}");
        }
    }
}
