using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Database.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetByName(string item);
        void Update(T item);
        void SaveChanges();
    }
}
