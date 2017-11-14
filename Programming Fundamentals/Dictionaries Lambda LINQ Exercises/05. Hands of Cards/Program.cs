using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> gamers = new Dictionary<string, List<string>>();

            while (input != "JOKER")
            {

                string[] arr = input.Split(new char[] { ':', ',' }, StringSplitOptions.None).ToArray();
                string player = arr[0];
                string[] cards = arr.Skip(1).ToArray();

                if (gamers.ContainsKey(player))
                {
                    gamers[player].AddRange(cards);
                }
                else
                {

                    gamers.Add(player, cards.ToList());
                }

                input = Console.ReadLine();
            }

           
            foreach (var item in gamers.Keys)
            {
                var temp = gamers[item].Distinct().ToList();
                Console.WriteLine($"{item}: {PowerCard(temp)}");
            }



        }

        private static long PowerCard(List<string> arr)
        {
            string input = String.Join(",", arr);//
            input = input.Replace(" ", "");//премахва спеисовете
            string[] price = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Dictionary<string, int> multiplier = new Dictionary<string, int>()
            {
                {"S",4 },
                {"H",3 },
                {"D",2 },
                {"C",1 }
            };
            Dictionary<string, int> point = new Dictionary<string, int>()
            {
                { "2" , 2 },{ "3", 3},{ "4",4 },
                { "5",5 },{"6",6 },{"7",7 },
                { "8",8 },{"9",9 },{"1",10 },
                { "J",11 },{"Q",12 },{"K",13 },{"A",14 }
            };
            int sum = 0;
            for (int i = 0; i < price.Length; i++)
            {
                char[] code = price[i].ToArray();
                char end = code.Last();
                char first = code.First();
                sum += point[first.ToString()] * multiplier[end.ToString()];
            }

            return sum;
        }
    }
}
