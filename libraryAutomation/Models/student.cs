using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryAutomation
{
    public class student : book
    {
        private string surname;
        private string email;
        private string studentNo;
        //studentBookFollow
        private string longName;

        public string updateSurname
        {
            get
            {
                return surname;
            }
            set
            {
                if (isValidText(value))
                {
                    surname = value;
                }
            }
        }
        public string updateEmail
        {
            get
            {
                return email;
            }
            set
            {
                if (isValidEmail(value))
                {
                    email = value;
                }
            }
        }
        public string updateStudentNo
        {
            get
            {
                return studentNo;
            }
            set
            {
                if (isValidNumber(value))
                {
                    studentNo = value;
                }
            }
        }

        //studentBookFollow
        public string updateStudentLongName
        {
            get
            {
                return longName;
            }
            set
            {
                if (isValidText(value))
                {
                    longName = value;
                }
            }
        }
    }
}
