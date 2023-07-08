using System;
using Core.DataAccess;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq.Expressions;
using Entities.DTOs;

namespace DataAccess.Abstract
{
	public interface IBlogDal : IEntityRepository<Blog>
    {
        List<BlogDetailsDto> GetBlogDetails();
    }
}