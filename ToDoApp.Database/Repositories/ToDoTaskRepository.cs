using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ToDoApp.Database.Entities;
using ToDoApp.Database.Repositories.Base;
using ToDoApp.Database.Repositories.Interfaces;

namespace ToDoApp.Database.Repositories
{
    public class ToDoTaskRepository : BaseRepository<TaskToDo>, IRepository<TaskToDo>
    {
        protected override DbSet<TaskToDo> DbSet => DbContext.DailyTasks;
        public ToDoTaskRepository(ToDoAppDbContext dbContext) : base(dbContext) { }

        public TaskToDo GetByName(string name)
        {
            var foundTask = DbSet.Where(t => t.Name == name).FirstOrDefault();
            return foundTask;
        }

        public void Update(TaskToDo task)
        {
            var foundTask = DbSet.Where(t => t.Name == task.Name).FirstOrDefault();
            if (foundTask == null)
            {
                DbSet.Add(task);
                SaveChanges();
                return;
            }
            foundTask.Name = task.Name;
            foundTask.Description = task.Description;
            foundTask.Date = task.Date;
            foundTask.Priority = task.Priority;
            foundTask.Status = task.Status;
            SaveChanges();
        }
    }
}
