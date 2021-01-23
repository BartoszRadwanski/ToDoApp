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
        public Form1()
        {
            InitializeComponent();
            using(var dbContex=new ToDoAppDbContext())
            {
                dbContex.Database.EnsureCreated();
                //dbContex.DailyTasks.Add(new TaskToDo
                //{
                //    Name = "Test Bazy2",
                //    Description = "o moj bosz",
                //    Date = DateTime.Today,
                //    Priority = EPriority.HighPriority,
                //    Status = EStatus.InProgress
                //});
                ToDoTaskRepository toDoTaskRepository = new ToDoTaskRepository(dbContex);
                ToDoTaskMapper toDoTaskMapper = new ToDoTaskMapper();
                var dailyTask = toDoTaskRepository.GetByName("Test Bazy2");
                var dataTaskModel = toDoTaskMapper.Map(dailyTask);
                dataTaskModel.Description = "GodWhy2";
                var newTask = toDoTaskMapper.Map(dataTaskModel);
                toDoTaskRepository.Update(newTask);              
                var cojeWBazie = dbContex.DailyTasks.ToList();
                //dbContex.SaveChanges();
            }
        }
    }
}
