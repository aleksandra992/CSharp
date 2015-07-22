using System;

namespace Methods
{
    class Student
    {
        public Student(string firstName, string lastName, string city, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.BirthDate = birthDate;

        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }

        public DateTime BirthDate { get; set; }

        public bool IsOlderThan(Student other)
        {
            bool isOlderThan;
            int integerVariableForOlderThan = DateTime.Compare(this.BirthDate, other.BirthDate);

            if (integerVariableForOlderThan >= 0)
            {
                isOlderThan = false;
            }
            else
            {
                isOlderThan = true;
            }

            return isOlderThan;
        }
    }
}
