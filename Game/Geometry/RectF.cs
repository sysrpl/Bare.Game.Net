namespace Bare.Geometry
{
    public struct RectF
    {
        public static explicit operator RectI(RectF rect)
        {
            return new RectI((int)rect.X, (int)rect.Y, (int)rect.Width, (int)rect.Height);
        }

        public RectF(float width, float height)
        {
            X = 0;
            Y = 0;
            Width = width;
            Height = height;
        }


        public RectF(float x, float y, float width, float height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public float Left { get { return X; } set { Width -= value; X = value; } }
        public float Top { get { return Y; } set { Height -= value; Y = value; } }

        public override string ToString()
        {
            return string.Format("[RectF: X={0}, Y={1}, Width={2}, Height={3}]", 
                X, Y, Width, Height);
        }
    }
}
