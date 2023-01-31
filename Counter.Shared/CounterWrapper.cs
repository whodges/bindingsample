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

        [DllImport(DllName, EntryPoint = "CreateCounter")]
        internal static extern MyCounterSafeHandle CreateCounter();

        [DllImport(DllName, EntryPoint = "GetCount")]
        internal static extern int GetCount(MyCounterSafeHandle counter);

        [DllImport(DllName, EntryPoint = "SetCount")]
        internal static extern void SetCount(MyCounterSafeHandle counter, int count);

        [DllImport(DllName, EntryPoint = "DeleteCounter")]
        internal static extern void DeleteCounter(MyCounterSafeHandle counter);
    }
}
