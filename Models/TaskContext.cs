using Microsoft.EntityFrameworkCore;
namespace To_Do_App_Back.Models
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }
    }
}
