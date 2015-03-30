namespace Students
{
    using System;
    public class Program
    {
        public static void Main()
        {
            Student pesho = new Student("Pesho", "Peshov", "Goshov", "OOP", Speciality.IT, University.TelerikAcademy, Faculty.TFS, "22333344");
            Student gosho = new Student(pesho);
            gosho.FirstName = "GOsho";
            Student peshoCopy = pesho;
            Student peshoCopy2 = new Student(pesho);


            Console.WriteLine("Pesho:\n" + pesho.ToString());
            Console.WriteLine("PeshoCopy:\n" + peshoCopy.ToString());
            Console.WriteLine("PeshoCopy2:\n" + peshoCopy2.ToString());
            Console.WriteLine("Gosho:\n" + gosho);

            Console.WriteLine("Pesho==peshoCopy ? " + (pesho == peshoCopy));
            Console.WriteLine("PeshoCopy2==peshp ? " + (peshoCopy2 == pesho));
            Console.WriteLine("PeshoCopy==peshoCopy2 ? " + (peshoCopy == peshoCopy2));
            Student cloneStudent = (Student)pesho.Clone();
            Console.WriteLine("Clone student==pesho ? " + (cloneStudent == pesho));
            Console.WriteLine("Gosho==pesho ? " + (pesho == gosho));

            Student ivan = new Student(pesho);
            ivan.FirstName = "Ivan";
            Student ana = new Student(pesho);
            ana.FirstName = "Ana";
            if (ivan.CompareTo(ana) < 0)
                Console.WriteLine("Ivan is before Ana");
            else
                if (ivan.CompareTo(ana) > 0)
                {
                    Console.WriteLine("Ana is before Ivan");
                }
                else
                {

                    Console.WriteLine("Their names are same");

                }
            Student ana1 = new Student(ana);
            ana1.SSN = "6555";

            if (ana.CompareTo(ana1) < 0)
            {
                Console.WriteLine("ana's ssn is before ana1's ssn");
            }
            else if(ana.CompareTo(ana1)>0)
                Console.WriteLine("ana1's ssn is before ana's ssn");
            else
                Console.WriteLine("Their ssns are the same");
           
            

        }
    }
}
