using System;
using System.Collections.Generic;

namespace PortlandLocalBusinesses.Models
{
  public class Neighborhood
  {
		public Neighborhood()
		{
			this.Businesses = new HashSet<Business>();
		}
    public int NeighborhoodId { get; set; }
    public string Name { get; set; }
		public ICollection<Business> Businesses {get; set;}
  }
}