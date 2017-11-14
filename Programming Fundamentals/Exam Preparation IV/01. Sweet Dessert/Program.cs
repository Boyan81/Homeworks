using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main()
        {
            decimal monyIvancho = decimal.Parse(Console.ReadLine());
            int numGuests = int.Parse(Console.ReadLine());
            decimal priceBananas = decimal.Parse(Console.ReadLine());
            decimal priceEggs = decimal.Parse(Console.ReadLine());
            decimal priceBerries = decimal.Parse(Console.ReadLine());
           // BigInteger monyProduct = new BigInteger();
           
            int porcion = (int)Math.Ceiling((decimal)numGuests / 6);
            //if (porcion==0)
            //{
            //    porcion = 1;
            //}
            decimal monyProduct = (2*priceBananas + 4*priceEggs  + 0.2m*priceBerries) * porcion;
            if (monyIvancho>=monyProduct)
            {
                //decimal outMony = Math.Abs(monyProduct - monyIvancho);
                Console.WriteLine($"Ivancho has enough money - it would cost {monyProduct:f2}lv.");
            }
            else
            {
                decimal outMony = 0.0m;
                outMony  = (decimal)(monyProduct - monyIvancho);
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {outMony:f2}lv more.");
            }

        }
    }
}
