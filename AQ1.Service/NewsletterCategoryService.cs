using AQ1.Data.Infrastructure;
using AQ1.Data.Repositories;
using AQ1.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.Service
{
    public interface INewsletterCategoryService
    {
        NewsletterCategory Add(NewsletterCategory newsletterCategory);
        void Update(NewsletterCategory newsletterCategoy);
        NewsletterCategory Delete(int id);
        IEnumerable<NewsletterCategory> GetAll();
        IEnumerable<NewsletterCategory> GetAllParentId(int parentId);
        NewsletterCategory GetById(int id);
        void Save();
    }
    public class NewsletterCategoryService : INewsletterCategoryService
    {
        private INewsletterCategoryRepository _newsletterCategoryRepository;
        private IUnitOfWork _unitOfWork;
        public NewsletterCategoryService(INewsletterCategoryRepository newsletterCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._newsletterCategoryRepository = newsletterCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public NewsletterCategory Add(NewsletterCategory newsletterCategory)
        {
            return _newsletterCategoryRepository.Add(newsletterCategory);
        }

        public NewsletterCategory Delete(int id)
        {
            return _newsletterCategoryRepository.Delete(id);
        }

        public IEnumerable<NewsletterCategory> GetAll()
        {
            return _newsletterCategoryRepository.GetAll();
        }

        public IEnumerable<NewsletterCategory> GetAllParentId(int parentId)
        {
            return _newsletterCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public NewsletterCategory GetById(int id)
        {
            return _newsletterCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(NewsletterCategory newsletterCategoy)
        {
            _newsletterCategoryRepository.Update(newsletterCategoy);
        }
    }
}
