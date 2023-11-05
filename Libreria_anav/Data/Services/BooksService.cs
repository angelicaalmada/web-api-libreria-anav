﻿using Libreria_anav.Data.ViewModels;
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

        //Metodo que nos permite obtener una lista de todos los libros de la BD

        public List<Book> GetAllBks() => _context.Books.ToList();
        
        //Metodo que nos permite obtener el libro que estamos pidiendo de la BD
        public Book GetBooksById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);
    
        //Metodo que nos permite modificar un libro que se encuentra en la BD
        public Book UpdateBookByID(int bookid, BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.DEscripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
         
        }
        public void DeleteBookById(int bookid)
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if (_book != null)
            {
                _context.Books.Remove(_book );
                _context.SaveChanges();
            }
        }
    }
}
