using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
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

        public IDataResult<Blog> GetById(int blogId)
        {
            return new SuccesDataResult<Blog>(_blogDal.Get(x => x.BlogId == blogId), Messages.UserNotFound);
        }

        public IDataResult<List<Blog>> GetList()
        {
            return new SuccesDataResult<List<Blog>>(_blogDal.GetAll().ToList());
        }
        public IDataResult<List<Blog>> GetListActive()
        {
            return new SuccesDataResult<List<Blog>>(_blogDal.GetAll(x => x.BlogStatus == true).ToList());
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