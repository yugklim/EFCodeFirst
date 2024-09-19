using EFCodeFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCodeFirst
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }

        public BloggingContext() : base(GetOptions(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Blogging;Integrated Security=sspi;MultipleActiveResultSets=True"))
        {
        }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }
    }
}

