namespace School.People
{
    using System;
    using System.Collections.Generic;
    public class Teacher : Person,IComments
    {
        private List<Discipline> disciplines;

        public Teacher(string name,List<Discipline> d)
            : base(name)
        {
            this.disciplines = new List<Discipline>(d);
        }
        public Teacher(string name):base(name)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
               
                return new List<Discipline>(this.disciplines);
            }
        }

        public void AddDiscipline(Discipline d)
        {
            this.disciplines.Add(d);
        }
        public override string ToString()
        {

            return String.Format("Teacher:{0}\n Disciplines:{1}\n Comment:{2}", this.Name, (this.Disciplines.Count != 0) ? (string.Join(",", this.Disciplines)) : "0", this.Comment);
        }
    }
}
