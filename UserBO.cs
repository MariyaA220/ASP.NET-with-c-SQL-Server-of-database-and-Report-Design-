using System;

namespace BusinessObject
{
    public class UserBO
    {
        private string _StudentName;
        private DateTime _DateofBirth;
        private string _Gender;
        private string _Degree;
        private string _Branch;
        private string _EmailId;
        private string _Mobile;

        public string StudentName
        {
            get { return _StudentName; }
            set { _StudentName = value; }
        }

        public DateTime DateofBirth
        {
            get { return _DateofBirth; }
            set { _DateofBirth = value; }
        }

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public string Degree
        {
            get { return _Degree; }
            set { _Degree = value; }
        }

        public string Branch
        {
            get { return _Branch; }
            set { _Branch = value; }
        }

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
    }
}

