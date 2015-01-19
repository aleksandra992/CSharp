using System;


namespace OddOrEven
{
    class Program
    {

        static void Main()
        {
            Console.Write("Type a number n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Type \"odd\" or \"even\" : ");
            string numType = Console.ReadLine().ToLower(); // make all letters small

            switch (numType)
            {
                case "even":
                    {
                        if (n % 2 == 0)
                            Console.WriteLine(true);
                        else
                            Console.WriteLine(false);
                        break;
                    }

                case "odd":
                    {
                        if (n % 2 == 1)

                            Console.WriteLine(true);
                        else
                            Console.WriteLine(false);

                        break;
                    }

                default:
                    {
                        Main();// reqursive call to Main function till correct text is added (ex. 'odd','ODD','eVen');
                        break;
                    }



            }
        }
    }
}
