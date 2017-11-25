using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Data.Repositories;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.UnitTest.RepositoryTest
{
    [TestClass]
    public class PostCategoryReposioryTest
    {
        // dung ba interface nay de tuong tac voi DB
        private IDbFactory dbFactory;

        private IPostCategoryRepository objRepository;
        private IUnitOfWork unitOfWork;

        [TestInitialize] //co 1 cai phuong thuc, thuoc tinh giup ta chay lan dau tien khi chay de thiet lap tham so , khoi tao doi tuong
        public void Initialize()
        {
            //Khoi tao 3 doi tuong rui dung no de test
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);
            unitOfWork = new UnitOfWork(dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(6, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test category";
            category.Alias = "Test-category";
            category.Status = true;

            var result = objRepository.Add(category);
            unitOfWork.commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(6, result.ID);
        }
    }
}