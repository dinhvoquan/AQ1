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
    public interface INewsletterService
    {       
        void Add(Newsletter newsletter);
        void Update(Newsletter newsletter);
        void Delete(Newsletter newsletter);
        IEnumerable<Newsletter> GetAll();
        IEnumerable<Newsletter> GetAllPaging(int page, int pageSize, out int totalRow);
        IEnumerable<Newsletter> GetAllByCategoryPaging(int categoryId, int page, int pageSize, out int totalRow);
        Newsletter GetById(int id);
        IEnumerable<Newsletter> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        void SaveChanges();
    }
    public class NewsletterService : INewsletterService
    {
        INewsletterRepository _newsletterRepository;
        IUnitOfWork _unitOfWork;
        public NewsletterService(INewsletterRepository newsletterRepository, IUnitOfWork unitOfWork)
        {
            this._newsletterRepository = newsletterRepository;
            this._unitOfWork = unitOfWork;
        } 
        public void Add(Newsletter newsletter)
        {
            _newsletterRepository.Add(newsletter);
        }

        public void Delete(Newsletter newsletter)
        {
            _newsletterRepository.Delete(newsletter);
        }

        public IEnumerable<Newsletter> GetAll()
        {
            return _newsletterRepository.GetAll(new string[] {"NewsletterCategory"});
        }

        public IEnumerable<Newsletter> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: Select all newsletter by tag
            return _newsletterRepository.GetMultiPaging(x => x.Status,out totalRow,page,pageSize);
        }

        public IEnumerable<Newsletter> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _newsletterRepository.GetMultiPaging(x => x.Status,out totalRow,page,pageSize);
        }

        public IEnumerable<Newsletter> GetAllByCategoryPaging(int categoryId,int page,int pageSize, out int totalRow)
        {
            return _newsletterRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pageSize, new string[] { "NewsletterCategory" });
        }
        public Newsletter GetById(int id)
        {
            return _newsletterRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Newsletter newsletter)
        {
            _newsletterRepository.Update(newsletter);
        }
    }
}
