using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using MoreEverything.Console;
using MoreEverything.Console.Fun;
using MoreEverything.Linq;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            BookManager bookManager = new BookManager();

            Dictionary<string, Action> actions = new();


            actions.Add("Show a list of books", () => 
            {
                foreach (var item in bookManager.GetListOfBooksGrouped())
                    Console.WriteLine($"{item.Key} | Available: {item.Value}");
            });

            actions.Add("Lend book(s)", () =>
            {
                while (true)
                {
                    var groupedBooks = bookManager.GetListOfBooksGrouped();

                    if (groupedBooks.Count == 0)
                    {
                        Console.WriteLine("No books found.");
                        break;
                    }

                    int i = 1;
                    foreach (var item in groupedBooks)
                        Console.WriteLine($"{i++}. {item.Key} | Available: {item.Value}");

                    var input = ConsoleEx.GetInput<int>("Input the book number, or 0 to exit: ", false);

                    if (input == 0)
                        break;

                    if (input > groupedBooks.Count || input < 0)
                        Console.WriteLine($"Could not find book number {input}. Going back to main menu.");
                    else
                    {
                        var book = bookManager.GetBooks().Take(book => book.Title.Equals(groupedBooks.ElementAt(input - 1).Key));
                        bookManager.ReserveBook(book);
                    }
                }
            });

            actions.Add("Return book(s)", () =>
            {
                while (true)
                {
                    int i = 1;
                    var reservedBooks = bookManager.GetReservedBooks();
                    if (reservedBooks.Count == 0)
                    {
                        Console.WriteLine("No books found.");
                        break;
                    }

                    reservedBooks.ForEach(book => Console.WriteLine($"{i++}. {book.Title}"));

                    var input = ConsoleEx.GetInput<int>("Input the book number, or 0 to exit: ", false);

                    if (input == 0)
                        break;

                    if (input > bookManager.GetReservedBooks().Count || input < 0)
                        Console.WriteLine($"Could not find book number {input}. Going back to main menu.");
                    else
                    {
                        // TODO
                    }
                }
            });
            actions.Add("Check out", () =>
            {
                var books = bookManager.GetReservedBooks();

                if (books.Count == 0)
                {
                    Console.WriteLine("No books found.");
                    return;
                }

                books.ForEach(book => Console.WriteLine($"{book.Title}"));

                bool confirmation = ConsoleEx.GetInput<bool>("Are you sure you wish to check out these books?");

                if (confirmation)
                {
                    int count = books.Count;
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine($"Checking out book: {books.Peek().Title}");
                        books.Pop();
                        Thread.Sleep(1000);
                    }

                    Console.WriteLine("All books successfully checked out!");
                }
            });
            actions.Add("Exit Library", () =>
            {
                var reservedBooks = bookManager.GetReservedBooks();
                // Remove reserved books before save
                for (int i = 0; i < reservedBooks.Count; i++)
                {
                    var book = reservedBooks.Pop();
                    bookManager.AddBook(book);
                }

                bookManager.SaveBooks();

                Console.WriteLine("Goodbye!");
                Environment.Exit(0);
            });

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the library! What would you like to do?");

                int i = 1;
                actions.ForEach(s => Console.WriteLine($"{i++}. {s.Key}"));

                var input = ConsoleEx.GetInput<int>("Enter your choice: ", false) - 1;

                Console.Clear();
                actions.ElementAt(input).Value.Invoke();
                Console.WriteLine("Press any key to go back.");

                Console.ReadKey();
            }
        }
    }
}
