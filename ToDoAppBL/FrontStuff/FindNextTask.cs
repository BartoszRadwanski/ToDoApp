using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Enums;
using ToDoAppBL.Models;

namespace ToDoAppBL.FrontStuff
{
    public static class FindNextTask
    {
        /// <summary>
        /// This function searches for the next highest priority task to be performed for the day.
        /// </summary>
        /// <param name="myDailyTaskList"></param>
        /// <param name="label"></param>
        public static void GetNextTask(List<ToDoTaskModel> myDailyTaskList, ref Label label)
        {
            var nextTask = myDailyTaskList.OrderBy(t => t.Status == EStatus.InProgress).ThenByDescending(t => t.Priority).FirstOrDefault();
            label.Text = nextTask.Name;
        }
    }
}
