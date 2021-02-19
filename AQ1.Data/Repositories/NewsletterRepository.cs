using AQ1.Data.Infrastructure;
using AQ1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Repositories
{
    public interface INewsletterRepository : IRepository<Newsletter>
    {

    }
    public class NewsletterRepository : RepositoryBase<Newsletter>, INewsletterRepository
    {
        public NewsletterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
