using System;
using System.Collections.Generic;

namespace Library
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public DateTime ReleaseDate { get; private set; }

        public Book(string title, string author, DateTime releaseDate)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }
    }
}
