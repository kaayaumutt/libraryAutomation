using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryAutomation
{
    public class person : student
    {
        private string password;
        private string department;
        
        public string updatePassword 
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public string updateDepartment {
            get
            {
                return department;
            }
            set
            {
                if (isValidText(value))
                {
                    department = value;
                }
            }
        }
    }
}
