using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppBL.Enums;

namespace ToDoApp.Database.Entities
{
    public class TaskToDo
    {
        public int Id { get; set; }
        public int IdDay { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public EPriority Priority { get; set; }
        public EStatus Status { get; set; }
    }
}
