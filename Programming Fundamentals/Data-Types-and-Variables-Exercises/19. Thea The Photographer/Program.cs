using System;

namespace _19._Thea_The_Photographer
{
    class Program
    {
        static void Main()
        {
            long pictures = long.Parse(Console.ReadLine());
            long filterTimePerPicture = long.Parse(Console.ReadLine());
            long filterPrecentPerGood = long.Parse(Console.ReadLine());
            long timeUploadPerPicture = long.Parse(Console.ReadLine());

            long timFilterAllPicture = pictures * filterTimePerPicture;
            long pictureGood = (long)Math.Ceiling(filterPrecentPerGood / 100.0 * pictures);
            long totalSecond = timFilterAllPicture + pictureGood * timeUploadPerPicture;

            long minets = 0;
            long hour = 0;
            long day = 0;

            // използва повече време при копилиране
            //while (totalSecond > 59)
            //{
            //    totalSecond -= 60;
            //    minets++;
            //    if (minets > 59)
            //    {
            //        minets -= 60;
            //        hour++;
            //    }
            //    if (hour > 23)
            //    {
            //        hour -= 24;
            //        day++;
            //    }
            //}
            //Console.WriteLine($"{day}:{hour:d2}:{minets:d2}:{totalSecond:d2}");

            TimeSpan timeSpan = TimeSpan.FromSeconds(totalSecond);
            string allTime = timeSpan.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(allTime);
        }
    }
}
