using Microsoft.EntityFrameworkCore;

namespace EmployeeCRUD.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }  
    }
}
