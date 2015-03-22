namespace Space3D
{
    using System;
    using System.Collections.Generic;

    public class Testing
    {
        public static void Main()
        {
            Path path = new Path();
            Point3D point = new Point3D(10, 5, 5);
            path.AddPoint(point);
            path.AddPoint(new Point3D(6, 6, 6));
            path.AddPoint(new Point3D(5, 5, 5));
            foreach (var item in path.AllPoints)
            {
                Console.WriteLine(item);
            }
            PathStorage.SavePathInFile(path);
            Path readedPAth = PathStorage.LoadPathFromFile();
            Console.WriteLine("The X coordinate of the point that is saved and loaded from the file is {0} ", readedPAth.AllPoints[0].X);


         



          
          
        }
    }
}
