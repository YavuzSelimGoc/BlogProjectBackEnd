using System;
using System.Collections.Generic;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfBlogDal : EfRepositoryBase<Blog, BlogContext>, IBlogDal
    {
        public List<BlogDetailsDto> GetBlogDetails()
        {
            using (BlogContext northwindContext = new BlogContext())
            {
                var result = from p in northwindContext.Blog
                             join c in northwindContext.Category
                             on p.CategoryId equals c.CategoryId

                             select new BlogDetailsDto
                             {
                                 BlogId = p.BlogId,
                                 BlogTitle = p.BlogTitle,
                                 CategoryName = c.CategoryName,
                                 CategoryId = p.CategoryId,
                                 BlogContent = p.BlogContent,
                                 BlogWriter = p.BlogWriter,
                                 BlogTag = p.BlogTag,
                                 BlogImage = p.BlogImage,
                                 BlogDate = p.BlogDate,
                                 BlogStatus = p.BlogStatus

                             };
                return result.ToList();
            }

        }
    }
}

