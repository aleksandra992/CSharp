namespace Proxy
{
    using System;

    public class RealSubject : ISubject
    {
        private readonly String name;

        public RealSubject(String name)
        {
            this.name = name;
            this.Load(name);
        }


        public void Display()
        {
            Console.WriteLine("Displaying " + name);
        }


        private void Load(String name)
        {
            Console.WriteLine("Loading " + name);
        }
    }
}
