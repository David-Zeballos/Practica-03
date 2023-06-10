using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

public static class SeedData
    {
    public static async void Initialize(LibraryContext context)
    {
        if (context.Users.Any() || context.Books.Any() || context.Reserves.Any())
        {
            // Los datos ya se han agregado
            return;
        }
        
        // Agregar datos de prueba para Users
        var users = new User[]
        {
            new User { Name = "John Doe", Faculty = "Computer Science", CantReservesLastMonth = 2, DateLastReserve = DateTime.Now.AddDays(-5) },
            new User { Name = "Jane Smith", Faculty = "Mathematics", CantReservesLastMonth = 1, DateLastReserve = DateTime.Now.AddDays(-10) },
            new User { Name = "Michael Johnson", Faculty = "Computer Science", CantReservesLastMonth = 0, DateLastReserve = DateTime.Now.AddDays(-20) },
            new User { Name = "Emily Brown", Faculty = "English Literature", CantReservesLastMonth = 3, DateLastReserve = DateTime.Now.AddDays(-2) },
            new User { Name = "David Wilson", Faculty = "Physics", CantReservesLastMonth = 1, DateLastReserve = DateTime.Now.AddDays(-15) },
            new User { Name = "Sophia Davis", Faculty = "Computer Science", CantReservesLastMonth = 2, DateLastReserve = DateTime.Now.AddDays(-7) },
            new User { Name = "Daniel Anderson", Faculty = "Mathematics", CantReservesLastMonth = 0, DateLastReserve = DateTime.Now.AddDays(-25) },
            new User { Name = "Olivia Thomas", Faculty = "Computer Science", CantReservesLastMonth = 1, DateLastReserve = DateTime.Now.AddDays(-12) },
            new User { Name = "Ethan Martinez", Faculty = "Physics", CantReservesLastMonth = 4, DateLastReserve = DateTime.Now.AddDays(-3) },
            new User { Name = "Ava Taylor", Faculty = "Computer Science", CantReservesLastMonth = 2, DateLastReserve = DateTime.Now.AddDays(-8) }
        };
        context.Users.AddRange(users);
        await context.SaveChangesAsync();

        // Agregar datos de prueba para Books
        var books = new Book[]
        {
            new Book { Name = "Introduction to Programming", Description = "Learn the basics of programming" },
            new Book { Name = "Data Structures and Algorithms", Description = "Explore common data structures and algorithms" },
            new Book { Name = "Database Systems", Description = "A comprehensive guide to database management" },
            new Book { Name = "Linear Algebra", Description = "Introduction to linear algebra concepts" },
            new Book { Name = "Web Development with HTML and CSS", Description = "Build interactive websites using HTML and CSS" },
            new Book { Name = "Operating Systems", Description = "Understanding the principles of operating systems" },
            new Book { Name = "Discrete Mathematics", Description = "Foundations for computer science" },
            new Book { Name = "Artificial Intelligence", Description = "Exploring AI techniques and applications" },
            new Book { Name = "Machine Learning", Description = "Introduction to machine learning algorithms" },
            new Book { Name = "Network Security", Description = "Protecting computer networks from cyber threats" }
        };
        context.Books.AddRange(books);
        await context.SaveChangesAsync();

        // Agregar datos de prueba para Reserves
        var reserves = new Reserve[]
        {
            new Reserve { Code = "Reserve-001", UserId = users[0].Id, BookId = books[0].Id, Description = "Reserve description 1" },
            new Reserve { Code = "Reserve-002", UserId = users[1].Id, BookId = books[1].Id, Description = "Reserve description 2" },
            new Reserve { Code = "Reserve-003", UserId = users[2].Id, BookId = books[2].Id, Description = "Reserve description 3" },
            new Reserve { Code = "Reserve-004", UserId = users[3].Id, BookId = books[3].Id, Description = "Reserve description 4" },
            new Reserve { Code = "Reserve-005", UserId = users[4].Id, BookId = books[4].Id, Description = "Reserve description 5" },
            new Reserve { Code = "Reserve-006", UserId = users[5].Id, BookId = books[5].Id, Description = "Reserve description 6" },
            new Reserve { Code = "Reserve-007", UserId = users[6].Id, BookId = books[6].Id, Description = "Reserve description 7" },
            new Reserve { Code = "Reserve-008", UserId = users[7].Id, BookId = books[7].Id, Description = "Reserve description 8" },
            new Reserve { Code = "Reserve-009", UserId = users[8].Id, BookId = books[8].Id, Description = "Reserve description 9" },
            new Reserve { Code = "Reserve-010", UserId = users[9].Id, BookId = books[9].Id, Description = "Reserve description 10" }
        };
        context.Reserves.AddRange(reserves);
        await context.SaveChangesAsync();
    }
}