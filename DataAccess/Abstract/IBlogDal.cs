using System;
using Core.DataAccess;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
	public interface IBlogDal : IEntityRepository<Blog>
    {
   
    }
}