using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/books")]
public class BookController : ControllerBase
{
    private readonly LibraryContext _context;

    public BookController(LibraryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<object>> GetBooks()
    {
        var books = _context.Books
            .Include(b => b.Reserves)
            .Select(b => new
            {
                b.Name,
                b.Description,
                Reserves = b.Reserves.Select(r => new
                {
                    r.Id,
                    Name = r.User.Name,
                    r.User.Faculty
                })
            })
            .ToList();

        return Ok(books);
    }
}
