using Libreria_anav.Data.ViewModels;

using Libreria_anav.Data.Models;
using System;

namespace Libreria_anav.Data.Models.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
      public void AddBook(BookVM book)
      {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.DEscripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now,
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
      }
    }
}
