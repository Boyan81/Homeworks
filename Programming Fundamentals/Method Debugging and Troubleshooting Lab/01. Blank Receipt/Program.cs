using System;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void Main()
        {
            PrintReceiptMethod();
        }

         static void PrintReceiptMethod()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("\u00A9"+ " SoftUni");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
    }
}
