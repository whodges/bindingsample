using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    public class MyCounter : IDisposable
    {
        private readonly MyCounterSafeHandle _handle;

        public MyCounter()
        {
            try
            {
                _handle = CounterWrapper.CreateCounter();

                //if (_handle == null || _handle.IsInvalid)
                //  throw new Exception("Failed to create counter.");
            }
            catch (Exception e)
            {
                // This fails with DllNotFoundException on iOS
                _handle = null;
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_handle != null && !_handle.IsInvalid)
                    _handle.Dispose();
            }
        }

        public string GetDllName()
        {
            return CounterWrapper.GetDllName();
        }

        public int GetCount()
        {
            if (_handle == null || _handle.IsInvalid)
                return -1;

            return CounterWrapper.GetCount(_handle);
        }

        public void SetCount(int count)
        {
            if (_handle == null || _handle.IsInvalid)
                return;

            CounterWrapper.SetCount(_handle, count);
        }
    }
}
