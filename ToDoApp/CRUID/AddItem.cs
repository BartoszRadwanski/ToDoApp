using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Database;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.DataValidation;
using ToDoAppBL.Models;

namespace ToDoApp.CRUID
{
    public class AddItem
    {
        public void CreateTask(TaskValidation taskValidation, DayRepository dayRepository, ToDoTaskRepository taskRepository,DayMapper dayMapper,TextBox textBoxName, TextBox textBoxDate, RichTextBox richTextBoxDescription, int statusValue, int priorityValue)
        {
            bool isCorrect = taskValidation.isInputOk(textBoxName.Text, richTextBoxDescription.Text, textBoxDate.Text);
            if (isCorrect)
            {
                using (var dbContex = new ToDoAppDbContext())
                {
                    dayRepository = new DayRepository(dbContex);
                    taskRepository = new ToDoTaskRepository(dbContex);
                    var myDay = dayRepository.GetByDate(DateTime.Parse(textBoxDate.Text));
                    if (myDay == null)
                    {
                        dayMapper = new DayMapper();
                        var tempDay = new DayModel();
                        tempDay.Date = DateTime.Parse(textBoxDate.Text);
                        dayRepository.Update(dayMapper.Map(tempDay));
                    }
                    myDay = dayRepository.GetByDate(DateTime.Parse(textBoxDate.Text));
                    taskRepository.Update(new Database.Entities.TaskToDo
                    {
                        Name = textBoxName.Text,
                        Description = richTextBoxDescription.Text,
                        DayId = myDay.DayId,
                        Status = statusValue,
                        Priority = priorityValue
                    });
                }
                MessageBox.Show("The database was successfully modified");
            }
        }
    }
}
