using AQ1.Data.Infrastructure;
using AQ1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Data.Repositories
{
    public interface INewsletterCategoryRepository : IRepository<NewsletterCategory>
    {

    }
    public class NewsletterCategoryRepository : RepositoryBase<NewsletterCategory>, INewsletterCategoryRepository
    {
        public NewsletterCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
