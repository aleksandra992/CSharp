using System;

namespace CohesionAndCoupling
{
    public class UtilsExamples
    {
        public static void Main()
        {
            File file = new File("example");
            File pdfFile = new File("example.pdf");
            File newPdfFile = new File("example.new.pdf");
            Console.WriteLine(file.GetFileExtension());
            Console.WriteLine(pdfFile.GetFileExtension());
            Console.WriteLine(newPdfFile.GetFileExtension());

            Console.WriteLine(file.GetFileNameWithoutExtension());
            Console.WriteLine(pdfFile.GetFileNameWithoutExtension());
            Console.WriteLine(newPdfFile.GetFileNameWithoutExtension());

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}",
                Math.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}",
                Math.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Parallelepiped figure = new Parallelepiped(3, 4, 5);
            Console.WriteLine("Volume = {0:f2}", figure.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", figure.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", figure.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", figure.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", figure.CalcDiagonalYZ());
        }
    }
}
