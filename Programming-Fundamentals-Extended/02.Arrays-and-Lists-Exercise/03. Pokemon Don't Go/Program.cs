using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main()
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<long> result = new List<long>();

            while (array.Count != 0)
            {
                int index = int.Parse(Console.ReadLine());
                int temp=0;
                if (index > array.Count - 1)
                {
                    array[array.Count - 1] = array[0];
                    index = array.Count - 1;
                    temp = array[index];
                    ArrayManipulator(array, temp);
                    result.Add(temp);
                }
                else if (index < 0)
                {
                    array[0] = array[array.Count - 1];
                    index = 0; temp = array[index];
                    temp = array[index];
                    ArrayManipulator(array, temp);
                    result.Add(temp);
                }
                else
                {
                    temp = array[index];
                    ArrayManipulator(array, temp);
                    result.Add(temp);
                    array.RemoveAt(index);
                }




            }
            Console.WriteLine(result.Sum());

        }

        private static void ArrayManipulator(List<int> array, int temp)
        {
            for (int i = 0; i < array.Count; i++)
            {

                if (array[i] <= temp)
                {
                    array[i] += temp;
                }
                else
                {
                    array[i] -= temp;
                }

            }
        }
    }
}
