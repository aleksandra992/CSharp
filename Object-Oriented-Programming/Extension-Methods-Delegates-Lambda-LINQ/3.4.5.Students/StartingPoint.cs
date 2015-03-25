namespace Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class StartingPoint
    {
        public static void Main()
        {
            List<Student> students = new List<Student>{
                                new Student("Pesho","Peshov",18),
                                 new Student("Aneliq","Ivanoa",20),
                                new Student("Mariq","Ivanova",22),
                                new Student("Peter","Kirov",25),
                                new Student("Ivan","Kirov",14   )
                             };
//FirstName before LastName
           // with extension method
          //  List<Student> firstBeforeLast = students.Where(s => s.FirstName.ToUpper().First() < s.LastName.ToUpper().First()).ToList();
            //with LINQ
            var firstBeforeLastPrim = from st in students
                                      where st.FirstName[0] < st.LastName[0]
                                      select new Student( st.FirstName, st.LastName,st.Age);
            
            Console.WriteLine("The students that their firstname is before their last are");
            foreach (var item in firstBeforeLastPrim)
            {
                Console.WriteLine(item.ToString());
            }
//Age between 18 and 24
            var ageBetween18and24 = from st in students
                                    where st.Age < 24 && st.Age > 18
                                    select new { st.LastName, st.FirstName };

            Console.WriteLine("The students that are between 18 and 24 year old are:");
            foreach (var item in ageBetween18and24)
            {
                Console.WriteLine(item.ToString());
            }

//Order Students with extension methods

            var orderedStudents = students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.LastName).ToList();
            Console.WriteLine("The list with ordered students is");
            foreach (var item in orderedStudents)
            {
                Console.WriteLine(item.ToString());
            }
//Order Students with LINQ

            var orderedStudentsWithLinq = from st in students

                                          orderby st.FirstName descending, st.LastName descending
                                          select new Student(st.FirstName, st.LastName,st.Age);


            Console.WriteLine("(LINQ)The list with ordered students is");
            foreach (var item in orderedStudentsWithLinq)
            {
                Console.WriteLine(item.ToString());
            }
            



        }
    }
}
