using System;

namespace _0_3._Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int grupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();

            string hall = null;
            double priceHall = 0.0;
            double discount = 0.0;
            double priceOFpackage = 0.0; 
            double pricePerPerson = 0.0;

            switch (package)
            {
                case "platinum":
                    discount = 0.85;
                    priceOFpackage = 1000.0;
                    break;
                case "gold":
                    discount = 0.90;
                    priceOFpackage = 750.0;
                    break;
                case "normal":
                    discount = 0.95;
                    priceOFpackage = 500.0;
                    break;
            }

            if (grupSize > 100 && grupSize <= 120)
            {
                hall = "Great Hall";
                priceHall = 7500.0;
                pricePerPerson = (priceHall + priceOFpackage) * discount / grupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }
            else if (grupSize > 50 && grupSize <= 100)
            {
                hall = "Terrace";
                priceHall = 5000.0;
                pricePerPerson = (priceHall + priceOFpackage) * discount / grupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (grupSize > 0 && grupSize <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500.0;
                pricePerPerson = (priceHall + priceOFpackage) * discount / grupSize;
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

        }
    }
}
