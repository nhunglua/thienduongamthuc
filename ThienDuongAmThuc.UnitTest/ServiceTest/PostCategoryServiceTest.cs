using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Data.Repositories;
using ThienDuongAmThuc.Model.Models;
using ThienDuongAmThuc.Service;

namespace ThienDuongAmThuc.UnitTest.ServiceTest
{
    [TestClass]
    public class PostCategoryServiceTest
    {
        private Mock<IPostCategoryRepository> _mockReponsitory;
        private Mock<IUnitOfWork> _mockUnitOfWork;
        private IPostCategoryService _categoryService;
        private List<PostCategory> _listCategory;

        [TestInitialize]
        public void Initialize()
        {
            _mockReponsitory = new Mock<IPostCategoryRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _categoryService = new PostCategoryService(_mockReponsitory.Object, _mockUnitOfWork.Object);
            _listCategory = new List<PostCategory>()
            {
                new PostCategory() { ID=1, Name= "DM1" , Status=true},
                new PostCategory() { ID=2, Name= "DM2" , Status=true},
                new PostCategory() { ID=3, Name= "DM3" , Status=true},
                new PostCategory() { ID=4, Name= "DM4" , Status=true},
                new PostCategory() { ID=5, Name= "DM5" , Status=true},
                new PostCategory() { ID=6, Name= "DM6" , Status=true}
            };
        }

        [TestMethod]
        public void PostCategory_Service_GetAll()
        {
            //set up method
            _mockReponsitory.Setup(m => m.GetAll(null)).Returns(_listCategory);

            //call action
            var result = _categoryService.GetAll() as List<PostCategory>;

            //compare.
            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.Count);
        }

        [TestMethod]
        public void PostCategory_Service_Create()
        {
            PostCategory category = new PostCategory();
            int id = 1;
            category.Name = "Test";
            category.Alias = "test";
            category.Status = true;
            //thiết lập một phương thức Add trả về ID=1
            _mockReponsitory.Setup(m => m.Add(category)).Returns((PostCategory p) => { p.ID=1; return p; });
            _categoryService.Add(category);
            var result = _categoryService.Add(category);

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.ID);
            
        }
    }
}