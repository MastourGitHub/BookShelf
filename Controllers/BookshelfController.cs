using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace BookShelf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookshelfController : ControllerBase
    {

        IBookShelfService iBookShelf = BookShelfServiceImpl.GetInstance;
        



        // GET api/bookshelf
        // get a list of all books from bookshelf in Json format
        [HttpGet]
        public ActionResult<String> Get()
        {
 //           iBookShelf.Add(new Book () {Id = 18, Author="testAuthor", ISBN="testISBN", Title = "testTitle" });
            var jSonString = Newtonsoft.Json.JsonConvert.SerializeObject(iBookShelf.GetBooks());
            return jSonString;
        }


        // POST api/bookshelf
        // add a book to the bookshelf
        [HttpPost]
        public IActionResult Post([FromBody] Book book)
        {
            iBookShelf.Add(book);
            return CreatedAtAction("Get", iBookShelf.GetBooks());
        }

        // PUT api/bookshelf/book
        // update a book of bookshelf
        [HttpPut]
        public IActionResult Put(Book book)
        {
            iBookShelf.Update(book);
            return CreatedAtAction("Get", iBookShelf.GetBooks());
        }

        // DELETE api/bookshelf/id
        // delete a book from the bookshelf
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            iBookShelf.Remove(id);
            return CreatedAtAction("Get", iBookShelf.GetBooks());
        }
    }
}
