using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public class Disposable : IDisposable
    {     
        private bool isDisposed;

        //Overide this to dispose custom objects
        protected virtual void DisposeCore()
        {

        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
