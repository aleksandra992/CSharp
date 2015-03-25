namespace _7.Timer
{
    using System;
    using System.Threading;
    public delegate void SomeDelegate(string input);
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Timer timer = new Timer();
                timer.Miliseconds =1000;
                SomeDelegate d = new SomeDelegate(timer.SomeMethod);
                d("neshto");
                Thread.Sleep(timer.Miliseconds);


            }
        }

    }
    public class Timer
    {
        private int miliseconds;
        public int Miliseconds
        {
            get
            {
               
                    return this.miliseconds;
            }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The miliseconds cannot be less than 0");
                }
                this.miliseconds = value;
            }
        }
        public void SomeMethod(string input)
        {
            Console.WriteLine(input);
        }
    }
}
