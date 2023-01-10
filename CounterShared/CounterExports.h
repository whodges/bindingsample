#pragma once

#include "Counter.h"

#ifdef _WINDOWS
#define DllExport _declspec(dllexport)
#else
#define DllExport
#endif

extern "C"
{
    DllExport Counter* CreateCounter();
    DllExport int GetCount(Counter* counter);
    DllExport void SetCount(Counter* counter, int count);
    DllExport void DeleteCounter(Counter* counter);
}
