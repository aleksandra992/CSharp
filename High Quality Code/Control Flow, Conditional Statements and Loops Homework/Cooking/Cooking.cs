namespace Cooking
{
    using System;
    using Dishes;

    public class Cooking
    {
        public static void Main()
        {
            Chef chef = new Chef();
            Bowl bowl = chef.Cook();
            Console.WriteLine(bowl);
        }
    }
}