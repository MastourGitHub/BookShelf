using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookShelf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var book = new Book() { Id = 1, Author = "testAuthor", ISBN = "testISBN", Title = "testTitle"};

            return new string[] { "value1", "value3" };
            }

    }
}
