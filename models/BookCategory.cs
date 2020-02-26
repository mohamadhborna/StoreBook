using System;
using System.Collections.Generic;

namespace udemyproject.models
{
	public class BookCategory
	{
		public int BookId{ get; set; }
		public Book Book{ get; set;}
		public int CategoryId{ get; set;}
		public Category Category{ get; set; }	
	}
}
