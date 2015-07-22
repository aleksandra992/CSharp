using System;

namespace Methods
{

    public class Methods
    {
        public enum LinePosition
        {
            Vertical,
            Horizontal,
            Other,
            NoLine
        }

        public const string FloatFormat = "f";
        public const string PercentageFormat = "%";
        public const string RightAligmentFormat = "r";

        internal static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("All the three sides must be positive numbers");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }


        internal static string NumberToDigit(int number)
        {
            string digit = string.Empty;
            switch (number)
            {
                case 0: digit = "zero"; break;
                case 1: digit = "one"; break;
                case 2: digit = "two"; break;
                case 3: digit = "three"; break;
                case 4: digit = "four"; break;
                case 5: digit = "five"; break;
                case 6: digit = "six"; break;
                case 7: digit = "seven"; break;
                case 8: digit = "eight"; break;
                case 9: digit = "nine"; break;
                default: throw new ArgumentOutOfRangeException("Invalid number!");
            }

            return digit;
        }

        internal static int FindMax(params int[] elements)
        {
            int maxElement = Int16.MinValue;
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("The elements should not be empty or null");
            }

            int currentElement = 0;
            for (int i = 1; i < elements.Length; i++)
            {
                currentElement = elements[i];
                if (currentElement > maxElement)
                {
                    maxElement = currentElement;
                }
            }
            return maxElement;
        }

        internal static void PrintAsNumber(object number, string format)
        {
            if (format == FloatFormat)
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == PercentageFormat)
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == RightAligmentFormat)
            {
                Console.WriteLine("{0,8}", number);
            }
        }


        internal static double CalcDistance(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double substructionX = secondPointX - firstPointX;
            double substructionY = secondPointY - firstPointY;
            double distanceBetweenTwoPoints = Math.Sqrt((substructionX) * (substructionX) + (substructionY) * (substructionY));
            return distanceBetweenTwoPoints;
        }
        internal static LinePosition GetLinePosition(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            LinePosition linePosition = LinePosition.Other;
            if (firstPointX == secondPointX && firstPointY == secondPointY)
            {
                linePosition = LinePosition.NoLine;
            }
            else
                if (firstPointX == secondPointX)
                {
                    linePosition = LinePosition.Vertical;
                }
                else
                    if (firstPointY == secondPointY)
                    {
                        linePosition = LinePosition.Horizontal;
                    }
                    else
                    {
                        linePosition = LinePosition.NoLine;
                    }
            return linePosition;
        }

        internal static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToDigit(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            Console.WriteLine(CalcDistance(3, -1, 3, 2.5));
            Console.WriteLine("Horizontal? " + (GetLinePosition(3, -1, 3, 2.5) == LinePosition.Horizontal));
            Console.WriteLine("Vertical? " + (GetLinePosition(3, -1, 3, 2.5) == LinePosition.Vertical));

            Student peter = new Student("Peter", "Ivanov", "Sofia", new DateTime(1992, 03, 17));
            Student stella = new Student("Stella", "Markova", "Vidin", new DateTime(1993, 11, 3));


            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
