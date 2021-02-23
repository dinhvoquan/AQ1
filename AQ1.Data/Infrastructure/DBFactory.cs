using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public class DbFactory: Disposable, IDbFactory
    {
        private AQ1DbContext dbContext;
        public AQ1DbContext Init()
        {
            return dbContext ?? (dbContext = new AQ1DbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
