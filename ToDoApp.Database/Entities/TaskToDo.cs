using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppBL.Enums;

namespace ToDoApp.Database.Entities
{
    public class TaskToDo
    {
        [Key]
        public int TaskId { get; set; }
        [ForeignKey("Days")]
        public int DayId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }     
        public EPriority Priority { get; set; }
        public EStatus Status { get; set; }
        public virtual Day Days { get; set; }
    }
}
