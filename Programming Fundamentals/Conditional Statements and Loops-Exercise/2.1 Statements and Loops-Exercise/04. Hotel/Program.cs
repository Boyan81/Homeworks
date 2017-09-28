using System;

class Program
{
    static void Main()
    {
        string month = Console.ReadLine();
        int numNights = int.Parse(Console.ReadLine());
        double priceStudio = 0.0;
        double priceDouble = 0.0;
        double priceSuite = 0.0;
        if (month == "May" || month == "October")
        {
            priceStudio = 50.00;
            priceDouble = 65.00;
            priceSuite = 75.00;
            if (numNights > 7)
            {
                priceStudio = 50.00 * 0.95;
            }
        }
        else if (month == "June" || month == "September")
        {
            priceStudio = 60.00;
            priceDouble = 72.00;
            priceSuite = 82.00;
            if (numNights > 14)
            {
                priceDouble = 72.00 * 0.9;
            }
        }
        else if (month == "July" || month == "August" || month == "December")
        {
            priceStudio = 68.00;
            priceDouble = 77.00;
            priceSuite = 89.00;
            if (numNights > 14)
            {
                priceSuite = 89.00 * 0.85;
            }
        }
        double totalPriceStudio = priceStudio * numNights;
        double totalPriceDouble = priceDouble * numNights;
        double totalPriceSuite = priceSuite * numNights;

        if ((month == "September" || month == "October") && numNights > 7)
        {
            totalPriceStudio = priceStudio * (numNights - 1);
        }
        Console.WriteLine("Studio: {0:f2} lv.", totalPriceStudio);
        Console.WriteLine("Double: {0:f2} lv.", totalPriceDouble);
        Console.WriteLine("Suite: {0:f2} lv.", totalPriceSuite);
    }
}