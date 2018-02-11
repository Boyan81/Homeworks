using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            List<string> webSite = new List<string>();
            decimal totalLoss = 0.0m;
            for (int i = 0; i < n; i++)
            {
                string[] inputWeb = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                webSite.Add(inputWeb[0]);
                decimal siteVisits = decimal.Parse(inputWeb[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(inputWeb[2]);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
            }
            foreach (var item in webSite)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {BigInteger.Pow(securityKey,n)}");

        }
    }
}
