


namespace SoftwareAcademy
{
    using System;

    using System.Collections.Generic;
    using System.Text;
    public class Course : ICourse
    {
        private string name;
        private ICollection<string> topics;
        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            topics = new List<string>();

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
                    throw new ArgumentNullException("The name cannot be null or empty");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get;

            set;

        }

        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }
        public override string ToString()
        {
            return string.Format("{0}: Name={1}{2}{3}",
                this.GetType().Name,this.Name,this.Teacher!=null?("; Teacher="+this.Teacher.Name):"",this.topics.Count!=0?("; Topics=["+GetAllTopics(topics)+"]"):"");
        }

        public string GetAllTopics(ICollection<string> topics)
        {
            return string.Join(", ", topics);
        }
    }
}
