using AreaDoAluno.Models;
using Microsoft.EntityFrameworkCore;

namespace AreaDoAluno.Data
{
    public class DataContext : DbContext 
    {
        public DataContext(DbContextOptions options) : base (options) {}

        public DbSet<Course> Courses { get; set; }
    }
}