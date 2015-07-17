namespace CSharpt1Exam
{
    using System;
    using System.Text;

    public class ThreeDCube
    {
        public static void Main()
        {
            int sizeOfTheCube = int.Parse(Console.ReadLine());
            Console.WriteLine(Get3DCube(sizeOfTheCube));

        }
        public static string Get3DCube(int sizeOfTheCube)
        {
            string firstLine = new String(':', sizeOfTheCube);
            string rightSide = new String(':', 1);
            string leftSideUp = ":" + new String(' ', sizeOfTheCube - 2) + ":";
            string leftSideDown = " :" + new String('-', sizeOfTheCube - 2) + ':';
            StringBuilder cube = new StringBuilder();

            cube.AppendLine(firstLine);

            for (int i = 1; i < sizeOfTheCube - 1; i++)
            {
                cube.AppendLine(leftSideUp + rightSide);
                rightSide = "|" + rightSide;
            }

            cube.AppendLine(firstLine + rightSide);
            int numberOfLinesToRemove = 1;
            string rightSideDown = rightSide;
            for (int i = 0; i < sizeOfTheCube - 2; i++)
            {
                cube.AppendLine(leftSideDown + rightSideDown.Remove(0, numberOfLinesToRemove));
                leftSideDown = " " + leftSideDown;
                numberOfLinesToRemove++;
            }

            string lastLine = new String(' ', sizeOfTheCube - 1) + firstLine;
            cube.AppendLine(lastLine);
            return cube.ToString();
        }
    }

}
