using System;
using System.Runtime.InteropServices;

namespace Bare
{
    public static class IntPtrExtensions
    {
        public static IntPtr Add(this IntPtr p, int size)
        {
            return IntPtr.Add(p, size);
        }

        public static IntPtr Add(this IntPtr p, Type t)
        {
            return IntPtr.Add(p, Marshal.SizeOf(t));
        }
    }
}
