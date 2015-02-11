using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int min = max;
        int sum=max;
        float average=0;
        for (int i = 2; i <= n; i++)
        {
            int next = int.Parse(Console.ReadLine());
            if (next > max)
            {
                max = next;
            }
            else
            if (next < min)
            {
                min = next;
            }
            sum += next;
        }
        Console.WriteLine("min={0}\nmax={1}\nsum={2}\navg={3:0.00}", min, max, sum, sum /(float)n);

    }
}

