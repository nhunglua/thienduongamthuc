using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThienDuongAmThuc.Data.Infrastructure;
using ThienDuongAmThuc.Data.Repositories;
using ThienDuongAmThuc.Model.Models;

namespace ThienDuongAmThuc.Service
{
    public interface IProductCategoryService
    {
        ProductCategory Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAllByparentID(int parentID);

        ProductCategory GetById(int id);
        void Save();
    }
    public class ProductCategoryService : IProductCategoryService
    {
        IProductCategoryRepository _productCategoryRepository;
        IUnitOfWork _unitOfWork;
        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public ProductCategory Add(ProductCategory ProductCategory)
        {
            return _productCategoryRepository.Add(ProductCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
          return _productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllByparentID(int parentID)
        {
            return _productCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentID);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.GetSingleByID(id);
        }

        public void Save()
        {
            _unitOfWork.commit();
        }

        public void Update(ProductCategory ProductCategory)
        {
            _productCategoryRepository.Update(ProductCategory);
        }
    }
}