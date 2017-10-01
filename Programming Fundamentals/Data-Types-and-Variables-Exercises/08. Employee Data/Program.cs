using System;

namespace _08._Employee_Data
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            sbyte age = sbyte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            ulong personalId = ulong.Parse(Console.ReadLine());
            uint employeeNumber = uint.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {personalId}");
            Console.WriteLine($"Unique Employee number: {employeeNumber}");

        }
    }
}
