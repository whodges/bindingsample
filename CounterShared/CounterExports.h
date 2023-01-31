#pragma once

#include "MyCounter.h"
using namespace Counter;

#ifdef _WINDOWS
#define DllExport _declspec(dllexport)
#else
#define DllExport
#endif

extern "C"
{
    DllExport MyCounter* CreateCounter();
    DllExport int GetCount(MyCounter* counter);
    DllExport void SetCount(MyCounter* counter, int count);
    DllExport void DeleteCounter(MyCounter* counter);
}
