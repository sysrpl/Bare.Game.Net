using System;

namespace Bare
{
    public abstract class ContextHandle : IDisposable
    {
        private bool destroyed = false;

        protected abstract void Destroy();

        protected void SetHandle(int handle)
        {
            Handle = handle;
        }

        public void Dispose()
        {
            if (!destroyed)
            {
                destroyed = true;
                var h = Handle;
                try
                {
                    Destroy();
                }
                finally
                {
                    Handle = 0;
                }
            }
        }

        public int Handle { get; private set; } = 0;
    }
}
