using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

public static class SeedData
    {
    public static void Initialize(LibraryContext context)
    {
        context.Database.EnsureCreated();
        
        if (context.Users.Any() || context.Books.Any() || context.Reserves.Any())
        {
            // Los datos ya se han agregado
            return;
        }
        
        // Agregar datos de prueba para Users
        var users = new User[]
        {
            new User { Name = "John Doe", Faculty = "Computer Science" },
            new User { Name = "Jane Smith", Faculty = "Mathematics" },
            new User { Name = "Michael Johnson", Faculty = "Computer Science" },
            new User { Name = "Emily Brown", Faculty = "English Literature" },
            new User { Name = "David Wilson", Faculty = "Physics" },
            new User { Name = "Sophia Davis", Faculty = "Computer Science" },
            new User { Name = "Daniel Anderson", Faculty = "Mathematics" },
            new User { Name = "Olivia Thomas", Faculty = "Computer Science" },
            new User { Name = "Ethan Martinez", Faculty = "Physics" },
            new User { Name = "Ava Taylor", Faculty = "Computer Science" }
        };
        context.Users.AddRange(users);
        context.SaveChanges();

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
        context.SaveChanges();

        // Agregar datos de prueba para Reserves
        var reserves = new Reserve[]
        {
            new Reserve { Code = "Reserve-001", UserId = users[0].Id, BookId = books[0].Id },
            new Reserve { Code = "Reserve-002", UserId = users[1].Id, BookId = books[1].Id },
            new Reserve { Code = "Reserve-003", UserId = users[2].Id, BookId = books[2].Id },
            new Reserve { Code = "Reserve-004", UserId = users[3].Id, BookId = books[3].Id },
            new Reserve { Code = "Reserve-005", UserId = users[4].Id, BookId = books[4].Id },
            new Reserve { Code = "Reserve-006", UserId = users[5].Id, BookId = books[5].Id },
            new Reserve { Code = "Reserve-007", UserId = users[6].Id, BookId = books[6].Id },
            new Reserve { Code = "Reserve-008", UserId = users[7].Id, BookId = books[7].Id },
            new Reserve { Code = "Reserve-009", UserId = users[8].Id, BookId = books[8].Id },
            new Reserve { Code = "Reserve-010", UserId = users[9].Id, BookId = books[9].Id }
        };
        context.Reserves.AddRange(reserves);
        context.SaveChanges();
    }
}