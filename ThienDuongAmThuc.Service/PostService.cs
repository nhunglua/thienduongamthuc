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
    public interface IPostService
    {
        void Add(Post post);
        void Update(Post post);
        void Delete(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAllPagding(int page, int pageSize, out int totalRow);
        Post GetById(int id);
        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pageSize, out int totalRow);
        void SaveChange();
    }
    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        // tiem vao 2 doi tuong vao contructer cua service , tu dong tim  de co the gan bien noi tai va su dung cac phuong thuc.
        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
            
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            //TODO: select all post by tag
            return _postRepository.GetMuiltiPaging(x => x.Status , out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPagding(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMuiltiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleByID(id);
        }

        public void SaveChange()
        {
            _unitOfWork.commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
