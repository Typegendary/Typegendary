using Typegendary_Classes.MapPoint;

namespace Typegendary_Classes
{
    public class Map
    {
        public int Height { get; }
        public int Width { get; }
        private Point[,] Points { get; }
        private Point this[int i, int j] => Points[i, j];
        public Map(int height, int width)
        {
            Height = height;
            Width = width;
            Points = new Point[width, height];
        }

        // PointWall[ 10 , 10 ]
        // PointWall[ 01 , 01 ]
        // PointWall.Wall_0
    }
}
