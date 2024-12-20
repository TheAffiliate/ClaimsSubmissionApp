﻿using Microsoft.EntityFrameworkCore;
using ClaimsSubmissionApp.Models;

namespace ClaimsSubmissionApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Claim> Claims { get; set; }
    }
}