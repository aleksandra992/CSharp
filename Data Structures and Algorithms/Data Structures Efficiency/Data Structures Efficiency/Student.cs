namespace Data_Structures_Efficiency
{
    using System;

    public class Student : IComparable<Student>
    {
        public Student(string firstName, string lastName, Course course)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Course = course;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Course Course { get; set; }

        public int CompareTo(Student other)
        {
            if (this.LastName.CompareTo(other.LastName) == 0)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            else
            {
                return this.LastName.CompareTo(other.LastName);
            }
        }
    }
}
