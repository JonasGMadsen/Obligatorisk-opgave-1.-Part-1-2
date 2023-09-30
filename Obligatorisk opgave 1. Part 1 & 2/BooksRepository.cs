using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorisk_opgave_1._Part_1___2
{
    public class BooksRepository
    {
        private int nextId = 1;
        private List<Book> books = new List<Book>();

        public BooksRepository()
        {
            books.Add(new Book { id = nextId++, title = "Harry Potter", price = 100 });
            books.Add(new Book { id = nextId++, title = "Lord of the Rings", price = 200 });
            books.Add(new Book { id = nextId++, title = "The Hobbit", price = 300 });
        }

        public List<Book> Get(int? minPrice = null, int? maxPrice = null, bool sortByTitle = false, bool sortByPrice = false)
        {
            IEnumerable<Book> filteredBooks = books;

            if (minPrice.HasValue)
            {
                filteredBooks = filteredBooks.Where(book => book.price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                filteredBooks = filteredBooks.Where(book => book.price <= maxPrice.Value);
            }

            if (sortByTitle)
            {
                filteredBooks = filteredBooks.OrderBy(book => book.title);
            }

            if (sortByPrice)
            {
                filteredBooks = filteredBooks.OrderBy(book => book.price);
            }

            return filteredBooks.ToList();
        }

        public Book? GetById(int id)
        {
            return books.Find(book => book.id == id);
        }

        public Book add(Book book)
        {
            book.Validate();
            book.id = nextId++;
            books.Add(book);
            return book;
        }

        public Book? Delete(int id)
        {
            Book? book = GetById(id);
            if (book != null)
            {
                books.Remove(book);
            }
            return book;
        }

        public Book? Update(int id, Book book)
        {
            Book? bookToUpdate = GetById(id);
            if (bookToUpdate != null)
            {
                bookToUpdate.title = book.title;
                bookToUpdate.price = book.price;
                bookToUpdate.Validate();
            }
            return bookToUpdate;
        }
    }
}
