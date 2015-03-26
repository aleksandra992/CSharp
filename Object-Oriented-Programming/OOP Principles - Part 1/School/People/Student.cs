namespace School.People
{
    using System;
    public class Student : Person,IComments
    {
        private int classIdentifier;
        public Student(string name, int classidentifier)
            : base(name)
        {
            this.ClassIdentifier = classidentifier;

        }
        public int ClassIdentifier
        {
            get
            {
                return this.classIdentifier;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("The identifier cannot be negative");
                }
                this.classIdentifier = value;
            }
        }
        public override string ToString()
        {
            return String.Format("Student:{0}\n Comment{1}", this.Name,this.Comment);
        }



    }
}
