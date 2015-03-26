namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
   public  class TestingStudentAndWorkers
    {
       public static void Test()
       {
           List<Student> students = new List<Student>()
           {
               new Student("Pesho","Peshov",1),
               new Student("Ivan","Ivanov",2),
               new Student("Peetar","Petrov",3),
               new Student("Niki","Kostov",3),
               new Student("Doncho","Minkov",5),
               new Student("Ivailo","Kenov",6),
               new Student("Evlogi","Hristov",4),
               new Student("Gorgi","Gorgiev",4),
               new Student("Maria","Ivanova",6),
               new Student("Viki","Peshova",1)
           };
           Console.WriteLine("All students ordered by grade");
           foreach (var student in SortByGrade(students))
           {
               Console.WriteLine(student);
               
           }
           Console.WriteLine();
           List<Worker> workers = new List<Worker>()
           {
              new Worker("Pesho","Peshov",550,8),
               new Worker("Ivan","Ivanov",600,8),
               new Worker("Peetar","Petrov",300,12),
               new Worker("Niki","Kostov",400,8),
               new Worker("Doncho","Minkov",300,7),
               new Worker("Ivailo","Kenov",600,5),
               new Worker("Evlogi","Hristov",600,7),
               new Worker("Gorgi","Gorgiev",550,8),
               new Worker("Maria","Ivanova",400,7),
               new Worker("Viki","Peshova",450,9)
           };

           Console.WriteLine("All workers in descending order, ordered by Money per hour");
           foreach (var worker in SortByMoneyPerHour(workers))
           {
               Console.WriteLine(worker);

           }
           Console.WriteLine();
           Console.WriteLine("All people ordered by last and first name");
           foreach (var person in SortedMergedLists(students,workers))
           {
               Console.WriteLine(person);

           }

       }
       public static List<Student> SortByGrade(List<Student> students)
       {
           return students.OrderBy(x => x.Grade).ToList();
       }

       public static List<Worker> SortByMoneyPerHour(List<Worker> workers)
       {
           return workers.OrderByDescending(x =>x.MoneyPerHour()).ToList();
       }
       public static List<Human> SortedMergedLists(List<Student> students, List<Worker> workers)
       {
           List<Human> people = new List<Human>();
           people.AddRange(students);
           people.AddRange(workers);

           return people.OrderBy(x=>x.FirstName)
               .ThenBy(x=>x.LastName).ToList();
       }
    }
}
