using System;
using Typegendary_Classes.MapPoint;

namespace Typegendary_Classes
{
    public class Map
    {
        public int Size { get; }
        private Point[,] Points { get; }
        private Point this[int i, int j] => Points[i, j];
        public Map(byte[] mapFile)
        {
            Size = (int)Math.Sqrt(mapFile.Length);
            Points = new Point[Size, Size];
            for(int i=0;i<Size;i++)
                for(int j=0;j<Size;j++)
                {
                    byte value = mapFile[i * Size + j];
                    int highDigit = value / 0x10, lowDigit = value % 0x10;
                    switch (highDigit)
                    {
                        case 0xA:
                            Points[i, j] = new Point() { PointType = (Point.Type)lowDigit };
                            break;
                        case 0xB:
                            Points[i, j] = new Material { PointType = (Material.Type)lowDigit };
                            break;
                        case 0xC:
                            Points[i, j] = new Wall() { PointType = (Wall.Type)lowDigit };
                            break;
                    }
                }
        }
    }
}
