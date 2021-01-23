using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Database.Entities
{
    [Table("Days")]
    public class Day
    {
        [Key]
        public int DayId { get; set; }
        public DateTime Date { get; set; }
        public virtual ICollection<TaskToDo> DailyTasks { get; set; }
    }
}
