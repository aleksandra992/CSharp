namespace School
{
    using System;
    using System.Collections.Generic;
    using School.People;
    public class SchoolClass:IComments
    {
        private List<Teacher> teachers = new List<Teacher>();
        private string name;
        private int classIdentifier;
        private static List<int> identifiers = new List<int>();

        public SchoolClass(string name, int classIdentifier)
        {
            this.Name = name;
            this.ClassIdentifier = classIdentifier;
            identifiers.Add(classIdentifier);
            this.teachers = new List<Teacher>();

        }

        public List<Teacher> Teacher
        {
            get
            {
                if (this.teachers.Count == 0)
                {
                    throw new ArgumentNullException("There are no teachers");
                }
                return new List<Teacher>(this.teachers);
            }
        }
        public int ClassIdentifier
        {
            get {
                return this.classIdentifier;
            }
            private set
            {
                if (identifiers.Contains(value))
                {
                    throw new ArgumentException("The identifier must be unique.That class identifier already exist");
                }
                this.classIdentifier = value;
            }
        }


        public string Name
        {
            get
            {
                if (this.name == null)
                {
                    throw new ArgumentNullException("The name is not set");
                }
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The name cannot be empty");
                }
                this.name = value;
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public string Comment
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
