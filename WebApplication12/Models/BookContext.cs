using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication12.Models
{
    public class BookContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Stuckliste> Stucklistes { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}