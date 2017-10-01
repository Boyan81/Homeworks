using System;

namespace _10._Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            int minutes = hours * 60;
            ulong second = (ulong)minutes * 60;
            ulong milliSeconds = second * 1000;
            decimal microSeconds = milliSeconds * 1000;
            decimal nanoSeconds = microSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {second} seconds = {milliSeconds} milliseconds = {microSeconds} microseconds = {nanoSeconds} nanoseconds");

        }
    }
}
