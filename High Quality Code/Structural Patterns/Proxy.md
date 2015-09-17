## Proxy ##

A proxy, in its most general form, is a class functioning as an interface to something else. The proxy could interface to anything: a network connection, a large object in memory, a file, or some other resource that is expensive or impossible to duplicate. In short, a proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes.

##Class diagram##

![](proxy.gif)

~~~c#
namespace Proxy
{
    interface ISubject
    {
        void Display();
    }
}
~~~
~~~c#
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

~~~

~~~c#
namespace Decorator
{
    using System;

    public class Rectangle:Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Shape:Rectangle");
        }
    }
}

~~~

~~~c#
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


~~~

Usage
~~~c#
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

~~~
