using System;
using System.Collections.Generic;

namespace udemyproject.models
{
	public class Reviewer:BaseEntity
	{
		public string FirstName{ get; set;}
		public string LastName{ get; set;}
		public ICollection<Review> Reviews{ get; set;}

	}
}
