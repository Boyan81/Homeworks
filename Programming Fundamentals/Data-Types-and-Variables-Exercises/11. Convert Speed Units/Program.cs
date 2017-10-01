using System;

namespace _11._Convert_Speed_Units
{
    class Program
    {
        static void Main()
        {
            
            uint miter = uint.Parse(Console.ReadLine());
            byte hour = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());

            ushort taim = (ushort)(hour * 3600 + minutes * 60 + seconds);
            float miterPerSeconds = (float)miter / taim;
            float kilomiterPerHour = ((float)miter / 1000) / ((float)taim / 3600);
            float milePerHour = ((float)miter / 1609) / ((float)taim / 3600);
            Console.WriteLine($"{miterPerSeconds}");
            Console.WriteLine($"{kilomiterPerHour}");
            Console.WriteLine($"{milePerHour}");
        }
    }
}
