using System;
using System.Collections.Generic;


namespace udemyproject.models
{
	public class Category:BaseEntity
	{
		public string Name{ get; set;}
		public ICollection<BookCategory> BookCategories{ get; set;}
	}
}
