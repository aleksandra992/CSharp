﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course
    {
        public LocalCourse(string courseName, string teacherName, List<string> students, string lab)
            : base(courseName, courseName, students)
        {
            this.Lab = lab;
        }

        public LocalCourse(string courseName, string teacherName, List<string> students)
            : this(courseName, teacherName, students, null)
        {
        }

        public LocalCourse(string courseName, string teacherName)
            : this(courseName, teacherName, null, null)
        {
        }

        public LocalCourse(string courseName)
            : this(courseName, null, null, null)
        {
        }

        public string Lab { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }

            result.Append(" }");
            return result.ToString();
        }
    }
}
