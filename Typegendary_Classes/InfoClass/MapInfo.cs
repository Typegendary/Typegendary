namespace Typegendary2_Server.InfoClass
{
    public enum PointType
    {
        Real_Wall,
        Virtual_Wall,
        No_Wall
    }
    public class MapInfo
    {
        public int Height { get; }
        public int Width { get; }
        private PointType[,] Pixels { get; }
        public PointType this[int i, int j] => Pixels[i, j];
        public MapInfo(int height, int width)
        {
            Height = height;
            Width = width;
            Pixels = new PointType[width, height];
        }
    }
}
