using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryAutomation
{
    public class book : processControl
    {
        private int id;
        private string name;
        private string type;
        private string author;
        private string pageCount;
        //studentBookFollow
        private string longName;
        private string takenDate;
        private string givenDate;

        public int updateID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string updateName
        {
            get
            {
                return name;
            }
            set
            {
                if (isValidText(value))
                {
                    name = value;
                }
            }
        }
        public string updateType
        {
            get
            {
                return type;
            }
            set
            {
                if (isValidText(value))
                {
                    type = value;
                }
            }
        }
        public string updateAuthor
        {
            get
            {
                return author;
            }
            set
            {
                if (isValidText(value))
                {
                    author = value;
                }
            }
        }
        public string updatePageCount
        {
            get
            {
                return pageCount;
            }
            set
            {
                if (isValidNumber(value))
                {
                    pageCount = value;
                }
            }
        }

        //studentBookFollow
        public string updateBookLongName
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

        public string updateTakenDate
        {
            get
            {
                return takenDate;
            }
            set
            {
                takenDate = value;
            }
        }

        public string updateGivenDate
        {
            get
            {
                return givenDate;
            }
            set
            {
                givenDate = value;
            }
        }
    }
}

