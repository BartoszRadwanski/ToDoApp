using System;
using System.Windows.Forms;
using ToDoApp.Database;
using ToDoApp.Database.Repositories;
using ToDoApp.Mappers;
using ToDoAppBL.DataValidation;
using ToDoAppBL.Models;
using ToDoAppBL.FrontStuff;
using ToDoApp.CRUID;

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
        private AddItem addItem;
        int priorityValue=1, statusValue=1, fkDay;
        public FormAdd(bool isEdtion)
        {
            InitializeComponent();
            this.isEdtion = isEdtion;
            taskValidation = new TaskValidation();
            addItem = new AddItem();
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

        /// <summary>
        /// This function loads all data into the form when editing data.
        /// </summary>
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
        /// <summary>
        /// This function sets the values ​​for radio buttons in case of editing data.
        /// </summary>
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
        /// <summary>
        /// This function assigns calendar values ​​to a text box.
        /// </summary>
        private void setDate()
        {
            textBoxDate.Text = dateTimePicker1.Value.Date.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }
        /// <summary>
        /// This function is responsible for preparing the user interface.
        /// </summary>
        private void SetTheAvailabilityOfGuiElements()
        {
            SetUpRadioButtonsState();
            SetUpButtonsState();
        }
        /// <summary>
        /// This function changes the availability of the buttons
        /// </summary>
        private void SetUpButtonsState()
        {
            buttonEdit.Enabled = isEdtion;
            buttonAdd.Enabled = !isEdtion;
        }
        /// <summary>
        /// This function sets default values ​​for radio buttons.
        /// </summary>
        private void SetUpRadioButtonsState()
        {
          radioButtonPriorityMedium.Checked = true;
          radioButtonStatusInProgress.Checked = true;
          radioButtonStatusCanceled.Enabled = isEdtion;
          radioButtonStatusDone.Enabled = isEdtion;
        }
        /// <summary>
        /// This function assigns an event to the appropriate controls.
        /// </summary>
        private void AddClickEvents()
        {
            buttonAdd.Click += MyButtonClickEvent;
            buttonEdit.Click += MyButtonClickEvent;
            buttonClose.Click += MyButtonClickEvent;
        }
        /// <summary>
        /// This function assigns an event to the appropriate controls.
        /// </summary>
        private void AddIsCheckEvents()
        {
            radioButtonPriorityLow.Click+= MyRadionButtonIsCheck;
            radioButtonPriorityMedium.Click += MyRadionButtonIsCheck;
            radioButtonPriorityHigh.Click += MyRadionButtonIsCheck;
            radioButtonStatusCanceled.Click += MyRadionButtonIsCheck;
            radioButtonStatusDone.Click += MyRadionButtonIsCheck;
            radioButtonStatusInProgress.Click += MyRadionButtonIsCheck;
        }

        /// <summary>
        /// This function is responsible for the operation of the buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyButtonClickEvent(object sender, EventArgs e)
        {
            if (sender == buttonAdd)
            {
                addItem.CreateTask(taskValidation, dayRepository, taskRepository, dayMapper, textBoxName, textBoxDate, richTextBoxDescription, statusValue, priorityValue);
            }
            else if (sender==buttonEdit)
            {
                addItem.CreateTask(taskValidation, dayRepository, taskRepository, dayMapper, textBoxName, textBoxDate, richTextBoxDescription, statusValue, priorityValue);
            }else if (sender == buttonClose)
            {
                this.Close();
            }
        }

        /// <summary>
        /// This function is responsible for setting the appropriate values ​​after changing the state of the radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyRadionButtonIsCheck(object sender, EventArgs e)
        {
            if (sender == radioButtonPriorityHigh)
            {
                priorityValue = 2;
            }else if (sender == radioButtonPriorityMedium)
            {
                priorityValue = 1;
            }
            else if (sender == radioButtonPriorityLow)
            {
                priorityValue = 0;
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
