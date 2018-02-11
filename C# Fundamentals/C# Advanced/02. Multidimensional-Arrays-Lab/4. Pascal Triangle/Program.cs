using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Pascal_Triangle
{
    class Program
    {
        static void Main()
        {
            long hight = long.Parse(Console.ReadLine());
            long[][] triagle = new long[hight][];

            for (long curentHeight = 0; curentHeight < hight; curentHeight++)
            {
                triagle[curentHeight] = new long[curentHeight+1];
                triagle[curentHeight][0] = 1;
                triagle[curentHeight][curentHeight] = 1;
               
                if (curentHeight >= 2)
                {
                    for (long widthCount = 1; widthCount < curentHeight; widthCount++)
                    {
                        triagle[curentHeight][widthCount] = triagle[curentHeight - 1][widthCount - 1] +
                                                          triagle[curentHeight - 1][widthCount];

                    }
                }
            }
            for (long row = 0; row < triagle.Length; row++)
            {
                Console.WriteLine(String.Join(" ",triagle[row]));
            }
        }
    }
}
