﻿using Microsoft.EntityFrameworkCore;

namespace AnonymousClasses.DataAccess
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            :base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
    }
}
