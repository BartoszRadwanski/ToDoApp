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
        
        public static void SetUpMyDetails(ToDoTaskModel toDoTaskModel, ref Label labelTitle, ref Label labelStatus, ref Label labelPriority, ref RichTextBox richTextBoxDescription)
        {
            labelTitle.Text = toDoTaskModel.Name;
            SetColorText.SetStatusText(ref labelStatus, toDoTaskModel.Status);
            SetColorText.SetPriorityText(ref labelPriority, toDoTaskModel.Priority);
            richTextBoxDescription.Text = toDoTaskModel.Description;
        }
    }
}
