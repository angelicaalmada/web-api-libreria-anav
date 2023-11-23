using System;
using System.Collections.Generic;

namespace Libreria_anav.Data.ViewModels
{
    public class BookVM
    {
        public string Titulo { get; set; }
        public string DEscripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }
        public int PublisherID { get; set; }
        public List<int> AutorIDs { get; set; }
    }

    public class BookWithAuthorsVM
    {
        internal object Descripcion;

        public string Titulo { get; set; }
        public string DEscripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string CoverUrl { get; set; }

        public string PublisherName { get; set; }
        public List<string> AutorNames { get; set; }
    }

}
