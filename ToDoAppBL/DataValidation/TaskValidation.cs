using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppBL.DataValidation
{
    public class TaskValidation
    {
        DataValidation dataValidation;
        public TaskValidation()
        {
            dataValidation = new DataValidation();
        }
        /// <summary>
        /// This function calls methods that check user input.
        /// </summary>
        /// <param name="nameInput"></param>
        /// <param name="descriptionInput"></param>
        /// <param name="dateInput"></param>
        /// <returns>bool isDateCorrect</returns>
        public bool isInputOk(string nameInput, string descriptionInput, string dateInput)
        {
            bool[] isOk = { false, false, false };
            isOk[0] = dataValidation.isNameCorrect(nameInput);
            isOk[1] = dataValidation.isDescriptionCorrect(descriptionInput);
            isOk[2] = dataValidation.isDateCorrect(dateInput);
            return CheckArrya(isOk);
        }
        /// <summary>
        /// This function checks if the result of data checking was positive.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private bool CheckArrya(bool[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == false)
                    return false;
            }
            return true;
        }
    }
}
