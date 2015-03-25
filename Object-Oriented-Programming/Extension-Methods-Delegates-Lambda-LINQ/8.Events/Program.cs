namespace _8.Events
{
    using System;
    public class Program
    {
        public static void Main()
        {
            //Timer timer = new Timer();
            //timer.Miliseconds = 1000;
            //timer.Timer += timer.SomeMethod;

        }
    }

    public class Timer {
        public event EventHandler Timer;

        private int miliseconds;
        public int Miliseconds
        {
            get
            {

                return this.miliseconds;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The miliseconds cannot be less than 0");
                }
                this.miliseconds = value;
            }
        }
        protected virtual void onTimer(EventArgs e)
        {
            if (this.Timer != null)
            {
                this.Timer(this, e);
            }
        }
        public void SomeMethod(object sender,EventArgs e)
        {
            Console.WriteLine("neshto");
        }
    }
}
