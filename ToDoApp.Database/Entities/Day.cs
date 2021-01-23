using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Database.Entities
{
   public class Day
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public virtual ICollection<TaskToDo> DailyTasks { get; set; }
    }
}
