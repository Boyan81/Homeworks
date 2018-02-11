using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Number_Wars
{
    class Program
    {
        static void Main()
        {
            Queue<string> fiarstAllCards = new Queue<string>(Console.ReadLine().Split());
            Queue<string> secondAllCards = new Queue<string>(Console.ReadLine().Split());

            int turndCound = 0;
            bool gameOver = false;
            while (turndCound < 1000000 && !gameOver && fiarstAllCards.Count > 0 && secondAllCards.Count > 0)
            {
                turndCound++;
                string firstCard = fiarstAllCards.Dequeue();
                string secondCard = secondAllCards.Dequeue();

                if (GetNumber(firstCard) > GetNumber(secondCard))
                {
                    fiarstAllCards.Enqueue(firstCard);
                    fiarstAllCards.Enqueue(secondCard);
                }
                else if (GetNumber(firstCard) < GetNumber(secondCard))
                {
                    secondAllCards.Enqueue(secondCard);
                    secondAllCards.Enqueue(firstCard);
                }
                else
                {
                    List<string> curentHands = new List<string> { firstCard, secondCard };
                    while (!gameOver)
                    {
                        if (fiarstAllCards.Count >= 3 && secondAllCards.Count >= 3)
                        {
                            int firstSum = 0;
                            int secoundSum = 0;
                            for (int i = 0; i < 3; i++)
                            {
                                string firstHendsCard = fiarstAllCards.Dequeue();
                                string secondHendsCard = secondAllCards.Dequeue();
                                firstSum += GetChar(firstHendsCard);
                                secoundSum += GetChar(secondHendsCard);
                                curentHands.Add(firstHendsCard);
                                curentHands.Add(secondHendsCard);
                            }
                            if (firstSum > secoundSum)
                            {
                                AddCardsToWiner(curentHands, fiarstAllCards);
                                break;
                            }
                            else if (firstSum < secoundSum)
                            {
                                AddCardsToWiner(curentHands, secondAllCards);
                                break;
                            }
                        }
                        else
                        {
                            gameOver = true;
                        }

                    }
                    
                }
                
            }
            var result = "";
            if (fiarstAllCards.Count == secondAllCards.Count)
            {
                result = "Draw";
            }
            else if (fiarstAllCards.Count > secondAllCards.Count)
            {
                result = "First player wins";
            }
            else
            {
                result = "Second player wins";
            }
            Console.WriteLine($"{result} after {turndCound} turns");
        }

        private static void AddCardsToWiner(List<string> curentHands, Queue<string> queue)
        {
            foreach (var item in curentHands.OrderByDescending(c => GetNumber(c)).ThenByDescending(c => GetChar(c)))
            {
                queue.Enqueue(item);
            }
        }

        static int GetNumber(string firstCard)
        {
            return int.Parse(firstCard.Substring(0, firstCard.Length - 1));
        }
        static int GetChar(string card)
        {
            return card[card.Length - 1];
        }
    }
}
