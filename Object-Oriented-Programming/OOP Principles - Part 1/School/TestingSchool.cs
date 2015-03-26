namespace School
{
    //We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches a set of disciplines. Students have name and unique class number. Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
    //Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class hierarchy and create a class diagram with Visual Studio.
    using System;
    using School.People;
    using System.Collections.Generic;

    public class TestingSchool
    {
        public static void Test()
        {
            List<Discipline> disciplinesPesho = new List<Discipline>() { new Discipline("Math", 5, 4) };
            List<Discipline> disciplinesIvan = new List<Discipline>() { new Discipline("Georgraphy", 10, 10) };
            List<IPerson> schoolPeople = new List<IPerson>(){
            new Student("Gosho",1),
            new Teacher("Pesho",disciplinesPesho),
            new Teacher("Ivan",disciplinesIvan)
         };
           
            SchoolClass schoolClass = new SchoolClass("FirstClass", 1);

          
            


            foreach (var item in schoolPeople)
            {
               
                Console.WriteLine(item);

            }
        }
    }
}
