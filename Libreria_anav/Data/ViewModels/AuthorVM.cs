using System.Collections.Generic;

namespace Libreria_anav.Data.ViewModels
{
    public class AuthorVM
    {
        public string FullName { get; set; }
    }

    public class AuthorWhithBooksVM
    {
        public string FullName { get; set;}
        public List<string> BookTitles { get; set; }
    }
}
