using AQ1.Data.Infrastructure;
using AQ1.Data.Repositories;
using AQ1.Model.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.UnitTest.RepositoryTest
{
    [TestClass]
    public class NewsletterCategoryRepositoryTest
    {        
        IDbFactory dbFactory;
        INewsletterCategoryRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]       
        public void Initialize()
        {
            dbFactory = new DBFactory();
            objRepository = new NewsletterCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void NewsletterCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void NewsletterCategory_Repository_Create()
        {
            NewsletterCategory category = new NewsletterCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }
    }
}
