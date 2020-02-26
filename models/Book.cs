using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace udemyproject.models
{
	public class Book:BaseEntity
	{
		[Required]
		public string Isbn{get; set;}
		[Required]
		public string Title{get; set;}
		public DateTime? PublishTime{get; set;}
		public ICollection<Review> Reviews{ get; set;}
		public ICollection<BookAuther> BookAuthers{ get; set;}
		public ICollection<BookCategory> BookCategories{ get; set;}
	}


}
