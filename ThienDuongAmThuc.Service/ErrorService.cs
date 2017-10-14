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
    public interface IErrorService
    {
        Error Creat(Error error);
        void Save();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfWork;

        public ErrorService(IErrorRepository errorReponsitory, IUnitOfWork unitOfWork)
        {
            this._errorRepository = errorReponsitory;
            this._unitOfWork = unitOfWork;
        }
        public Error Creat(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.commit();
        }
    }
}
