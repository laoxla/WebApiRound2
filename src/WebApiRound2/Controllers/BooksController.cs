using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebApiRound2.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiRound2.Controllers
{
    [Route("api/[controller]")]
    public class BooksController : Controller
    {

        static List<Book> _books = new List<Book>() {
            new Book()
            {
                Id = 1,
                Title = "Lord of the rings",
                Author = "J.R.R. Tolkien",
                Genre = "High Fantasy",
                PageCount = 1329

            },

             new Book()
            {
                Id = 2,
                Title = "Red Queen",
                Author = "Aveyard Victoria",
                Genre = "Fantasy Fiction",
                PageCount = 963

            },

              new Book()
            {
                Id = 3,
                Title = "Being Mortal",
                Author = "Atul Gawande",
                Genre = "Social Science",
                PageCount = 565

            }

        };

    // GET: api/values
    [HttpGet]
        public IEnumerable<Book> Get()
        {
            return _books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return _books.First(b => b.Id == id); 
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]Book book)
        {
            _books.Add(book);
           book.Id = _books.Max(b => b.Id) + 1;
        }

        //
        [HttpGet("search/{searchTerms}")]
        public void Search(string searchTerms)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Book book)
        {
            Book dbBook = _books.First(b => b.Id == id);
            dbBook.Title = book.Title;
            dbBook.Author = book.Author;
            dbBook.Genre = book.Genre;
            dbBook.PageCount = book.PageCount;




        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
