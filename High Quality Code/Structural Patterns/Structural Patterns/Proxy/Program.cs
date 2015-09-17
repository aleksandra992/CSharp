namespace Proxy
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy("someSubject");
            subject.Display();
            Console.WriteLine("--------");
            subject.Display();
        }
    }
}
