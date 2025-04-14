using Microsoft.EntityFrameworkCore;
using TodoStarter.Shared;

namespace TodoStarter.Backend.Data
{
    public class TodoDBContext : DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options) { }
        public DbSet<TodoItem> ToDos => Set<TodoItem>();
    }
}
