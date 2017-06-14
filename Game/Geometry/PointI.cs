namespace Bare.Geometry
{
    public struct PointI
    {
        public PointI(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return string.Format("[PointI: X={0}, Y={1}]", X, Y);
        }
    }
}