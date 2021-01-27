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
using ToDoAppBL.FrontStuff;
using ToDoAppBL.Models;
using ToDoAppBL.OtherStuff;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        //SetColorText setColorTexk;
        ToDoTaskRepository toDoTaskRepository;
        ToDoTaskMapper toDoTaskMapper;
        DayRepository dayRepository;
        DayMapper dayMapper;
        
        List<ToDoTaskModel> myTasks;
        public Form1()
        {
            InitializeComponent();
            BindMyButtonsToEvent();

            //setColorTexk = new SetColorText();
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
            LoadDataToMyComboBox();
            SetUpMyListBox();
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

        private void LoadDataToMyComboBox() //przerób na ogólny potem przenieś! ogólnie przemyśl ;d
        {
            using (var dbContex = new ToDoAppDbContext())
            {
                dayRepository = new DayRepository(dbContex);
                var myDayList = dayRepository.GetAll().AsParallel();
                comboBoxDates.DisplayMember = "Date";
                if (myDayList != null)
                {
                    foreach (var day in myDayList)
                    {
                        var dayModel = dayMapper.Map(day);
                        comboBoxDates.Items.Add(dayModel);
                    }
                    comboBoxDates.SelectedIndex = comboBoxDates.Items.Count-1;
                }
                else
                {
                    MessageBox.Show("Brak danych");
                }                            
            }
        }
        //bez kontenerków przemyślo potem
        private void SetUpMyListBox()
        {
            myTasks = new List<ToDoTaskModel>();
            try
            {
                using (var dbContex = new ToDoAppDbContext())
                {
                    dayRepository = new DayRepository(dbContex);
                    toDoTaskRepository = new ToDoTaskRepository(dbContex);
                    DayModel item = (DayModel)comboBoxDates.SelectedItem;
                   
                    var day = dayRepository.GetByDate(dayMapper.Map(item).Date);
                    var dailyTasks = toDoTaskRepository.GetByDate(day).AsParallel();
                    if (dailyTasks != null)
                    {
                        listBox1.DisplayMember = "Name";
                        foreach (var task in dailyTasks)
                        {
                            var taskModel = toDoTaskMapper.Map(task);
                            listBox1.Items.Add(taskModel);
                            myTasks.Add(taskModel);
                        }
                        listBox1.Update();
                        listBox1.SelectedItem = listBox1.Items[0];
                        FindNextTask.GetNextTask(myTasks, ref labelNextTaskValue);
                    }                 
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
          
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = (ToDoTaskModel)listBox1.SelectedItem;
            SetUpTaskDetails.SetUpMyDetails(item, ref labelTitleValue, ref labelStatusValue, ref labelPriorityValue, ref richTextBoxDescription);
        }        

    }
}
