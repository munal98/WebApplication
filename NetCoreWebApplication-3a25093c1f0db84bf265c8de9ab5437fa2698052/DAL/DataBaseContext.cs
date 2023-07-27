using Microsoft.EntityFrameworkCore;
using Entities;

namespace DAL
{
    public class DataBaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> Users { get; set; }
        //public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        //{

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=BlogDB;trusted_connection=true;multipleactiveresultsets=true;");
        }
    }
}
