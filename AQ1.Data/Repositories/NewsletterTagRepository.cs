using AQ1.Data.Infrastructure;
using AQ1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Repositories
{
    public interface INewsletterTagRepository : IRepository<NewsletterTag>
    {

    }
    public class NewsletterTagRepository : RepositoryBase<NewsletterTag>, INewsletterTagRepository
    {
        public NewsletterTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
