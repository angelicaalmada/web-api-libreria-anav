using Libreria_anav.Data.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Libreria_anav.Data
{
    internal class Books : IEnumerable<Book>
    {
        public string Titulo { get; internal set; }
        public string Descripcion { get; internal set; }
        public string DEscripcion { get; internal set; }
        public bool IsRead { get; internal set; }
        public DateTime? DateRead { get; internal set; }
        public int? Rate { get; internal set; }
        public string Genero { get; internal set; }
        public string Autor { get; internal set; }
        public string CoverUrl { get; internal set; }
        public DateTime DateAdded { get; internal set; }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}