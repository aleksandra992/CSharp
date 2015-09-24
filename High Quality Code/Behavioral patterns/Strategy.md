## Strategy ##

In Strategy pattern, a class behavior or its algorithm can be changed at run time. This type of design pattern comes under behavior pattern.

In Strategy pattern, we create objects which represent various strategies and a context object whose behavior varies as per its strategy object. The strategy object changes the executing algorithm of the context object.

##Class diagram##

![](strategy.gif)

~~~c#
namespace StrategyPattern
{
    public interface IInputProvider
    {
        int GetHeight();
        int GetWidth();
    }
}

~~~
~~~c#
namespace StrategyPattern
{
    public class ConsoleInputProvider:IInputProvider
    {
        public int GetWidth()
        {
            Console.WriteLine("Enter the width of the rectangle");
            return int.Parse(Console.ReadLine());
        }

        public int GetHeight()
        {
            Console.WriteLine("Enter the height of the rectangle");
            return int.Parse(Console.ReadLine());
        }
    }
}

~~~

~~~c#
namespace StrategyPattern
{
    public interface IDrawer
    {
        void Draw(IContentProvider provider);
    }
}


~~~

~~~c#
namespace StrategyPattern
{
    class ConsoleDrawer : IDrawer
    {
        public void Draw(IContentProvider provider)
        {
            Console.WriteLine(provider.GetContent());
        }
    }
}
~~~

~~~c#
namespace StrategyPattern
{
    public interface IShape:IContentProvider
    {
        float Area();

        float Perimeter();
    }
}
~~~
~~~c#
namespace StrategyPattern
{
    public class Rectangle : Shape
    {
        public float Height { get; set; }

        public float Width { get; set; }

        public Rectangle(IInputProvider input)
            : base(input)
        {
            this.Height = input.GetHeight();
            this.Width = input.GetWidth();
        }
        public override float Area()
        {
            return this.Height * this.Width;
        }

        public override float Perimeter()
        {
            return 2 * (this.Width + this.Height);
        }

    }
}
~~~
~~~c#
namespace StrategyPattern
{
    public abstract class Shape:IShape,IContentProvider
    {
        IInputProvider widthAndHeightInput;
        
        public Shape(IInputProvider input)
        {
            widthAndHeightInput = input;
        }


        public abstract float Area();

        public abstract float Perimeter();


        public string GetContent()
        {
            return string.Format("The aresa of the rectangle is {0} ", this.Area());
        }
    }
}
~~~
~~~c#
namespace StrategyPattern
{
    public interface IContentProvider
    {
        string GetContent();
    }
}
~~~
Usage
~~~c#
namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IInputProvider input = new ConsoleInputProvider();
            IShape rectangle = new Rectangle(input);
            IDrawer drawer = new ConsoleDrawer();
            drawer.Draw(rectangle);

        }
    }
}
~~~
