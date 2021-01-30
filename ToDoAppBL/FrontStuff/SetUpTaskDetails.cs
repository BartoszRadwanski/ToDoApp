using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Models;
using ToDoAppBL.OtherStuff;

namespace ToDoAppBL.FrontStuff
{
    public static class SetUpTaskDetails
    {
        /// <summary>
        /// This function is binding data from model to GUI
        /// </summary>
        /// <param name="toDoTaskModel"></param>
        /// <param name="labelTitle"></param>
        /// <param name="labelStatus"></param>
        /// <param name="labelPriority"></param>
        /// <param name="richTextBoxDescription"></param>
        public static void SetUpMyDetails(ToDoTaskModel toDoTaskModel, ref Label labelTitle, ref Label labelStatus, ref Label labelPriority, ref RichTextBox richTextBoxDescription)
        {
            labelTitle.Text = toDoTaskModel.Name;
            SetColorText.SetStatusText(ref labelStatus, toDoTaskModel.Status);
            SetColorText.SetPriorityText(ref labelPriority, toDoTaskModel.Priority);
            richTextBoxDescription.Text = toDoTaskModel.Description;
        }

        public static void SetUpTextValuesInForm(ToDoTaskModel toDoTaskModel,ref TextBox name,ref int fkDay,ref RichTextBox description)
          {
              description.Text = toDoTaskModel.Description;
              name.Text = toDoTaskModel.Name;
              fkDay = toDoTaskModel.DayId;
          }

        public static void SetUpRadioButtonDefaultCheck(int value, ref RadioButton r1, ref RadioButton r2, ref RadioButton r3, 
            ref int outValue)
        {
            switch (value)
            {
                case 0:
                    r1.Checked = true;
                    outValue = 0;
                    break;
                case 1:
                    r2.Checked = true;
                    outValue = 1;
                    break;
                case 2:
                    r3.Checked = true;
                    outValue = 2;
                    break;
            }
        }
    }
}
