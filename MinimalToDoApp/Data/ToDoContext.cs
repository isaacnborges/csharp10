using Microsoft.EntityFrameworkCore;
using MinimalToDoApp.Models;

namespace MinimalToDoApp.Data
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite("DataSource=ToDo.db;Cache=Shared");
    }
}
