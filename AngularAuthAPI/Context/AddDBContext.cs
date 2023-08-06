using AngularAuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularAuthAPI.Context
{
    public class AddDBContext: DbContext
    {
        public AddDBContext(DbContextOptions<AddDBContext> options):base(options) { }


        public DbSet<User> Users { get; set; }
    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");   
        }
    }

}
