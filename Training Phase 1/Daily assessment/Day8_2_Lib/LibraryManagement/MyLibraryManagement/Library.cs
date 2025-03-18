using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibraryManagement
{
    public class LibraryManager
    {
        private List<LibraryBook> Books { get; set; }
        private List<User> Users { get; set; }

        public LibraryManager()
        {
            Books = new List<LibraryBook>();
            Users = new List<User>();
        }

        public void AddBook(LibraryBook book)
        {
            Books.Add(book);
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void BorrowBook(string isbn, string cardID)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && !b.IsBorrowed);
            var user = Users.FirstOrDefault(u => u.CardID == cardID);

            if (book == null) throw new Exception("Book not available.");
            if (user == null) throw new Exception("User not found.");

            book.Borrow();
            user.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string cardID)
        {
            var book = Books.FirstOrDefault(b => b.ISBN == isbn && b.IsBorrowed);
            var user = Users.FirstOrDefault(u => u.CardID == cardID);

            if (book == null || user == null) throw new Exception("Book or user not found.");

            book.Return();
            user.ReturnBook(book);
        }

        public List<LibraryBook> GetBooks() => Books;

        public List<User> GetUsers() => Users;
    }
}
