using Microsoft.EntityFrameworkCore;
using TodoListBE.Configuration;
using TodoListBE.Models;
using TodoListBE.Seeders;

namespace TodoListBE.Data
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TodoConfiguration());

            //cho databaseSeeder bên ngoài thực thi cùng Migrations
            modelBuilder.Seed();
        }

        public DbSet<Todo> Todos { get; set; }
    }
}
