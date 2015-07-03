namespace printer
{
    using System;

    public class Printer
    {
        private const int MaxCount = 6;

        public static void Main()
        {
            Printer.BooleanPrinter variable = new Printer.BooleanPrinter();
            variable.Print(true);
        }

        public class BooleanPrinter
        {
            public void Print(bool boolVariable)
            {
                string stringVariable = boolVariable.ToString();
                Console.WriteLine(stringVariable);
            }
        }
    }
}
