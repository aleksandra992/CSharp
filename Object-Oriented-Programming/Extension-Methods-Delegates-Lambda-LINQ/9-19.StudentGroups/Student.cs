namespace _9.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using System.Text.RegularExpressions;

    public class Student
    {

        private string firstName;
        private string lastName;
        private string mobilePhone;
        private string email;
        private string fn;

        private List<int> marks;

        public Student(string firstname, string lastName, string mobilePhone, string email, int groupNumber, string fn)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.GroupNumber = groupNumber;
            this.marks = new List<int>();
            this.FN = fn;

        }

        public string FirstName
        {
            get
            {
                return this.firstName;

            }
            set
            {
                foreach (var item in value)
                {
                    if (!Char.IsLetter(item))
                    {
                        throw new ArgumentException("The name can contain only letters");
                    }

                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;

            }
            set
            {
                foreach (var item in value)
                {
                    if (!Char.IsLetter(item))
                    {
                        throw new ArgumentException("The surname can contain only letters");
                    }

                }
                this.lastName = value;

            }
        }
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (!Regex.IsMatch(value, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{6}"))
                {
                    throw new ArgumentException("The format of the phone number is not correct");

                }
                this.mobilePhone = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (!IsValidEmail(value))
                {
                    throw new ArgumentException("The email is not valid");
                }
                this.email = value;
            }
        }
        public string FN
        {
            get
            {
                return this.fn;
            }
            private set
            {
                this.fn = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }
        }
        public int GroupNumber { get; set; }


        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void AddMark(int grade)
        {
            this.marks.Add(grade);
        }
        public void ChangeMark(int index, int newMark)
        {
            if (index > this.marks.Count || index < 0)
            {
                throw new ArgumentOutOfRangeException("That index is not valid");
            }
            this.marks[index] = newMark;
        }
        public override string ToString()
        {
            return String.Format("First Name:{0} Last Name:{1}", this.FirstName, this.LastName);
        }
    }
}
