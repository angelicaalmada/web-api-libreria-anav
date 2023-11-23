using Libreria_anav.Data.Models.Services;
using Libreria_anav.Data.Services;
using Libreria_anav.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Libreria_anav.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private AuthorsService _authorsServices;

        public AuthorController(AuthorsService authorsService) 
        {
            _authorsServices = authorsService;
        }

        [HttpPost("add-author")]
        public IActionResult AddAuthor([FromBody] AuthorVM author)
        {

            _authorsServices.AddAuthor(author);
            return Ok();
        }

        [HttpGet("get-author-with-books-by-id/{id}")]
        public IActionResult GetAuthorWithBooks(int id)
        {
            var response = _authorsServices.GetAuthorWhithBooksVM(id);
            return Ok(response);
        }
    }
}
