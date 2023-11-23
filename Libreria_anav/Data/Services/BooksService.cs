using Libreria_anav.Data.ViewModels;
using Libreria_anav.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_anav.Data.Models.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        //Metodo que nos permite agregar un nuevo libro en la BD
      public void AddBookWithAuthors(BookVM book)
      {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.DEscripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,
                PublisherId = book.PublisherID
            };
            _context.Book.Add(_book);
            _context.SaveChanges();

            foreach (var id in book.AutorIDs)
            {
                var _book_author = new Book_Author()
                {
                    BookId = _book.id,
                    AuthorId = id
                };
                _context.Book_Authors.Add(_book_author);
                _context.SaveChanges();
            }
      }

        //Metodo que nos permite obtener una lista de todos los libros de la BD

        public List<Book> GetAllBks() => _context.Book.ToList();
        
        //Metodo que nos permite obtener el libro que estamos pidiendo de la BD
        public BookWithAuthorsVM GetBookById(int bookid)
        {
            var _bookWithAuthors = _context.Book.Where(n => n.id == bookid).Select(book => new BookWithAuthorsVM()
            {
                Titulo = book.Titulo,
                Descripcion = book.DEscripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                CoverUrl = book.CoverUrl,
                PublisherName = book.Publisher.Name,
                AutorNames = book.Book_Authors.Select(n => n.Author.FullName).ToList()
            }).FirstOrDefault();
            return _bookWithAuthors;
        }
    
        //Metodo que nos permite modificar un libro que se encuentra en la BD
        public Book UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Book.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.DEscripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
         
        }
        public void DeleteBookById(int bookid)
        {
            var _book = _context.Book.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _context.Book.Remove(_book );
                _context.SaveChanges();
            }
        }
    }
}
