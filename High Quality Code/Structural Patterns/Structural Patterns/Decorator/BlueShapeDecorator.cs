namespace Decorator
{
    using System;
    public class BlueShapeDecorator : ShapeDecorator
    {
        public BlueShapeDecorator(Shape shape)
            : base(shape)
        {

        }

        public override void Draw()
        {
            this.Shape.Draw();
            SetBorder(this.Shape);
        }

        private void SetBorder(Shape shape)
        {
            Console.WriteLine("Border color:Blue");

        }
    }
}
