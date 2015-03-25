namespace _9.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class TestingStudents
    {
        public static void TestStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pesho", "Peshov", "00359888123456", "pesho@abv.bg", 2,"1236405"));
            students.Add(new Student("Atanas", "Peshov", "00359888123456", "atanas@yahoo.com", 2,"0800006"));
            students.Add(new Student("Bobi", "Peshov", "00359888123456", "atanas@abv.bg", 2,"1118105"));
            students.Add(new Student("Boris", "Peshov", "00359888123456", "atanas@yahoo.com", 4,"14464444"));
            students[0].AddMark(6);
            students[0].AddMark(5);
            students[1].AddMark(2);
            students[1].AddMark(2);
            students[2].AddMark(2);
            students[2].AddMark(4);
            students[3].AddMark(2);
            students[3].AddMark(6);

            var studentsInGroup2 = from st in students
                                   where st.GroupNumber == 2
                                   orderby st.FirstName
                                   select new { FirstName=st.FirstName,LastName=st.LastName};

            // 9. Student groups
            Console.WriteLine("\nThe students that are in group 2 are");
            foreach (var item in studentsInGroup2)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName);

            }

            var studentInGroup2EM = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);
            //10. Student groups extensions
            Console.WriteLine("\n(Extension methods)The students that are in group 2 are");
            foreach (var item in studentInGroup2EM)
            {
                Console.WriteLine(item);

            }
            // 11. Extract students by email
            Console.WriteLine("\nThe students that have abv.bg in their email are");

            var studentsAbv = from st in students
                              where st.Email.Contains("abv.bg")
                              select st;
            foreach (var item in studentsAbv)
            {
                Console.WriteLine(item);

            }
            // 12. Extract students by phone
            Console.WriteLine("\nThe students that have bg phone numbers are");
            var studentsBg = from st in students
                             where st.MobilePhone.StartsWith("+359") || st.MobilePhone.StartsWith("00359")
                             select st;
            foreach (var item in studentsBg)
            {
                Console.WriteLine(item);

            }
            // 13. Extract students by marks
            Console.WriteLine("\nThe students that have at least one 6 mark are");


            var studentsWith6 = from st in students
                                where st.Marks.Contains(6)
                                select new { FullName=st.FirstName+" "+st.LastName, Marks=st.Marks };

            foreach (var item in studentsWith6)
            {
                Console.WriteLine(item.FullName + " Marks:"+string.Join(",",item.Marks.ToArray()));

            }
            // 14. Extract students with two marks
            Console.WriteLine("\nThe students with two marks 2 are");
            var StudentsWithTwoMarks = students.Where(stud => stud.Marks.Count(p => p == 2) == 2);
                foreach(Student k in StudentsWithTwoMarks)
                {
                    Console.WriteLine(k);
                }
            //15. Extract marks
                Console.WriteLine("\nThe marks of the students that enrolled in 2006 are");
                var marks2006 = students.Where(st => (st.FN[5] == '0' && st.FN[6] == '6')).SelectMany(s=>s.Marks);
                
                    Console.WriteLine(string.Join(",",marks2006));

            //  16.* Groups
                    Console.WriteLine("\n The students from Mathematics are");
            List<Group> groups=new List<Group>();
            groups.Add(new Group(2,"Mathematics"));
            var studentInMath = from s in students
                                join g in groups on s.GroupNumber equals g.GroupNumber
                                select s;
            foreach (var k in studentInMath)
            {
                Console.WriteLine(k);
            }

           // 18. Grouped by GroupNumber
            Console.WriteLine("\n The students grouped by Number are");
            var groupByNumber = from st in students
                                group st by st.GroupNumber;
                                
                               
                               
            foreach (var group in groupByNumber)
            {
                Console.WriteLine("\nGroup"+group.Key);
                foreach (var student in group)
                {
                    Console.WriteLine(student);
                }
              
            }
            //19. Grouped by GroupName extensions
            var groupByNumberExt = students.GroupBy(x => x.GroupNumber);
            foreach (var group in groupByNumberExt)
            {
                Console.WriteLine("\n(Extension methods)Group" + group.Key);
                foreach (var student in group)
                {

                    Console.WriteLine(student);
                }
                
            }
        }
    }
}
