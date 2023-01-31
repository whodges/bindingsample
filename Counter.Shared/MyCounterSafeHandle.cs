using System;
using Microsoft.Win32.SafeHandles;

namespace Counter
{
    internal class MyCounterSafeHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        public MyCounterSafeHandle() : base(true) { }

        public IntPtr Ptr => handle;

        protected override bool ReleaseHandle()
        {
            CounterWrapper.DeleteCounter(this);
            return true;
        }
    }
}