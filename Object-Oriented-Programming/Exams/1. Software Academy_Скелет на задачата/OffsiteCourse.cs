namespace SoftwareAcademy
{
    using System;
    public class OffsiteCourse : Course, IOffsiteCourse,ICourse
    {

        public OffsiteCourse(string name,ITeacher teacher,string town):base(name,teacher)
        {
            this.Town = town;
        }
        private string town;
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The town cannot be null or empty");
                }
                this.town = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + string.Format("; Town={0}",this.Town);
        }
    }
}
