using Microsoft.EntityFrameworkCore;
using webRequestHandling.models;

namespace webRequestHandling2.models
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; } = null;

    }
}
