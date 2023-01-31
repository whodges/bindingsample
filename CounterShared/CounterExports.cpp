#include "CounterExports.h"

MyCounter* CreateCounter()
{
    return new MyCounter();
}

int GetCount(MyCounter* counter)
{
    if (counter != nullptr)
        return counter->_count;

    return -1;
}

void SetCount(MyCounter* counter, int count)
{
    if (counter != nullptr)
        counter->_count = count;
}

void DeleteCounter(MyCounter* counter)
{
    if (counter != nullptr)
    {
        delete counter;
        counter = nullptr;
    }
}
