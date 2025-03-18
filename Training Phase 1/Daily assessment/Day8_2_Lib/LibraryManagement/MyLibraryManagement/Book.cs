﻿namespace MyLibraryManagement
{
    public class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }

        public LibraryBook(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false;
        }

        public void Borrow() => IsBorrowed = true;

        public void Return() => IsBorrowed = false;
    }
}
