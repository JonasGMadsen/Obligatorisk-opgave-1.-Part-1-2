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
    public class BookTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTitleTest()
        {
            var book = new Book()
            {
                title = ""
            };

            book.ValidateTitle();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateTitleTest2()
        {
            var book = new Book()
            {
                title = "T"
            };

            book.ValidateTitle();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePriceTest()
        {
            var book = new Book()
            {
                price = 1201
            };

            book.ValidatePrice();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidatePriceTest2()
        {
            var book = new Book()
            {
                price = 0
            };

            book.ValidatePrice();
        }

    }
}