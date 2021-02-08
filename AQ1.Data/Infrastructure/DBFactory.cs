using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public class DBFactory: Disposable, IDbFactory
    {
        private AQ1DBContext dbContext;
        public AQ1DBContext Init()
        {
            return dbContext ?? (dbContext = new AQ1DBContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
