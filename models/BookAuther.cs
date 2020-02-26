using System;
using System.Collections.Generic;

namespace udemyproject.models
{
	public class BookAuther
	{
		public int BookId{ get; set;}
		public Book Book{ get; set; }
		public int AutherId{ get; set;}
		public Auther Auther{ get; set;}

	}
}
