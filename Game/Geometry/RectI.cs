namespace Bare.Geometry
{
    public struct RectI
    {
        public static implicit operator RectF(RectI rect)
        {
            return new RectI(rect.X, rect.Y, rect.Width, rect.Height);
        }

        public RectI(int width, int height)
        {
            X = 0;
            Y = 0;
            Width = width;
            Height = height;
        }


        public RectI(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Left { get { return X; } set { Width -= value; X = value; } }
        public int Top { get { return Y; } set { Height -= value; Y = value; } }

        public override string ToString()
        {
            return string.Format("[RectI: X={0}, Y={1}, Width={2}, Height={3}]",
                X, Y, Width, Height);
        }
    }
}
