using System;
using System.Collections.Generic;

namespace Library
{
    public class BookManager
    {
        private List<Book> books;
        private Stack<Book> reservedBooks;

        public BookManager()
        {
            books = new List<Book>();
            reservedBooks = new Stack<Book>();
        }

        public void AddBook(Book book) => books.Add(book);
        public Book GetBook(string title) => books.Find(b => b.Title.Equals(title));
    }
}