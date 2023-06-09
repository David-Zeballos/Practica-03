using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

[ApiController]
[Route("api/users")]
public class UserController : ControllerBase
{
    private readonly LibraryContext _context;

    public UserController(LibraryContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<object>> GetUsers()
    {
        var users = _context.Users
            .Include(u => u.Reserves)
            .Select(u => new
            {
                u.Name,
                u.Faculty,
                DateLastReserve = u.DateLastReserve.HasValue ? u.DateLastReserve.Value.ToString("yyyy-MM-ddTHH:mm:ss.ffffffZ") : null,
                u.CantReservesLastMonth,
                Reserves = u.Reserves.Select(r => new
                {
                    r.Id,
                    r.Code,
                    Book = r.Book.Name,
                    r.Description
                })
            })
            .ToList();

        return Ok(users);
    }
}
