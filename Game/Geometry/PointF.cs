namespace Bare.Geometry
{
    public struct PointF
    {
        public PointF(float x, float y)
        {
            X = 0;
            Y = 0;
        }

        public float X { get; set; }
        public float Y { get; set; }

        public override string ToString()
        {
            return string.Format("[PointF: X={0}, Y={1}]", X, Y);
        }
    }
}
