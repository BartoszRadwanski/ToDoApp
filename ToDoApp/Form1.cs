using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ToDoApp.CRUID;
using ToDoApp.Database;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.FrontStuff;
using ToDoAppBL.Models;

namespace ToDoApp
{
    public partial class Form1 : Form
    {
        ToDoTaskRepository toDoTaskRepository;
        ToDoTaskMapper toDoTaskMapper;
        DayRepository dayRepository;
        DayMapper dayMapper;
        ToDoTaskMapper taskMapper;
        DeleteItem deleteItem;
        
        List<ToDoTaskModel> myTasks;
        public Form1()
        {
            InitializeComponent();
            BindMyButtonsToEvent();
            dayMapper = new DayMapper();
            toDoTaskMapper = new ToDoTaskMapper();
            taskMapper = new ToDoTaskMapper();
            deleteItem = new DeleteItem();
            
            using (var dbContex = new ToDoAppDbContext())
            {
                dbContex.Database.EnsureCreated();             
            }
            LoadDataToMyComboBox();
            //SetUpMyListBox();
            mainTimer.Start();
        }
        /// <summary>
        /// This function is binding all of my buttons to MyButtonClickEvent function.
        /// </summary>
        private void BindMyButtonsToEvent()
        {
            buttonAdd.Click += MyButtonClickEvent;
            buttonEdit.Click += MyButtonClickEvent;
            buttonHelp.Click += MyButtonClickEvent;
            buttonClose.Click += MyButtonClickEvent;
            buttonDelete.Click += MyButtonClickEvent;
        }

        /// <summary>
        /// This function is responsible for triggering the appropriate events when the button is clicked.
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e">Click Event</param>
        private void MyButtonClickEvent(object sender, EventArgs e)
        {
            if (sender == buttonAdd)
            {
                OpenAddWindow();
            }
            else if (sender == buttonEdit)
            {
                OpenEditWindow();
            }
            else if (sender == buttonHelp)
            {
                Form2 formHelp = new Form2();
                formHelp.ShowDialog();
            }else if(sender== buttonDelete)
            {
                DeleteSelectedItem();

            }
            else if (sender == buttonClose)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// This function is resposible for invoke method to delete choosen item.
        /// </summary>
        private void DeleteSelectedItem()
        {
            if (listBoxDailyTasks.Items.Count>0)
            {
                deleteItem.DeleteSelectedItem(dayRepository, toDoTaskRepository, listBoxDailyTasks, toDoTaskMapper);
                LoadDataToMyComboBox();
            }
            else
            {
                MessageBox.Show("No data to delete.");
            }
            
        }

        /// <summary>
        /// This function is responsible for opening the task creation window
        /// </summary>
        private void OpenAddWindow()
        {
            FormAdd formAdd = new FormAdd(false);
            formAdd.ShowDialog();
            LoadDataToMyComboBox();
        }
        /// <summary>
        /// This function is responsible for opening the window for editing tasks
        /// </summary>
        private void OpenEditWindow()
        {
            if (listBoxDailyTasks.SelectedItem != null)
            {
                FormAdd formAdd = new FormAdd(true, (ToDoTaskModel)listBoxDailyTasks.SelectedItem);
                formAdd.ShowDialog();
                LoadDataToMyComboBox();
            }
            else
            {
                MessageBox.Show("No data to edit.");
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

        /// <summary>
        /// This function is loading date into comboBix and order them
        /// </summary>
        private void LoadDataToMyComboBox()
        {
            comboBoxDates.Items.Clear();
            using (var dbContex = new ToDoAppDbContext())
            {
                dayRepository = new DayRepository(dbContex);
                var myDayList = dayRepository.GetAll().AsParallel();               
                comboBoxDates.DisplayMember = "Date";
                if (myDayList != null)
                {
                    myDayList.OrderBy(d => d.Date).AsParallel();
                    foreach (var day in myDayList)
                    {
                        var dayModel = dayMapper.Map(day);
                        comboBoxDates.Items.Add(dayModel);
                    }
                    comboBoxDates.SelectedIndex = comboBoxDates.Items.Count-1;
                }
                else
                {
                    MessageBox.Show("No data.");
                }                            
            }
        }
        /// <summary>
        /// This function is loading daily task to listBox 
        /// </summary>
        private void SetUpMyListBox()
        {
            myTasks = new List<ToDoTaskModel>();
            listBoxDailyTasks.Items.Clear();       
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
                        listBoxDailyTasks.DisplayMember = "Name";
                        foreach (var task in dailyTasks)
                        {
                            var taskModel = toDoTaskMapper.Map(task);
                            listBoxDailyTasks.Items.Add(taskModel);
                            myTasks.Add(taskModel);
                        }
                        listBoxDailyTasks.Update();
                        listBoxDailyTasks.SelectedItem = listBoxDailyTasks.Items[0];
                        FindNextTask.GetNextTask(myTasks, ref labelNextTaskValue);
                    }                 
                }
            }catch(Exception e)
            {
                MessageBox.Show("There are no tasks for the selected day");
            } 
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SetUpTaskDetails.SetUpMyDetails(
                                           (ToDoTaskModel)listBoxDailyTasks.SelectedItem
                                            ,ref labelTitleValue, ref labelStatusValue
                                            ,ref labelPriorityValue, ref richTextBoxDescription);
        }

        private void comboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetUpMyListBox();
        }
       
    }
}
