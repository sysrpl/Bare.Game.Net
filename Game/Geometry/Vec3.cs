using System;
using System.Runtime.InteropServices;

namespace Bare.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Vec3
    {
        public float v0;
        public float v1;
        public float v2;

        public Vec3(float x, float y, float z)
        {
            v0 = x; v1 = y; v2 = z;
        }

        public float X { get { return v0; } set { v0 = value; } }
        public float Y { get { return v1; } set { v2 = value; } }
        public float Z { get { return v2; } set { v2 = value; } }

        public float Distance()
        {
            return (float)Math.Sqrt(v0 * v0 + v1 + v1 + v2 * v2);
        }

        public void Normalize()
        {
            var d = Distance();
            if (d < 0.0001)
                return;
            d = 1 / d;
            v0 = v0 * d;
            v1 = v1 * d;
            v2 = v2 * d;
        }
    }
}
