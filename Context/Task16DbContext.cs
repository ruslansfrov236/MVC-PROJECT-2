using Microsoft.EntityFrameworkCore;
using Task_16.Areas.admin.Models.Entities;

namespace Task_16.Context
{
    public class Task16DbContext : DbContext
    {
        public Task16DbContext(DbContextOptions options) : base(options) { }


        public DbSet<Statistics>? Statistics { get; set; }
    }
}
