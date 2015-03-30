


namespace Person
{
    using System;
    public class Person
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Person(string name,int? age)
        {
            this.Name = name;
            this.Age = age;

        }
        public Person(string name):this(name,null)
        {

        }
        string ageNull = "The age is not set";
        public override string ToString()
        {
            return string.Format("Name: {0} Age: {1}", this.Name, this.Age!=null?this.Age.ToString():ageNull);
        }
    }
}
