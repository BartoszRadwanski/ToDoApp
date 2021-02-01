using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Database;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.Models;

namespace ToDoApp.CRUID
{
    public class DeleteItem
    {
        public void DeleteSelectedItem(DayRepository dayRepository, ToDoTaskRepository toDoTaskRepository, ListBox listBoxDailyTasks, ToDoTaskMapper toDoTaskMapper)
        {
            using (var dbContex = new ToDoAppDbContext())
            {
                dayRepository = new DayRepository(dbContex);
                toDoTaskRepository = new ToDoTaskRepository(dbContex);
                var itemToDelete = toDoTaskRepository.GetByName(toDoTaskMapper.Map((ToDoTaskModel)listBoxDailyTasks.SelectedItem).Name);
                if (itemToDelete != null)
                {
                    dbContex.DailyTasks.Remove(itemToDelete);
                    dbContex.SaveChanges();
                    MessageBox.Show("Task was deleted.");
                }
                else
                {
                    MessageBox.Show("There is no task to delete.");
                }
             
            }
        }
    }
}
