using System;
using System.Runtime.InteropServices;

namespace Bare.Geometry
{
    public static class Block
    {
        public static int SizeOf<T>(T t)
        {
            return Marshal.SizeOf(typeof(T));
        }

        public static IntPtr Next<T>(IntPtr p, T t)
        {
            return IntPtr.Add(p, Marshal.SizeOf(typeof(T)));
        }
    }
}
