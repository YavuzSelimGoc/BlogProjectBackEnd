using System;
using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface IBlogService
	{

        IDataResult<Blog> GetById(int blogId);
        IDataResult<List<Blog>> GetList();
        IDataResult<List<Blog>> GetListActive(int page);
        IResult Add(Blog blog);
        decimal GetCount();
        IDataResult<List<BlogDetailsDto>> GetBlogDetails();
        IDataResult<List<Blog>> GetBlogDetailsLast3Post();
        IResult Delete(Blog blog);
        IResult Update(Blog blog);
    }
}

