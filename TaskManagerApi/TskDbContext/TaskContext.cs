using System.Collections.Generic;
using TaskManagerApi.TaskManagerApi.Models;
using Microsoft.EntityFrameworkCore;
namespace TaskManagerApi.TskDbContext
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }

        public DbSet<TaskItem> Tasks { get; set; }
    }
}