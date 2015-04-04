using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class Teahcer:ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;
        public Teahcer(string name)
        {
            this.name = name;
            courses = new List<ICourse>();

        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The teacher name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            courses.Add(course);
        }
        public override string ToString()
        {

            
            StringBuilder teaherString=new StringBuilder();
            string result=string.Empty;
            teaherString.Append(string.Format("Teacher: Name={0}",this.Name));

            if (this.courses.Count != 0)
            {
                teaherString.Append("; Courses=[");



                foreach (var course in this.courses)
                {
                    teaherString.Append(course.Name + ", ");

                }



                result = teaherString.ToString().Trim(',', ' ');

                result += "]";
                return result;
            }
            return teaherString.ToString();
            
           
	{
		 
	}
        }
    }
}
