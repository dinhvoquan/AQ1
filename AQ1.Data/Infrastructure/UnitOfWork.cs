using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private AQ1DBContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public AQ1DBContext DbContext
        {
            get { return DbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
