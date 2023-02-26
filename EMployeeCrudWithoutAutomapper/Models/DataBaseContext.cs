using Microsoft.EntityFrameworkCore;

namespace EMployeeCrudEntityFrameworkCore.Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }
        public  DbSet<Students> Students { get; set; }

    }
}
