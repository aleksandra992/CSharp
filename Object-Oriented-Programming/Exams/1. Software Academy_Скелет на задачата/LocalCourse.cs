namespace SoftwareAcademy
{
    using System;

    public class LocalCourse:Course,ILocalCourse,ICourse
    {
        public LocalCourse(string name,ITeacher teacher,string lab):base(name,teacher)
        {
            this.lab = lab;

        }
        private string lab;
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The local course must have lab");
                }
                this.lab = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("; Lab={0}",this.Lab);
        }
    }
}
