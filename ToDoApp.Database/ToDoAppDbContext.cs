using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database.Entities;

namespace ToDoApp.Database
{
    public class ToDoAppDbContext:DbContext
    {
        public DbSet<TaskToDo> DailyTasks { get; set; }
        public DbSet<Day> Days { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite($"Filename={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ToDoApp.sqlite")}");
        }
    }
}
