using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppBL.DataValidation
{
    public class DataValidation
    {
        public bool isNameCorrect(string name)
        {
            bool isCorrect = false;
            if(name?.Length>0 && name.Length <= 50)
            {

            }
            

            return isCorrect;
        }
    }
}
