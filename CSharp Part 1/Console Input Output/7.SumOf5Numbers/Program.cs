using System;


namespace _7.SumOf5Numbers
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter 5 digits separted with space");
            string s = Console.ReadLine();
          
            string[] numbers = s.Split(' ');
            float sum=0;
            for (int i = 0; i < numbers.Length;i++ )
            {
                sum += float.Parse(numbers[i]);
            }
            Console.WriteLine("the sum is {0}", sum);
        }
    }
}
