using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


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
        public int Priority { get; set; }
        public int Status { get; set; }
        public virtual Day Days { get; set; }
    }
}
