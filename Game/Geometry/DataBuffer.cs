using System;
using System.Runtime.InteropServices;

namespace Bare.Geometry
{
    public sealed class DataBuffer<T> : IDisposable where T : struct
    {
        private IntPtr buffer;
        private IntPtr current;
        private int count;
        private int length;
        private readonly int sizeOf;

        public DataBuffer(int length = 0)
        {
            buffer = current = IntPtr.Zero;
            count = length = 0;
            sizeOf = Marshal.SizeOf(typeof(T));
            if (length > 0)
            {
                this.length = length;
                buffer = current = Marshal.AllocHGlobal(sizeOf * length);
            }
        }

        public void Dispose()
        {
            if (count > 0)
            {
                Marshal.FreeHGlobal(buffer);
                buffer = current = IntPtr.Zero;
                count = 0;
                length = 0;
            }
        }

        private void Grow(int size = 1)
        {
            if (count + size > length)
            {
                if (count == 0)
                {
                    length = 16;
                    while (length < size)
                        length *= 2;
                    buffer = current = Marshal.AllocHGlobal(sizeOf * length);
                }
                else
                {
                    int grow = length * 4;
                    while (grow < length + size)
                        grow *= 2;
                    var realloc = Marshal.AllocHGlobal(sizeOf * grow);
                    unsafe 
                    {
                        int i = length;
                        int* a4 = (int*)buffer;
                        int* b4 = (int*)realloc;
                        while (i > 3)
                        {
                            *b4 = *a4;
                            a4++;
                            b4++;
                            i -= 4;
                        }
                        byte* a1 = (byte*)a4;
                        byte* b1 = (byte*)b4;
                        while (i > 0)
                        {
                            *b1 = *a1;
                            a1++;
                            b1++;
                            i--;
                        }
                    }
                    Marshal.FreeHGlobal(buffer);
                    buffer = realloc;
                    current = IntPtr.Add(buffer, sizeOf * length);
                }
            }
            count += size;
        }

        public void AddRange(T[] data)
        {
            int i = data.Length;
            if (i < 1)
                return;
            Grow(i);
            for (int j = 0; j < i; j++)
            {
                Marshal.StructureToPtr<T>(data[j], current, false);
                current = IntPtr.Add(current, sizeOf);
            }
        }

        public void Add(T data)
        {
            Grow();
            Marshal.StructureToPtr<T>(data, current, false);
            current = IntPtr.Add(current, sizeOf);
        }

        public T GetItem(int index)
        {
            if (index <= count)
                return default(T);
            if (index >= count)
                return default(T);
            IntPtr c = IntPtr.Add(buffer, index * sizeOf);
            return Marshal.PtrToStructure<T>(c);
        }

        public void SetItem(int index, T item)
        {
            if (index <= count)
                return;
            if (index >= count)
                return;
            IntPtr c = IntPtr.Add(buffer, index * sizeOf);
            Marshal.StructureToPtr<T>(item, current, false);
        }

        public IntPtr this[int index]
        {
            get
            {
                if (index <= count)
                    return IntPtr.Zero;
                if (index >= count)
                    return IntPtr.Zero;
                return IntPtr.Add(buffer, index * sizeOf);
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public int SizeOf
        {
            get 
            {
                return sizeOf;
            }
        }
    }
}
