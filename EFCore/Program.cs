using System;
using System.Text;
using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InsertData();
            PrintData();
            Console.ReadKey();
        }

        private static void InsertData()
        {
            using (var context = new Model())
            {
                // Creates the database if not exists
                context.Database.Migrate();
                context.Database.EnsureCreated();

                // Adds a publisher
                var publisher = new Publisher
                {
                    Name = "Geo Books"
                };
                context.Publishers.Add(publisher);

                var author = new Author
                {
                    Name = "William Gates"
                };
                // Adds some books
                context.Books.Add(new Books
                {
                    ISBN = "978-0544003433",
                    Title = "The Lord of the Rings",
                    Author = author,
                    Languages = "English",
                    Pages = 1216,
                    Publisher = publisher
                });
                context.Books.Add(new Books
                {
                    ISBN = "978-05472477655",
                    Title = "The Sealed Letter",
                    Author = author,
                    Languages = "English",
                    Pages = 416,
                    Publisher = publisher
                });

                // Saves changes
                context.SaveChanges();
            }
        }

        private static void PrintData()
        {
            // Gets and prints all books in database
            using (var context = new Model())
            {
                var books = context.Books
                  .Include(p => p.Publisher);
                foreach (var book in books)
                {
                    var data = new StringBuilder();
                    data.AppendLine($"ISBN: {book.ISBN}");
                    data.AppendLine($"Title: {book.Title}");
                    data.AppendLine($"Publisher: {book.Publisher.Name}");
                    Console.WriteLine(data.ToString());
                }
            }
        }
    }
}
