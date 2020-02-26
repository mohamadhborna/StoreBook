using System;
using System.Collections.Generic;

namespace udemyproject.models
{
	public class Review:BaseEntity
	{
		public string HeadLine{ get; set;}
		public string ReviewText { get; set;}
		public int Rating{ get; set; }
		public Reviewer Reviewer{ get; set;}
		public Book Book{ get; set;}
	}
}
