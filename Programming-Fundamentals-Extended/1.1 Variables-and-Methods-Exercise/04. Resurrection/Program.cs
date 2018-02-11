using System;
using System.Collections.Generic;

public class Program
{
    static void Main()
    {
        int numPhoenixe = int.Parse(Console.ReadLine());
       

        for (int i = 0; i < numPhoenixe; i++)
        {
            long totalLength = long.Parse(Console.ReadLine());
            decimal totalWidth = decimal.Parse(Console.ReadLine());
            long wingLength = long.Parse(Console.ReadLine());
            decimal totalYears = (totalLength *totalLength) * (totalWidth +(2 * wingLength));

            Console.WriteLine(totalYears);
        }
    }
}

