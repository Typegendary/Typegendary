namespace Typegendary_Classes.MapPoint
{
    public class Wall : Point
    {
        public new enum Type
        {
            Wall_0,
            Wall_1,

            // To add
        }
        public new Type PointType { get; set; }

        // Properties here
    }
}
