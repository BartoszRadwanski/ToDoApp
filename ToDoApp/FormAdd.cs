using System;
using System.Windows.Forms;
using ToDoApp.Database;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.DataValidation;
using ToDoAppBL.Models;
using ToDoAppBL.FrontStuff;

namespace ToDoApp
{
    public partial class FormAdd : Form
    {
        private readonly bool isEdtion;
        private ToDoTaskModel taskModel;
        private TaskValidation taskValidation;
        private DayRepository dayRepository;
        private ToDoTaskRepository taskRepository;
        private DayMapper dayMapper;
        int priorityValue=1, statusValue=1, fkDay;
        public FormAdd(bool isEdtion)
        {
            InitializeComponent();
            this.isEdtion = isEdtion;
            taskValidation = new TaskValidation();
            AddClickEvents();
            AddIsCheckEvents();
            setDate();
            SetTheAvailabilityOfGuiElements();
        }
        public FormAdd(bool isEdition, ToDoTaskModel taskModel):this(isEdition)
        {
            this.taskModel = taskModel;
            SetUpValuesInForm();
        }

        private void SetUpValuesInForm()
        {
            SetUpTaskDetails.SetUpTextValuesInForm(taskModel, ref textBoxName, ref fkDay, ref richTextBoxDescription);
            using (var dbContex = new ToDoAppDbContext())
            {
                dayRepository = new DayRepository(dbContex);
                var myDay = dayRepository.GetById(fkDay);
                var date = myDay.Date;
                dateTimePicker1.Value = date;
            }
            LoadRadioButtonValue();
        }

        private void LoadRadioButtonValue()
        {
            SetUpTaskDetails.SetUpRadioButtonDefaultCheck((int)taskModel.Priority,ref radioButtonPriorityLow, 
                ref radioButtonPriorityMedium, ref radioButtonPriorityHigh, ref priorityValue);
            SetUpTaskDetails.SetUpRadioButtonDefaultCheck((int)taskModel.Status, ref radioButtonStatusCanceled,
                ref radioButtonStatusInProgress,ref radioButtonStatusDone, ref statusValue);
        }
       

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setDate()
        {
            textBoxDate.Text = dateTimePicker1.Value.Date.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void SetTheAvailabilityOfGuiElements()
        {
            SetUpRadioButtonsState();
            SetUpButtonsState();
        }

        private void SetUpButtonsState()
        {
            buttonEdit.Enabled = isEdtion;
            buttonAdd.Enabled = !isEdtion;
        }

        private void SetUpRadioButtonsState()
        {
          radioButtonPriorityMedium.Checked = true;
          radioButtonStatusInProgress.Checked = true;
          radioButtonStatusCanceled.Enabled = isEdtion;
          radioButtonStatusDone.Enabled = isEdtion;
        }

        private void AddClickEvents()
        {
            buttonAdd.Click += MyButtonClickEvent;
            buttonEdit.Click += MyButtonClickEvent;
            buttonClose.Click += MyButtonClickEvent;
        }

        private void AddIsCheckEvents()
        {
            radioButtonPriorityLow.Click+= MyRadionButtonIsCheck;
            radioButtonPriorityMedium.Click += MyRadionButtonIsCheck;
            radioButtonPriorityHigh.Click += MyRadionButtonIsCheck;
            radioButtonStatusCanceled.Click += MyRadionButtonIsCheck;
            radioButtonStatusDone.Click += MyRadionButtonIsCheck;
            radioButtonStatusInProgress.Click += MyRadionButtonIsCheck;
        }

        private void MyButtonClickEvent(object sender, EventArgs e)
        {
            if (sender == buttonAdd)
            {
                CreateTask();
                PrintMessage("Successfully added to the base.");
            }
            else if (sender==buttonEdit)
            {
                CreateTask();
                PrintMessage("Database changes successfully made.");
            }else if (sender == buttonClose)
            {
                this.Close();
            }
        }

        private void PrintMessage(string text)
        {
            MessageBox.Show($"{text}");
        }

        //pomyśł jak to wyciągnąć na zewnątrz!
        private void CreateTask()
        {
            bool isCorrect=taskValidation.isInputOk(textBoxName.Text,richTextBoxDescription.Text,textBoxDate.Text);
            if (isCorrect)
            {
                using (var dbContex = new ToDoAppDbContext())
                {
                    dayRepository = new DayRepository(dbContex);
                    taskRepository = new ToDoTaskRepository(dbContex);
                    var myDay = dayRepository.GetByDate(DateTime.Parse(textBoxDate.Text));
                    if (myDay == null)
                    {
                        dayMapper = new DayMapper();
                        var tempDay = new DayModel();
                        tempDay.Date = DateTime.Parse(textBoxDate.Text);
                        dayRepository.Update(dayMapper.Map(tempDay));                          
                    }
                    myDay = dayRepository.GetByDate(DateTime.Parse(textBoxDate.Text));
                    taskRepository.Update(new Database.Entities.TaskToDo
                    {
                        Name = textBoxName.Text,
                        Description = richTextBoxDescription.Text,
                        DayId = myDay.DayId,
                        Status = statusValue,
                        Priority = priorityValue
                    });
                }
            }
        }
             
        private void MyRadionButtonIsCheck(object sender, EventArgs e)
        {
            if (sender == radioButtonPriorityHigh)
            {
                priorityValue = 0;
            }else if (sender == radioButtonPriorityMedium)
            {
                priorityValue = 1;
            }
            else if (sender == radioButtonPriorityLow)
            {
                priorityValue = 2;
            }
            else if (sender == radioButtonStatusInProgress)
            {
                statusValue = 1;
            }else if (sender == radioButtonStatusDone)
            {
                statusValue = 2;
            }else if (sender == radioButtonStatusCanceled)
            {
                statusValue = 0;
            }

        }
    
    }
}
