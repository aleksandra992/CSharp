using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int firstPartSize=n/2;
            int secondPartSize=n/4;
            int thirdPartSize = firstPartSize;
            string leftPoints = "", centerPoints = "",lines="";
            int countLeftPoints=(n-2)/2;
            int countCenterPoints=0;
            for (int i = 0; i < firstPartSize; i++)
            {
                leftPoints = new String('.', countLeftPoints);
                centerPoints = new String('.', countCenterPoints);
                Console.WriteLine(leftPoints + "#" + centerPoints + "#" + leftPoints);
                countLeftPoints--;
                countCenterPoints += 2;
            }
            countLeftPoints++;
            countCenterPoints -= 2;
            for (int i = 0; i < secondPartSize; i++)
            {
                leftPoints = new String('.', countLeftPoints);
                centerPoints = new String('.', countCenterPoints);
                Console.WriteLine(leftPoints + "#" + centerPoints + "#" + leftPoints);
                countLeftPoints++;
                countCenterPoints -= 2;
            }
            Console.WriteLine(new String('-', n));
            countLeftPoints = 0;
            int countLeftSlashes=n/2,countrightSlashes = n/2;
            string leftSlashes = "", rightSlashes = "";
            for (int i = 0; i < thirdPartSize; i++)
            {
                leftPoints = new String('.', countLeftPoints);
                leftSlashes = new String('\\', countLeftSlashes);
                rightSlashes = new String('/', countrightSlashes);
                countLeftSlashes--;
                countrightSlashes--;
                countLeftPoints++;
                Console.WriteLine(leftPoints + leftSlashes + rightSlashes + leftPoints);



            }

            
        }
    }

