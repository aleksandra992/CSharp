namespace CSharp1Exam
{
    using System;

    public class Money
    {
        public static void Main()
        {
            const decimal AmountOfSheetsInRealm = 400;

            long numberOfStudents = long.Parse(Console.ReadLine());
            long numberOfSheetsForEachStudent = long.Parse(Console.ReadLine());
            decimal priceOfRealm = decimal.Parse(Console.ReadLine());
         
            decimal savedAmountOfMoney = ((numberOfStudents * numberOfSheetsForEachStudent) / AmountOfSheetsInRealm) * priceOfRealm;
            Console.WriteLine("{0:F3}", savedAmountOfMoney);
        }
    }
}