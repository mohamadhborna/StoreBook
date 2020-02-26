using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace udemyproject.models
{
	public class Review:BaseEntity
	{
		[Required]
		public string HeadLine{ get; set;}
		[Required]
		public string ReviewText { get; set;}
		[Required]
		public int Rating{ get; set; }
		public Reviewer Reviewer{ get; set;}
		public Book Book{ get; set;}
	}
}
