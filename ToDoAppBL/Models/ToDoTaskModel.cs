using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoAppBL.Enums;

namespace ToDoAppBL.Models
{
    public class ToDoTaskModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int DayId { get; set; }
        public EPriority Priority { get; set; }
        public EStatus Status { get; set; }
    }
}
