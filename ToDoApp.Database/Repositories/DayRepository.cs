using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Database.Entities;
using ToDoApp.Database.Repositories.Base;

namespace ToDoApp.Database.Repositories
{
    public class DayRepository : BaseRepository<Day>
    {
        protected override DbSet<Day> DbSet => DbContext.Days;
        public DayRepository(ToDoAppDbContext dbContext) : base(dbContext) { }
        public Day GetByDate(DateTime dateTime)
        {
            var foundDay = DbSet.Where(d => d.Date == dateTime).FirstOrDefault();
            return foundDay;
        }

        public void Update(Day day)
        {
            var foundDay = DbSet.Where(d => d.Date == day.Date).FirstOrDefault();
            if (foundDay == null)
            {
                DbSet.Add(day);
                SaveChanges();
                return;
            }
            foundDay.Date = day.Date;
            foundDay.DailyTasks = day.DailyTasks;
            SaveChanges();
        }


    }
}
