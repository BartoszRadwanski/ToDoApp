using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Database.Repositories.Base
{
    public abstract class BaseRepository<T> where T:class
    {
        protected ToDoAppDbContext DbContext;
        protected abstract DbSet<T> DbSet { get; }
        public BaseRepository(ToDoAppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<T> GetAll()
        {
            var list = new List<T>();
            var entities = DbSet;
            foreach (var entity in entities)
                list.Add(entity);
            return list;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
