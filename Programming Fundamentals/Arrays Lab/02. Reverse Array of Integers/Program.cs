using System;

namespace _02._Reverse_Array_of_Integers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];


            for (int i = 0; i < arr.Length; i++)
            {

                arr[arr.Length - 1 - i] = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ",arr));
        }
           
    }
}
