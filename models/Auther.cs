using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace udemyproject.models{
 
	public class Auther:BaseEntity
	{	
        [Required]
		public string FirstName{ get; set;}
		[Required]
		public string LastName{ get; set;}
	    public Country country{ get; set;}
		public ICollection<BookAuther> BookAuthers{ get; set;}
	}


}

