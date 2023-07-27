using Entities;
using Microsoft.EntityFrameworkCore;

namespace NetCoreWebApplication.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        /**/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(LocalDB)\MSSQLLocalDB; Database=NetCoreWebApplication; Trusted_Connection=True; MultipleActiveResultSets=true");
        }
    }
}
