using AQ1.Data.Infrastructure;
using AQ1.Data.Repositories;
using AQ1.Model.Models;
using AQ1.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ1.UnitTest.ServiceTest
{
    [TestClass]
    public class NewsletterCategoryServiceTest
    {
        private Mock<INewsletterCategoryRepository> _mockRepository;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private INewsletterCategoryService _categoryService;
        private List<NewsletterCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<INewsletterCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new NewsletterCategoryService(_mockRepository.Object, _mockUnitOfWork.Object);
            _listCategory = new List<NewsletterCategory>()
            {
                new NewsletterCategory() {ID=1,Name="DM1",Status=true},
                new NewsletterCategory() {ID=2,Name="DM2",Status=true },
                new NewsletterCategory() {ID=3,Name="DM3",Status=true },
            };
        }

        [TestMethod]
        public void NewsletterCategory_Service_GetAll()
        {
            //Setup method
            _mockRepository.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //Call action
            var result = _categoryService.GetAll() as List<NewsletterCategory>;

            //Compare
            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.Count);
        }

        [TestMethod]
        public void NewsletterCategory_Service_Create()
        {
            NewsletterCategory category = new NewsletterCategory();
            int id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;

            _mockRepository.Setup(m => m.Add(category)).Returns((NewsletterCategory p) =>
            {
                p.ID = 1; return p;
            });

            var result = _categoryService.Add(category);
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
        }
    }
}
