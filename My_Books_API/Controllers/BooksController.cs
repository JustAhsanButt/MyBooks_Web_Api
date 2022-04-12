using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using My_Books_API.Data.Models.Services;
using My_Books_API.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Books_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksService _bookService;
        public BooksController(BooksService bookService)
        {
            _bookService = bookService;
        }

        [HttpPost("Add_Book")]
        public IActionResult AddBook([FromBody] BookViewModel bvm)
        {
            _bookService.AddBook(bvm);
            return Ok();

        }

        [HttpGet("Get_All_Book")]
        public IActionResult GetAllBook()
        {
            var allbooks = _bookService.GetAllBooks();
            return Ok(allbooks);
        }

        [HttpGet("Get_Book_By_Id/{Id}")]
        public IActionResult GetBookById(int Id)
        {
            var onebook = _bookService.GetBookById(Id);
            return Ok(onebook);
        }

        [HttpPost("Update_Book_By_Id / {Id}")]
        public IActionResult UpdateBookById(int Id, [FromBody] BookViewModel bvm)
        {
            var update = _bookService.UpdateBookById(Id,bvm);
            return Ok(update);
        }
        
        [HttpDelete("Delete_Book_By_Id/{Id}")]
        public IActionResult DeleteBook(int Id)
        {
             _bookService.DeleteBook(Id);
            return Ok();
        }
    }
}
