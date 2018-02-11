using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Wormtest
{
    class Program
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());
            double width= double.Parse(Console.ReadLine());
            double miterOfSm = lenght * 100;

            if (miterOfSm%width==0||width==0)
            {
                Console.WriteLine($"{miterOfSm*width:f2}");
            }
            else
            {
                double precent = miterOfSm / (width / 100);
                Console.WriteLine($"{precent:f2}%");
            }

        }
    }
}
