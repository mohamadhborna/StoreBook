using System;
using System.Collections.Generic;


namespace udemyproject.models{
 
	public class Auther:BaseEntity
	{	
		public string FirstName{ get; set;}
		public string LastName{ get; set;}
	    public Country country{ get; set;}
		public ICollection<BookAuther> BookAuthers{ get; set;}
	}


}

