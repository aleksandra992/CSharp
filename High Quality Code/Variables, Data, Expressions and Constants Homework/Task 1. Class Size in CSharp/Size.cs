namespace SizeOperations
{
    using System;
    /// <summary>
    /// A Class for size
    /// </summary>
    public class Size
    {

        private double width, height;

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
        /// <summary>
        /// Method for calculation new size, depending on the old size and angle N
        /// </summary>
        /// <param name="size">The size that we want to rotate</param>
        /// <param name="angleOfTheFigureThatWillBeRotated">The degrees of rotation </param>
        /// <returns>Return object Size with the new width and height</returns>
        public static Size GetRotatedSize(Size size, double angleOfTheFigureThatWillBeRotated)
        {
            double cosinusOfAngle = Math.Cos(angleOfTheFigureThatWillBeRotated);
            double sinusOfAngle = Math.Sin(angleOfTheFigureThatWillBeRotated);
            double rotatedHeight = Math.Abs(sinusOfAngle) * size.Width + Math.Abs(cosinusOfAngle) * size.Height;
            double rotatedWidth = Math.Abs(cosinusOfAngle) * size.Width + Math.Abs(sinusOfAngle) * size.Height;
            Size rotatedSize = new Size(rotatedWidth, rotatedHeight);
            return rotatedSize;
        }
    }
}