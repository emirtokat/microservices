using Microsoft.EntityFrameworkCore;
using TaskService.Models;

namespace TaskService.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }

        public DbSet<Task> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>().HasData(
                new Task { Id = 1, TaskDescription = "Task 1", AssignedTo = "user1" },
                new Task { Id = 2, TaskDescription = "Task 2", AssignedTo = "user2" }
            );
        }
    }
}
