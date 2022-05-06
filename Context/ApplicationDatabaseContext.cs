﻿using Microsoft.EntityFrameworkCore;
using test_api.Models;

namespace test_api.Context
{
    public class ApplicationDatabaseContext: DbContext
    {
        public ApplicationDatabaseContext(DbContextOptions<ApplicationDatabaseContext> options) : base(options)
        {
        }

        public DbSet<Author> author { get; set; }
        public DbSet<Books> books { get; set; }
        public DbSet<Quotes> quotes { get; set; }
    }
}