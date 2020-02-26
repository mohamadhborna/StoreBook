using System;
using System.Collections.Generic;

namespace udemyproject.models
{
	public class Book:BaseEntity
	{
		public string Isbn{get; set;}
		public string Title{get; set;}
		public DateTime PublishTime{get; set;}
		public ICollection<Review> Reviews{ get; set;}
		public ICollection<BookAuther> BookAuthers{ get; set;}
		public ICollection<BookCategory> BookCategories{ get; set;}
	}


}
