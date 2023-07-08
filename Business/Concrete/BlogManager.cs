using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public IResult Add(Blog blog)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _blogDal.Add(blog);
            return new SuccesResult(Messages.UserNotFound);
        }

        public IResult Delete(Blog blog)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _blogDal.Delete(blog);
            return new SuccesResult(Messages.UserNotFound);
        }
        public IDataResult<List<BlogDetailsDto>> GetBlogDetails()
        {

            return new SuccesDataResult<List<BlogDetailsDto>>(_blogDal.GetBlogDetails(), Messages.ProductsListed);
        }

        public IDataResult<Blog> GetById(int blogId)
        {
            return new SuccesDataResult<Blog>(_blogDal.Get(x => x.BlogId == blogId), Messages.UserNotFound);
        }

        public IDataResult<List<Blog>> GetList()
        {
            return new SuccesDataResult<List<Blog>>(_blogDal.GetAll().ToList());
        }
        public IDataResult<List<Blog>> GetListActive(int page)
        {
            int postCount = 6;
            int skipCount = page * postCount;
            return new SuccesDataResult<List<Blog>>(_blogDal.GetAll(x => x.BlogStatus == true).Skip(skipCount - 6).Take(postCount).ToList());
        }
      
        public IDataResult<List<Blog>> GetBlogDetailsLast3Post()
        {
            return new SuccesDataResult<List<Blog>>(_blogDal.GetAll(x => x.BlogStatus == true).OrderByDescending(x => x.BlogId).Take(5).ToList(), Messages.PasswordError);
        }
        public decimal GetCount()
        {
            decimal productquantity = (_blogDal.GetAll(x => x.BlogStatus == true).GroupBy(x => x.BlogId).Count());
            decimal pagequantity = productquantity / 6;
            pagequantity = Math.Ceiling(pagequantity);
            return pagequantity;
        }

        public IResult Update(Blog blog)
        {
            IResult result = BusinessRules.Run();
            if (result != null)
            {
                return result;
            }
            _blogDal.Update(blog);
            return new SuccesResult(Messages.UserRegistered);
        }
    }
}