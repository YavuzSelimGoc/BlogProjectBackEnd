﻿using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class BlogDetailsDto:IDto
	{

        public int BlogId { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string BlogTitle { get; set; }
        public string BlogImage { get; set; }
        public string BlogContent { get; set; }
        public string BlogWriter { get; set; }
        public DateTime BlogDate { get; set; }
        public string BlogTag { get; set; }
        public bool BlogStatus { get; set; }
    
	}
}
