using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MoreEverything.Linq;

namespace Library
{
    public class BookManager
    {
        private List<Book> books;
        private Stack<Book> reservedBooks;

        public BookManager()
        {
            books = JsonSerializer.Deserialize<List<Book>>(File.ReadAllText(@"books.json"));
            reservedBooks = new Stack<Book>();
        }

        public void AddBook(Book book) => books.Add(book);
#nullable enable
        public Book? GetBook(string title) => books.FindOrDefault(b => b.Title.Equals(title));
#nullable disable
        public List<Book> GetBooks() => books;
        public void RemoveBook(Book book) => books.Remove(book);
        public void ReserveBook(Book book) => reservedBooks.Push(book);
        public Stack<Book> GetReservedBooks() => reservedBooks;
        public void SaveBooks() => File.WriteAllText(@"books.json", JsonSerializer.Serialize(books));
        public Dictionary<string, int> GetListOfBooksGrouped()
        {
            Dictionary<string, int> listOfBooks = new();
            foreach (var item in GetBooks())
            {
                if (listOfBooks.ContainsKey(item.Title))
                    listOfBooks[item.Title]++;
                else
                    listOfBooks[item.Title] = 1;
            }

            return listOfBooks;
        }
    }
}