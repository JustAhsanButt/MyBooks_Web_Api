using My_Books_API.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books_API.Data.Models.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //Add Book Function
        public void AddBook(BookViewModel bvm)
        {
            var newbook = new Book()
            {
                Title = bvm.Title,
                Description = bvm.Description,
                Author = bvm.Author,
                Genre = bvm.Genre
            };
            _context.Books.Add(newbook);
            _context.SaveChanges();


        }

        //Get All Books Function
        public List<Book> GetAllBooks()
        {
            var allbooks = _context.Books.ToList();
            return allbooks;
        }

        //Get One Book By Id Function
        public Book GetBookById(int Id)
        {
            var onebook = _context.Books.FirstOrDefault(b => b.Id == Id);
            return onebook;
        }

        //Update Book By Id Function
        public Book UpdateBookById(int bookId, BookViewModel bvm)
        {
            //Check the book exist in our database or not?
            var updatebook = _context.Books.FirstOrDefault(u => u.Id == bookId);

            if(updatebook != null)
            {
                updatebook.Title = bvm.Title;
                updatebook.Description = bvm.Description;
                updatebook.Author = bvm.Author;
                updatebook.Genre = bvm.Genre;

                _context.SaveChanges();
            }    
            return updatebook;
        }

        //Delete Book Function
        public void DeleteBook(int Id)
        {

            var delete = _context.Books.FirstOrDefault(n => n.Id == Id);
            if(delete !=null)
            {
                _context.Books.Remove(delete);
                _context.SaveChanges();

            }
        }



    }
}
