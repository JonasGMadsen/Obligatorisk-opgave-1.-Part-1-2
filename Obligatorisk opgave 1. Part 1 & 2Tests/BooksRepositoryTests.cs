using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obligatorisk_opgave_1._Part_1___2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_opgave_1._Part_1___2.Tests
{
    [TestClass()]
    public class BooksRepositoryTests
    {
        [TestMethod()]
        public void DeleteTest()
        {
            var repository = new BooksRepository();
            int bookIdToBeDeleted = 1;

            Book? deletedBook = repository.Delete(bookIdToBeDeleted);

            Assert.IsNotNull(deletedBook);
            Assert.AreEqual(bookIdToBeDeleted, deletedBook?.id);
            Assert.AreEqual(2, repository.Get().Count);
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            var repository = new BooksRepository();
            int existingBooks = 3;

            Book? foundBooks = repository.GetById(existingBooks);

            Assert.IsNotNull(foundBooks);
            Assert.AreEqual(existingBooks, foundBooks?.id);
        }

        [TestMethod()]
        public void addTest()
        {
            var repository = new BooksRepository();
            var addBook = new Book { id = 4, title = "Lord of the flies", price = 1000 };

            Book addedBook = repository.add(addBook);

            Assert.IsNotNull(addedBook);
            Assert.AreEqual(addBook.id, addedBook.id);
        }
    }
}