namespace Proxy
{
    using System;

    public class Proxy : ISubject
    {
        private RealSubject realSubject;
        private readonly String name;

        public Proxy(String name)
        {
            this.name = name;
        }

        public void Display()
        {
            if (realSubject == null)
            {
                realSubject = new RealSubject(name);
            }
            realSubject.Display();
        }
    }
}
