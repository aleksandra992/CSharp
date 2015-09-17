namespace Decorator
{
    public abstract class ShapeDecorator : Shape
    {
        protected ShapeDecorator(Shape shape)
        {
            this.Shape = shape;
        }

        protected Shape Shape { get; set; }

        public override void Draw()
        {
            this.Shape.Draw();
        }
    }
}
