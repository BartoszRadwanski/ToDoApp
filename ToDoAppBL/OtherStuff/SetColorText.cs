using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Enums;

namespace ToDoAppBL.OtherStuff
{
    public class SetColorText
    {
        public void SetStatusText(ref Label label,EStatus status)
        {
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

        public void SetPriorityText(ref Label label, EPriority priority)
        {
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

        private void SetDetails(ref Label label, int status)
        {
            label.Text = status.ToString();
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
                    break;
            }
                
            
        }
    }
}
