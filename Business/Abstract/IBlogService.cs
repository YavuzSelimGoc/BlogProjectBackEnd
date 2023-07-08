using System;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
	public interface IBlogService
	{

        IDataResult<Blog> GetById(int blogId);
        IDataResult<List<Blog>> GetList();
        IDataResult<List<Blog>> GetListActive();
        IResult Add(Blog blog);
        IResult Delete(Blog blog);
        IResult Update(Blog blog);
    }
}

