using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TodoListBE.Data
{
    public class TodoDbContexFactory : IDesignTimeDbContextFactory<TodoDbContext>
    {
        public TodoDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configurationRoot = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json") //Gọi tới file .json
                .Build();
            var connectionString = configurationRoot.GetConnectionString("TodosDatabase");

            var optionBuilder = new DbContextOptionsBuilder<TodoDbContext>();

            optionBuilder.UseSqlServer(connectionString);//Gọi conection
            return new TodoDbContext(optionBuilder.Options);
        }
    }
}
