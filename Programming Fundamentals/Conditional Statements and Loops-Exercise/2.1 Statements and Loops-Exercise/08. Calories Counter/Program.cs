using System;

namespace _08._Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumCalories = 0;
            for (int i = 0; i < n; i++)
            {
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients == "cheese")
                {
                    sumCalories += 500;
                }
                else if (ingredients == "tomato sauce")
                {
                    sumCalories += 150;
                }
                else if (ingredients == "salami")
                {
                    sumCalories += 600;
                }
                else if (ingredients == "pepper")
                {
                    sumCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {sumCalories}");
        }
    }
}
