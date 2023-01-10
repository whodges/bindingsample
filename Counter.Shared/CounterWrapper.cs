using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    internal static class CounterWrapper
    {
#if __ANDROID__
        const string DllName = "libCounterAndroid.so";
#elif __IOS__
        const string DllName = "__Internal";
#else
        const string DllName = "CounterWindows.dll";
#endif
        internal static string GetDllName() { return DllName; }

        [DllImport(DllName)]
        internal static extern IntPtr CreateCounter();

        [DllImport(DllName)]
        internal static extern int GetCount(IntPtr counter);

        [DllImport(DllName)]
        internal static extern void SetCount(IntPtr counter, int count);

        [DllImport(DllName)]
        internal static extern void DeleteCounter(IntPtr counter);
    }
}
