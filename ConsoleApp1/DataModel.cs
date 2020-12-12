using NetTopologySuite.Geometries;

namespace ConsoleApp1
{
    public class DataModel
    {
        public int id { get; set; }
        public Point location1 { get; set; }
        public Point location2 { get; set; }
        public int value { get; set; }
    }
}