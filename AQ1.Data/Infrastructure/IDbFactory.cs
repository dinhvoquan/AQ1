using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Infrastructure
{
    public interface IDbFactory: IDisposable
    {
        AQ1DbContext Init();
    }
}
