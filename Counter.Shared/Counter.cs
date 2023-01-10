using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class Counter : IDisposable
    {
        private IntPtr _counter;

        public Counter()
        {
            _counter = CounterWrapper.CreateCounter();
            if (_counter == IntPtr.Zero)
                throw new Exception("Failed to create counter.");
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                CounterWrapper.DeleteCounter(_counter);
                _counter = IntPtr.Zero;
            }
        }

        public string GetDllName()
        {
            return CounterWrapper.GetDllName();
        }

        public int GetCount()
        {
            if (_counter == IntPtr.Zero)
                return -1;

            return CounterWrapper.GetCount(_counter);
        }

        public void SetCount(int count)
        {
            if (_counter == IntPtr.Zero)
                return;

            CounterWrapper.SetCount(_counter, count);
        }
    }
}
