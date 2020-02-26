using System;
using System.Collections.Generic;


namespace udemyproject.models
{
	public class Country:BaseEntity
	{
	  public string Name{ get; set; }
	  public virtual ICollection<Auther> Authers { get; set; }
	}
}
