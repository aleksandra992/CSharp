﻿

namespace Students
{
    using System;

    public class Student
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public Student(string firstName,string lastName,int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;

        }
        public override string ToString()
        {
            return String.Format("First Name: {0}\nLast Name: {1}", this.FirstName, this.LastName);
        }
      
    }
}
