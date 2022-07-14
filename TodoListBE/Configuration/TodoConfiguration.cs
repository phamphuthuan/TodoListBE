using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TodoListBE.Models;

namespace TodoListBE.Configuration
{
    public class TodoConfiguration : IEntityTypeConfiguration<Todo>
    {
        public void Configure(EntityTypeBuilder<Todo> builder)
        {
            builder.ToTable("Todos"); //Tên bản SQL
            builder.HasKey(t => t.Id);// Khóa chính
            builder.Property(t => t.Name).IsRequired();// Nội dung todo
            builder.Property(t => t.IsComplete).IsRequired().HasDefaultValue(false);//Trạng thái mặt định là chưa hoàn thành
        }
    }
}
