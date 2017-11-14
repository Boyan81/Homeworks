using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            long opereitet = long.Parse(Console.ReadLine());
            long secondPerOpereit = long.Parse(Console.ReadLine());

            ulong allSecond = (ulong)opereitet * (ulong)secondPerOpereit;
            var secondTime = (ulong)(dateTime.Hour * 3600) + (ulong)(dateTime.Minute * 60) + (ulong)dateTime.Second;
            var totalSecond = allSecond + secondTime;
            var seconds = totalSecond % 60;
            var totalMinets = totalSecond / 60;
            var minets = totalMinets % 60;
            var totalHour = totalMinets / 60;
            var hour = totalHour % 24;

            Console.WriteLine($"Time Arrival: {hour:00}:{minets:00}:{seconds:00}");
        }
    }
}
