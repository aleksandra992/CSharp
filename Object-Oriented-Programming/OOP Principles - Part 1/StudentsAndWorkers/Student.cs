namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private double grade;

        public double Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value< 0)
                {
                    throw new ArgumentException("The grade cannot be negative");
                }
                this.grade = value;
            }
        }
        public Student(string firstName,string lastName,double grade):base(firstName,lastName)
        {
            this.Grade = grade;

        }
        public override string ToString()
        {
            return base.ToString()+String.Format(" grade:{0}",this.Grade);
        }
    }
}
