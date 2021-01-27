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
using ToDoAppBL.Models;

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
            BindMyButtonsToEvent();

            dayMapper = new DayMapper();
            toDoTaskMapper = new ToDoTaskMapper();
            using (var dbContex = new ToDoAppDbContext())
            {
                dbContex.Database.EnsureCreated();
                // dbContex.Days.Add(dayMapper.Map(new DayModel
                // {
                //     Date = DateTime.Today
                // }));


                //dbContex.DailyTasks.Add(toDoTaskMapper.Map(new ToDoTaskModel
                //{
                //    DayId=1,
                //    Name = "Test Bazy4",
                //    Description = "o moj bosz",
                //    Priority = EPriority.LowPriority,
                //    Status = EStatus.Done
                //}));
                //toDoTaskRepository = new ToDoTaskRepository(dbContex);
                //toDoTaskMapper = new ToDoTaskMapper();

                dbContex.SaveChanges();

            }
            mainTimer.Start();
        }
        /// <summary>
        /// This function is binding all of my buttons to MyButtonClickEvent function.
        /// </summary>
        private void BindMyButtonsToEvent()
        {
            buttonAdd.Click += MyButtonClickEvent;
            buttonEdit.Click += MyButtonClickEvent;
            buttonOption.Click += MyButtonClickEvent;
            buttonClose.Click += MyButtonClickEvent;
        }

        /// <summary>
        /// This function is responsible for triggering the appropriate events when the button is clicked.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click Event</param>
        private void MyButtonClickEvent(object sender, EventArgs e)
        {;
            if (sender == buttonAdd)
            {
                MessageBox.Show("Add");
            }else if (sender == buttonEdit)
            {
                MessageBox.Show("Edit");
            }
            else if (sender == buttonOption)
            {
                MessageBox.Show("Option");
            }
            else if (sender == buttonClose)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// This function passes values ​​to gui for the current date and date.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainTimer_Tick(object sender, EventArgs e)
        {
            labelDate.Text = DateTime.Now.ToString("dd MMMM yyyy");
            labelHour.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
