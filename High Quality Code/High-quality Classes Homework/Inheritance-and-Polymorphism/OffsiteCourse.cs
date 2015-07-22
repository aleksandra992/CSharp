using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public OffsiteCourse(string courseName, string teacherName, List<string> students, string town)
            : base(courseName, courseName, students)
        {
            this.Town = town;
        }

        public OffsiteCourse(string courseName, string teacherName, List<string> students)
            : this(courseName, courseName, students, null)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, courseName, null, null)
        {
        }

        public OffsiteCourse(string courseName)
            : this(courseName, null, null, null)
        {
        }

        public string Town { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Town != null)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
