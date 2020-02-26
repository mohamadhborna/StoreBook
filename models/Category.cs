using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace udemyproject.models
{
	public class Category:BaseEntity
	{
		[Required]
		public string Name{ get; set;}
		public ICollection<BookCategory> BookCategories{ get; set;}
	}
}
