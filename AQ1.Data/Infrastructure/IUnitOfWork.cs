using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
