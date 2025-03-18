using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibraryManagement;

namespace LibraryTests
{
    [TestClass]
    public class LibraryManagerTest
    {
        [TestMethod]
        public void TestAddBook()
        {
            var library = new LibraryManager();
            var book = new LibraryBook("1984", "George Orwell", "ISBN123");

            library.AddBook(book);
            Assert.AreEqual(1, library.GetBooks().Count);
        }

        [TestMethod]
        public void TestAddUser()
        {
            var library = new LibraryManager();
            var user = new User("Alice", "CARD001");

            library.AddUser(user);
            Assert.AreEqual(1, library.GetUsers().Count);
        }

        [TestMethod]
        public void TestBorrowBook()
        {
            var library = new LibraryManager();
            var book = new LibraryBook("1984", "George Orwell", "ISBN123");
            var user = new User("Alice", "CARD001");

            library.AddBook(book);
            library.AddUser(user);
            library.BorrowBook("ISBN123", "CARD001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, user.CheckedOutBooks.Count);
        }

        [TestMethod]
        public void TestReturnBook()
        {
            var library = new LibraryManager();
            var book = new LibraryBook("1984", "George Orwell", "ISBN123");
            var user = new User("Alice", "CARD001");

            library.AddBook(book);
            library.AddUser(user);
            library.BorrowBook("ISBN123", "CARD001");
            library.ReturnBook("ISBN123", "CARD001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, user.CheckedOutBooks.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "Book not available.")]
        public void TestBorrowUnavailableBook()
        {
            var library = new LibraryManager();
            library.BorrowBook("ISBN999", "CARD001"); // No book added yet, should throw exception
        }

        [TestMethod]
        [ExpectedException(typeof(System.Exception), "User not found.")]
        public void TestBorrowBookWithInvalidUser()
        {
            var library = new LibraryManager();
            var book = new LibraryBook("1984", "George Orwell", "ISBN123");
            library.AddBook(book);

            library.BorrowBook("ISBN123", "INVALID_CARD"); // Invalid user, should throw exception
        }
    }
}
