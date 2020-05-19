using Microsoft.EntityFrameworkCore;
using TextBasedRPG.Models;

namespace TextBasedRPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        //  The name of the DbSet will be the name of the corresponding database table
        public DbSet<Character> Characters { get; set; }
    }
}