using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObligatoryBook;
using System;

namespace BookTestProject
{
    [TestClass]
    public class BookTest
    {
        private Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");
        [TestMethod]
        public void TestConstructor()
        {
           Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");

            Assert.AreEqual("The Kings Ranger", book.Title);
            Assert.AreEqual("John Flanagan", book.Author);
            Assert.AreEqual(465, book.PageNR);
            Assert.AreEqual("1234567890987", book.ISBN);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAuthorNull()
        {
            book.Author = null;

            
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestTitleNull()
        {
            book.Title = null;


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestISBNNull()
        {
            book.ISBN = null;


        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void TestPageNrNull()
        //{
        //    book.PageNR = null;


        //}

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAuthorNameTooShort()
        {

            book.Author = "Y";

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTooFewPages()
        {
            book.PageNR = 3;


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestTooManyPages()
        {
            book.PageNR = 12000;


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestISBNNumberTooShort()
        {
            book.ISBN = "85531796";


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestISBNNumberTooLong()
        {
            book.ISBN = "864698201269979";


        }

        [TestMethod]
        public void TestNameAssignment()
        {
            Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");

            book.Title = "The Scandian Pact";

            Assert.AreEqual("The Scandian Pact", book.Title);
            
        }

        [TestMethod]
        public void TestAuthorAssignment()
        {
            Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");

            book.Author = "Jesper Hansen";

            Assert.AreEqual("Jesper Hansen", book.Author);

        }

        [TestMethod]
        public void TestPageNrAssignment()
        {
            Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");

            book.PageNR = 365;

            Assert.AreEqual(365, book.PageNR);

        }

        [TestMethod]
        public void TestISBNAssignment()
        {
            Book book = new Book("The Kings Ranger", "John Flanagan", 465, "1234567890987");

            book.ISBN = "1234567890971";

            Assert.AreEqual("1234567890971", book.ISBN);

        }
    }
}
