using System.Collections.Generic;

namespace MyLibraryManagement
{
    public class User
    {
        public string Name { get; set; }
        public string CardID { get; set; }
        public List<LibraryBook> CheckedOutBooks { get; set; }

        public User(string name, string cardID)
        {
            Name = name;
            CardID = cardID;
            CheckedOutBooks = new List<LibraryBook>();
        }

        public void BorrowBook(LibraryBook book)
        {
            CheckedOutBooks.Add(book);
        }

        public void ReturnBook(LibraryBook book)
        {
            CheckedOutBooks.Remove(book);
        }
    }
}
