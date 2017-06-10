using System.Runtime.InteropServices;

namespace Bare.Geometry
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Mat4
    {
        public float m00;
        public float m01;
        public float m02;
        public float m03;
        public float m10;
        public float m11;
        public float m12;
        public float m13;
        public float m20;
        public float m21;
        public float m22;
        public float m23;
        public float m30;
        public float m31;
        public float m32;
        public float m33;

        public void Identity()
        {
            m01 = m02 = m03 =
            m10 = m12 = m13 =
            m20 = m21 = m23 =
            m30 = m31 = m32 = 0;
            m00 = m11 = m22 = m33 = 1;
        }
    }
}
