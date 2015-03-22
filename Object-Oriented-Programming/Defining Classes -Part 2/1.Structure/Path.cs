using System;
using System.Collections.Generic;


namespace Space3D
{
    [Serializable]
    public class Path
    {
        private List<Point3D> points;

        public List<Point3D> Points { get; set; }
        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> AllPoints
        {
            get
            {
                if (Points.Count == 0)
                {
                    throw new ArgumentNullException("There are no points");

                }

                return new List<Point3D>(this.Points);
            }

        }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }
    }
}
