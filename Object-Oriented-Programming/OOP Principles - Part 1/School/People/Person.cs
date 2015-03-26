namespace School.People
{
    using System;
    
    public  class Person : IPerson,IComments
    {
        private string name;
        private string comment;
        public Person(string name)
        {
            this.name = name;

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
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                this.name = value;
            }
        }


        public string Comment
        {
            get
            {
                if (string.IsNullOrEmpty(this.comment))
                {
                    return "No comment";
                }
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
    }
}
