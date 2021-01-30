using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Enums;

namespace ToDoAppBL.OtherStuff
{
    public static class SetColorText
    {
        /// <summary>
        /// This fucntion set up string value for status to print.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="status"></param>
        public static void SetStatusText(ref Label label,EStatus status)
        {
            label.Text = status.ToString();
            switch (status)
            {
                case EStatus.InProgress:
                    SetDetails(ref label, (int)status);
                    break;
                case EStatus.Done:
                    SetDetails(ref label, (int)status);
                    break;
                case EStatus.Canceled:
                    SetDetails(ref label, (int)status);
                    break;
                default:
                    SetDetails(ref label, (int)status);
                    break;
            }
        }
        /// <summary>
        /// This fucntion set up string value for priority to print
        /// </summary>
        /// <param name="label"></param>
        /// <param name="priority"></param>
        public static void SetPriorityText(ref Label label, EPriority priority)
        {
            label.Text = priority.ToString();
            switch (priority)
            {
                case EPriority.HighPriority:
                    SetDetails(ref label, (int)priority);
                    break;
                case EPriority.LowPriority:
                    SetDetails(ref label, (int)priority);
                    break;
                case EPriority.MediumPriority:
                    SetDetails(ref label, (int)priority);
                    break;
                default:
                    SetDetails(ref label, (int)priority);
                    break;
            }
        }
        /// <summary>
        /// This fucntion chagne font color.
        /// </summary>
        /// <param name="label"></param>
        /// <param name="status"></param>
        private static void SetDetails(ref Label label, int status)
        {
            switch (status)
            {
                case 0:
                    label.ForeColor = System.Drawing.Color.AliceBlue;
                    break;
                case 1:
                    label.ForeColor = System.Drawing.Color.Green;
                    break;
                case 2:
                    label.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    label.ForeColor = System.Drawing.Color.Black;
                    label.Text = "Unknown";
                    break;
            }            
        }
    }
}
