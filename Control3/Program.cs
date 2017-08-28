using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control3
{
    class Book
    {
        public string Name;
        public int Year;
        public string Author;
    }

    class Program
    {
        static void Main(string[] args)
        {

            var data = new List<Book>() {
            new Book() { Name = "Guards! Guards!", Year = 1810, Author = "Terry Pratchett "},
            new Book() { Name = "Guards!LINQ!", Year = 1910, Author = "Terry Pratchett2" },
            new Book() { Name = "Guards! LINQ!22", Year = 1920, Author = "Terry Pratchett3" },
             new Book() { Name = "22", Year = 1920, Author = "Terry Pratchett3" },

        };
            // 1. год издания-высокосный и содержит LINQ

            var containsLINQ = data.Where(f => f.Name.Contains("LINQ")).Where(k => DateTime.IsLeapYear(k.Year));

            foreach (var item in containsLINQ)
                Console.WriteLine(item.Name);

            Console.WriteLine("-------------------------");

            //2.

            var datatext = "Дана  последовательность книг";

            Console.WriteLine(datatext.Distinct().Count());

            Console.WriteLine("-------------------------");

            //3.

            int[] myArr = { 14, 12, 23, 20, 33, 32, 37 };

            var sortedNumbers = myArr.OrderBy(i => i.ToString().First()).ThenByDescending(i => i.ToString().Last());

            foreach (var item in sortedNumbers)
                Console.WriteLine(item);

            Console.WriteLine("3-------------------------");


            //4. 

            var booksA = data.GroupBy(f => f.Author).Select(item => item.Key + " " + item.Count());

            foreach (var item in booksA)
                Console.WriteLine(item);

            Console.WriteLine("-------------------------");


        }
    }
}
