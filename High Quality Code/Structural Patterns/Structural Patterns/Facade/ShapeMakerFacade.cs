namespace Facade
{
    public class ShapeMakerFacade
    {
        private readonly IShape circle;
        private readonly IShape rectangle;

        public ShapeMakerFacade()
        {
            circle=new Circle();
            rectangle=new Rectangle();
        }

        public void DrawCircle()
        {
            circle.Draw();
        }

        public void DrawRectangle()
        {
            rectangle.Draw();
        }
    }
}
