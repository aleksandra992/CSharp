namespace Data_Structures_Efficiency
{
    using System;

    public class Course : IComparable<Course>
    {
        public Course(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public int CompareTo(Course other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
