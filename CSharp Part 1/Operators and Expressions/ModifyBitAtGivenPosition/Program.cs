using System;


namespace ModifyBitAtGivenPosition
{
    class Program
    {
        static void Main()
        
       {
            int newNumber=new int();
            Console.WriteLine("enter the number"); 
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position");
            int position = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number k");
            byte k = byte.Parse(Console.ReadLine());
            
            if (k == 1)
            {
                newNumber = number | (1<<position);//make a number that has 1 only on the p position and do an 'or' operation so the bit on the position p can be assigned as 1

            }

            else if (k==0)
            {
                newNumber = number & ~(1 << position);//do the oposite from above(make a number that has only one 0 on the exact position and do an 'and' operation with the number
            }


            Console.WriteLine(newNumber);

        }
    }
}
