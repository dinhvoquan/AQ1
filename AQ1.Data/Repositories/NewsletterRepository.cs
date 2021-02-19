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
        IEnumerable<Newsletter> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }
    public class NewsletterRepository : RepositoryBase<Newsletter>, INewsletterRepository
    {
        public NewsletterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Newsletter> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from p in DbContext.Newsletters
                        join pt in DbContext.NewsletterTags
                        on p.ID equals pt.NewsletterID
                        where pt.TagID == tag && p.Status
                        orderby p.CreatedDate descending
                        select p;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}
