namespace Data_Structures_Efficiency
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main(string[] args)
        {
            string path = "../../students.txt";
            var courses = new SortedDictionary<Course, SortedSet<Student>>();
            using (StreamReader reader = new StreamReader(path))
            {
                var line = reader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    var lineParts = line.Split(new char[] { '|', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    var course = new Course(lineParts[2]);
                    var student = new Student(lineParts[0], lineParts[1], course);
                    if (!courses.ContainsKey(course))
                    {
                        courses.Add(course, new SortedSet<Student>());
                    }
                    courses[course].Add(student);
                    line = reader.ReadLine();
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine("{0}: {1}", course.Key.Name, string.Join(", ", course.Value.Select(x => x.FirstName + " " + x.LastName)));
            }
        }
    }
}
