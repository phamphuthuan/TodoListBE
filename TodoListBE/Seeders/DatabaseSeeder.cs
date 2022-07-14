using Microsoft.EntityFrameworkCore;
using TodoListBE.Models;

namespace TodoListBE.Seeders
{
    public static class DatabaseSeeder
    {
        public static void Seed(this ModelBuilder modelBuilder) //Tạo dữ liệu mẫu DB
        {
            modelBuilder.Entity<Todo>().HasData(
                new Todo() { Id = 1, Name= "Nhiệm vụ 1", IsComplete=false },
                new Todo() { Id = 2, Name = "Nhiệm vụ 2", IsComplete=false }
                );
        }
    }
}
