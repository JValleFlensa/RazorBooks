using Microsoft.EntityFrameworkCore;
using RazorBooks.Web.Models;
using System.Collections.Generic;

namespace RazorBooks.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
