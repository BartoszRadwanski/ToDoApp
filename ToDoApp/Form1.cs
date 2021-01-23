using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoApp.Database;
using ToDoApp.Database.Entities;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.Enums;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        ToDoTaskRepository toDoTaskRepository;
        ToDoTaskMapper toDoTaskMapper;
        DayRepository dayRepository;
        DayMapper dayMapper;
        public Form1()
        {
            InitializeComponent();
            using(var dbContex=new ToDoAppDbContext())
            {
                dbContex.Database.EnsureCreated();
                //dbContex.Days.Add(new Database.Entities.Day
                //{
                //    Date = DateTime.Today
                //});
                //dbContex.DailyTasks.Add(new TaskToDo
                //{
                //    DayId=1,
                //    Name="Test1",
                //    Description="meh",
                //    Priority=EPriority.HighPriority,
                //    Status=EStatus.InProgress,                   
                //});
                //dbContex.DailyTasks.Add(new TaskToDo
                //{
                //    Name = "Test Bazy2",
                //    Description = "o moj bosz",
                //    Priority = EPriority.HighPriority,
                //    Status = EStatus.InProgress
                //});
                //toDoTaskRepository = new ToDoTaskRepository(dbContex);
                //toDoTaskMapper = new ToDoTaskMapper();
             
                //dbContex.SaveChanges();
                
            }
        }
    }
}
