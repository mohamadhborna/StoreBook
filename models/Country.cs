using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace udemyproject.models
{
	public class Country:BaseEntity
	{
	  [Required]
	  public string Name{ get; set; }
	  public virtual ICollection<Auther> Authers { get; set; }
	}
}
