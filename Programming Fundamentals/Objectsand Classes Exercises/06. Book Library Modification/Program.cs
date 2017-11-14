using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Book_Library_Modification
{
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
            DateTime dateFormat = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            List<Book> newBook = new List<Book>();
            books.Where(s => s.ReleaseData >= dateFormat)
                 .Select(x => x.ReleaseData).Distinct()
                 .OrderBy(s => s)
               .ToList()
                .ForEach(s => Console.WriteLine($"{s.Title} -> {s.ReleaseData:dd.MM.yyyy}"));

            Console.WriteLine();
            //.ForEach(s => Console.WriteLine($"{s.Title} -> {s.ReleaseData:dd.MM.yyyy}"));
        }
    }
}
