using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace udemyproject.models
{
	public class Reviewer:BaseEntity
	{
		[Required]
		public string FirstName{ get; set;}
		[Required]
		public string LastName{ get; set;}
		public ICollection<Review> Reviews{ get; set;}

	}
}
