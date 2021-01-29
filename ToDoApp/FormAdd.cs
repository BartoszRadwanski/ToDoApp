using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Models;

namespace ToDoApp
{
    public partial class FormAdd : Form
    {
        private readonly bool isEdtion;
        private ToDoTaskModel taskModel;
        public FormAdd(bool isEdtion)
        {
            InitializeComponent();
            this.isEdtion = isEdtion;
            setDate();
            SetTheAvailabilityOfGuiElements();
        }
        public FormAdd(bool isEdition, ToDoTaskModel taskModel):this(isEdition)
        {
            this.taskModel = taskModel;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setDate()
        {
            textBox1.Text = dateTimePicker1.Value.Date.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            setDate();
        }

        private void SetTheAvailabilityOfGuiElements()
        {
            SetUpRadioButtonsState();
        }

        private void SetUpRadioButtonsState()
        { 
          radioButtonStatusCanceled.Enabled = isEdtion;
          radioButtonStatusDone.Enabled = isEdtion;
        }
    }
}
