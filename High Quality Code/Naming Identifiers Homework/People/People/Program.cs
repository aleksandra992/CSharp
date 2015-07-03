namespace people
{
    using System;
    public class People
    {
        public  enum Gender { Male, Female };
        public People()
        {

        }
        public class Person
        {
            public Gender Gender { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }

            public Person()
            {

            }
            public void toString()
            {
                Console.WriteLine("name:{0}, age:{1}, gender:{2}", this.Name, this.Age, this.Gender);

            }
        }
        public  void MakePerson(int age)
        {
            Person person = new Person();
            person.Age = age;
            if (age % 2 == 0)
            {
                person.Name = "Батката";
                person.Gender = Gender.Male;
            }
            else
            {
                person.Name = "Мацето";
                person.Gender = Gender.Female;
            }
            person.toString();
        }
        static void Main(string[] args)
        {
            int personAge = 18;
            var people = new People();
            people.MakePerson(personAge);
        }
    }
}
