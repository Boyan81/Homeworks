using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _05.Book_Library
{
    //{title }{author} {publisher} {release date} {ISBN} {price}.
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseData { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                Book readBook = new Book();

                readBook.Title = input[0];
                readBook.Author = input[1];
                readBook.Publisher = input[2];
                readBook.ReleaseData = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                readBook.ISBN = input[4];
                readBook.Price = decimal.Parse(input[5]);
                books.Add(readBook);
            }

            Dictionary<string, decimal> salesByAuthor = new Dictionary<string, decimal>();

            foreach (string author in books.Select(x => x.Author).Distinct())
                salesByAuthor.Add(author, books.Where(x => x.Author == author)
                                               .Select(x => x.Price)
                                               .Sum());
            foreach (var pair in salesByAuthor
                         .OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                Console.WriteLine("{0} -> {1:f2}", pair.Key, pair.Value);
        }
    }

}