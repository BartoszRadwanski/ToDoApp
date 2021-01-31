using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoAppBL.Enums;

namespace ToDoAppBL.DataValidation
{
    public class DataValidation
    {
        public bool isNameCorrect(string input)
        {
            if (!String.IsNullOrWhiteSpace(input))
            {
                if (input?.Length > 0 && input.Length <= 50)
                {
                    return true;
                }
                else
                {
                    PrintError(ETypeOfError.WrongDataFormat);
                    return false;
                }
            }
            else
            {
                PrintError(ETypeOfError.NullOrWhiteSpaces);
                return false;
            }
            
        }

        public bool isDescriptionCorrect(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                PrintError(ETypeOfError.NullOrWhiteSpaces);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool isDateCorrect(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                PrintError(ETypeOfError.NullOrWhiteSpaces);
                return false;
            }
            else
            {
                DateTime result;
                if(DateTime.TryParse(input,out result))
                {
                    return true;
                }
                else
                {
                    PrintError(ETypeOfError.WrongDateFormat);
                    return false;
                }
            }
        }

        public string GetMessageText(ETypeOfError eTypeOfError)
        {
            switch (eTypeOfError)
            {
                case ETypeOfError.NullOrWhiteSpaces:
                    return $"The text cannot be empty or contain only white space.";
                case ETypeOfError.WrongDataFormat:
                    return $"An incorrect value has been entered.";
                case ETypeOfError.WrongDateFormat:
                    return $"An unsupported date format was provided (dd-mm-yyyy).";
                default:
                    return $"An unknown error has been encountered.";
            }
        }

        public void PrintError(ETypeOfError eTypeOfError)
        {
            MessageBox.Show(GetMessageText(eTypeOfError), "Communication", MessageBoxButtons.OK);
        }
    }
}
