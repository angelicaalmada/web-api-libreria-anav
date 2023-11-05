﻿using System;

namespace Libreria_anav.Data.Models
{
    public class Book
    {
        internal string Descripcion;

        public int id {  get; set; }
        public string Titulo { get; set; }
        public string DEscripcion { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genero { get; set; }
        public string Autor {  get; set; } 
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }
    }
}