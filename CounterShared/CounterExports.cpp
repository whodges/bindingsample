#include "CounterExports.h"

Counter* CreateCounter()
{
    return new Counter();
}

int GetCount(Counter* counter)
{
    if (counter != nullptr)
        return counter->_count;

    return -1;
}

void SetCount(Counter* counter, int count)
{
    if (counter != nullptr)
        counter->_count = count;
}

void DeleteCounter(Counter* counter)
{
    if (counter != nullptr)
    {
        delete counter;
        counter = nullptr;
    }
}
