using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Globalization;

namespace _9.Book_Library
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
        static void Main()
        {
            StreamReader reader = new StreamReader(@"..\..\input.txt");
            string outputName = NameOutput();

            List<Book> books = new List<Book>();

            while (!reader.EndOfStream)
            {
                int n = int.Parse(reader.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    string[] input = reader.ReadLine()
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
                    File.AppendAllText(outputName,$"{pair.Key} -> {pair.Value:f2}"+Environment.NewLine);
            }
            reader.Close();
        }
        private static string NameOutput()
        {
            var number = Directory.GetFiles(@"..\..\")//-текуща директория кадето са фаиловете
                .Where(f => f.StartsWith(@"..\..\output"))//-намираме всички фаилове които стартират с output
                .Select(f => f.Split('_').Skip(1).FirstOrDefault())//-
                .Where(f => f != null)//-
                .Select(f => f.Replace(".txt", ""))//-
                .Select(int.Parse);

            int nextNumber = 0;
            if (number.Any())
            {
                nextNumber = number.Max() + 1;
            }
            string outputName = @"..\..\output_" + nextNumber + ".txt";
            return outputName;
        }
    }
}
