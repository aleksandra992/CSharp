using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double height = 6 + ((n - 3) / 2.0 * 3);
        string first;
        string second;
        string third;
        double upperPart = 1 / 3.0 * height;
        int numberDots1 = (int)upperPart;
        int numberDots2;
        first = new String('.', numberDots1);
        second = new String('*', n);
        Console.WriteLine(first + second + first);
        numberDots1--;
        numberDots2 = numberDots1;
        for (int i = 1; i < 1 / 3.0 * height; i++)
        {
            
            first = new String('.', numberDots1);
            second = new String('.', numberDots2);
            Console.WriteLine(first + "*" + second + "*" + second + "*" + first);
            numberDots1--;
            numberDots2++;


        }
        numberDots1++;
        numberDots2--;
        third = new String('*', n * 2 + 1);
        Console.WriteLine(third);
        for (int i = 0; i < (2 * height)/3 - 2; i++)
        {
            Console.WriteLine(first + "*" + second + "*" + second + "*" + first);
            if (numberDots2 == 0)
            {
                break;
            }
            numberDots1++;
            numberDots2--;
            
            first = new String('.', numberDots1);
            second = new String('.', numberDots2);

        }
        string fourth = new String('.', n);
        Console.WriteLine(fourth + "*" + fourth);





    }
}

